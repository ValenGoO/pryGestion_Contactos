using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGestion_Contactos
{
    public partial class frmBuscar : Form
    {
        clsConexion conexion = new clsConexion();
        public frmBuscar()
        {
            InitializeComponent();
            conexion.Mostrar(dgvContactos);
            conexion.Mostrar(cmbCategoria);
            cmbCategoria.SelectedIndex = -1;
            btnExportar.BackColor = Color.Green;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            if (!string.IsNullOrWhiteSpace(nombre))
            {
                conexion.Buscar_nom(dgvContactos, nombre);
            }
          

            txtNumero.Clear();
            cmbCategoria.SelectedIndex = -1;

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            txtNumero.TextChanged -= txtNumero_TextChanged;
            string texto = txtNumero.Text;
            texto = texto.Replace("-", "");
            if (texto.Length > 3)
            { texto = texto.Insert(3, "-"); }
            txtNumero.Text = texto;
            txtNumero.SelectionStart = texto.Length;
            string nombre = txtNumero.Text.Trim();
            if (!string.IsNullOrWhiteSpace(nombre))
            {
                conexion.Buscar_num(dgvContactos, nombre);
            }


            txtNombre.Clear();
            cmbCategoria.SelectedIndex = -1;
            txtNumero.TextChanged += txtNumero_TextChanged;
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtNumero.Clear();
            
            if (cmbCategoria.SelectedIndex >= 0)
            {
                conexion.Buscar_cat(dgvContactos, cmbCategoria.SelectedIndex + 1);
            }
            else
            {
                conexion.Mostrar(dgvContactos);
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            conexion.Exportar_txt(dgvContactos);
            conexion.Exportar_csv(dgvContactos);
        }
    }
}
