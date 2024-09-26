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
    public partial class frmElim_Modi : Form
    {
        int codigo = 0;
        clsConexion conexion = new clsConexion();
        public frmElim_Modi()
        {
            InitializeComponent();
            conexion.Mostrar(dgvContactos);
            conexion.Mostrar(cmbCategoria);
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnEliminar.BackColor = Color.IndianRed;
            btnModificar.BackColor = Color.IndianRed;
            txtNombre.TextChanged += TextBox_TextChanged;
            txtApellido.TextChanged += TextBox_TextChanged;
            txtNumero.TextChanged += TextBox_TextChanged;
            txtMail.TextChanged += TextBox_TextChanged;
        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {

            EstadoDeTextos();
        }
        private void EstadoDeTextos()
        {
            bool estado = !string.IsNullOrWhiteSpace(txtNombre.Text) && !string.IsNullOrWhiteSpace(txtApellido.Text) && !string.IsNullOrWhiteSpace(txtNumero.Text) && !string.IsNullOrWhiteSpace(txtMail.Text);
            btnModificar.Enabled = estado;
            btnEliminar.Enabled = estado;
            if (!estado)
            {
                btnModificar.BackColor = Color.IndianRed;
                btnEliminar.BackColor = Color.IndianRed; 
            }
            else
            {
                btnModificar.BackColor = Color.Green;
                btnEliminar.BackColor = Color.Green; 
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
           
                try
                {
                    clsContacto nuevo = new clsContacto
                    {
                        Codigo = codigo,
                        Nombre = txtNombre.Text,
                        Apellido = txtApellido.Text,
                        Numero = txtNumero.Text,
                        Mail = txtMail.Text,
                        Categoria = cmbCategoria.SelectedIndex + 1
                    };
                    conexion.Modificar(nuevo);
                    conexion.Mostrar(dgvContactos);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        

        private void dgvContactos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvContactos.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvContactos.SelectedRows[0];

                
                if (selectedRow.Cells[0].Value != null)
                {
                    codigo = Convert.ToInt32(selectedRow.Cells[0].Value);
                }

                
                txtNombre.Text = selectedRow.Cells[1]?.Value?.ToString() ?? string.Empty;
                txtApellido.Text = selectedRow.Cells[2]?.Value?.ToString() ?? string.Empty;
                txtNumero.Text = selectedRow.Cells[3]?.Value?.ToString() ?? string.Empty;
                txtMail.Text = selectedRow.Cells[4]?.Value?.ToString() ?? string.Empty;

               
                string categoriaSeleccionada = selectedRow.Cells[5]?.Value?.ToString() ?? string.Empty;
                int indexCategoria = cmbCategoria.FindStringExact(categoriaSeleccionada);

                if (indexCategoria >= 0)
                {
                    cmbCategoria.SelectedIndex = indexCategoria;
                }
                else
                {
                   
                    MessageBox.Show("Categoría no encontrada.");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvContactos.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvContactos.SelectedRows[0];
                clsContacto contacto = new clsContacto
                {
                    Codigo = Convert.ToInt32(selectedRow.Cells[0].Value),
                    Nombre = selectedRow.Cells[1]?.Value?.ToString() ?? string.Empty
                };

                try
                {
                    // Eliminar el contacto
                    conexion.Eliminar(contacto);
                    MessageBox.Show($"Contacto eliminado: {contacto.Nombre}");

                    // Actualizar la vista
                    conexion.Mostrar(dgvContactos);
                    txtNombre.Clear();
                    txtApellido.Clear();
                    txtNumero.Clear();
                    txtMail.Clear();
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el contacto: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún contacto.");
            }
        }
    }
    
}
