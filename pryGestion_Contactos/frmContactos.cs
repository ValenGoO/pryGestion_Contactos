using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace pryGestion_Contactos
{
    public partial class frmContactos : Form
    {
        clsConexion conexion = new clsConexion();
        public frmContactos()
        {
            InitializeComponent();
            conexion.Mostrar(dgvContactos);
            conexion.Mostrar(cmbCategoria);
            btnCargar.Enabled = false;
            btnCargar.BackColor = Color.IndianRed;
            txtNombre.TextChanged += TextBox_TextChanged;
            txtApellido.TextChanged += TextBox_TextChanged;
            txtNumero.TextChanged += TextBox_TextChanged;
            txtMail.TextChanged += TextBox_TextChanged;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                clsContacto nuevo = new clsContacto
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Numero = txtNumero.Text,
                    Mail = txtMail.Text,
                    Categoria = cmbCategoria.SelectedIndex + 1
                };

                conexion.Cargar(nuevo);
                conexion.Mostrar(dgvContactos);
                MessageBox.Show($"{nuevo.Nombre} fue agregado a la Lista de contactos ");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Por favor, introduce valores válidos para Precio y Stock.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtNombre.Clear();
            txtApellido.Clear();
           txtNumero.Clear();
            txtMail.Clear();
            cmbCategoria.SelectedIndex = 0;
        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {

            EstadoDeTextos();
        }
        private void EstadoDeTextos()
        {
            bool estado = !string.IsNullOrWhiteSpace(txtNombre.Text) && !string.IsNullOrWhiteSpace(txtApellido.Text) && !string.IsNullOrWhiteSpace(txtNumero.Text) && !string.IsNullOrWhiteSpace(txtMail.Text);
            btnCargar.Enabled = estado;
            if (estado == false) { btnCargar.BackColor = Color.IndianRed; }
            else { btnCargar.BackColor = Color.Green; }

        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            txtNumero.TextChanged -= txtNumero_TextChanged;
            string texto = txtNumero.Text;
            texto = texto.Replace("-", "");
            if (texto.Length > 3)
            { texto = texto.Insert(3, "-");}
            txtNumero.Text = texto;
            txtNumero.SelectionStart = texto.Length;
            txtNumero.TextChanged += txtNumero_TextChanged;
        }
    }
}
