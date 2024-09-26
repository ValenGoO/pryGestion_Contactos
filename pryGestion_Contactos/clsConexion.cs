using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGestion_Contactos
{
    internal class clsConexion
    {
        OleDbCommand comando;
        OleDbConnection conexion;
        OleDbDataAdapter adaptador;
        string cadena;

        public clsConexion()
        {
            cadena = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=../../BasedeDatos/bdContactos.accdb;";
        }
        public void Mostrar(DataGridView dgvinventario)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                conexion.Open();
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT c.Id, c.Nombre, c.Apellido , c.Numero, c.Mail, p.Categoria\r\nFROM Contacto AS c\r\nINNER JOIN Categorias AS p ON p.Id = c.Categoria;";
                DataTable tablainventario = new DataTable();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tablainventario);
                dgvinventario.DataSource = tablainventario;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
        public void Mostrar(ComboBox combo)
        {
            OleDbConnection conexion = null;
            OleDbCommand comando = null;
            OleDbDataAdapter adaptador = null;
            try
            {
                conexion = new OleDbConnection(cadena);
                conexion.Open();
                comando = new OleDbCommand("SELECT Categoria FROM Categorias;", conexion);
                adaptador = new OleDbDataAdapter(comando);
                DataTable tablaCategorias = new DataTable();
                adaptador.Fill(tablaCategorias);
                combo.DataSource = tablaCategorias;
                combo.DisplayMember = "Categoria";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
        public void Cargar(clsContacto nuevo)
        {
            try
            {
                using (var conexion = new OleDbConnection(cadena))
                using (var comando = new OleDbCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandType = CommandType.Text;

                    comando.CommandText = "INSERT INTO Contacto (Nombre, Apellido, Numero, Mail, Categoria) VALUES (?, ?, ?, ?, ?)";
                    comando.Parameters.AddWithValue("@Nombre", nuevo.Nombre);
                    comando.Parameters.AddWithValue("@Descripcion", nuevo.Apellido);
                    comando.Parameters.AddWithValue("@Precio", nuevo.Numero);
                    comando.Parameters.AddWithValue("@Stock", nuevo.Mail);
                    comando.Parameters.AddWithValue("@Categoria", nuevo.Categoria);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Modificar(clsContacto contacto)
        {
            try
            {
                using (var conexion = new OleDbConnection(cadena))
                using (var comando = new OleDbCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandType = CommandType.Text;



                    comando.CommandText = $"UPDATE Contacto SET Nombre = ?, Apellido = ?, Numero = ?, Mail = ?, Categoria = ? Where Id = {contacto.Codigo}";
                    comando.Parameters.AddWithValue("@Nombre", contacto.Nombre);
                    comando.Parameters.AddWithValue("@Apellido", contacto.Apellido);
                    comando.Parameters.AddWithValue("@Numero", contacto.Numero);
                    comando.Parameters.AddWithValue("@Mail", contacto.Mail);
                    comando.Parameters.AddWithValue("@Categoria", contacto.Categoria);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Eliminar(clsContacto contacto)
        {
            try
            {
                using (var conexion = new OleDbConnection(cadena))
                {
                    using (var comando = new OleDbCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandType = CommandType.Text;
                        comando.CommandText = "DELETE FROM Contacto WHERE Id = ?";
                        comando.Parameters.AddWithValue("@Id", contacto.Codigo);

                        conexion.Open();
                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        public void Buscar_nom(DataGridView buscar, String Nombre)
        {
            try
            {
                using (conexion = new OleDbConnection(cadena))
                {
                    conexion.Open();
                    using (comando = new OleDbCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandType = CommandType.Text;
                        comando.CommandText = "SELECT c.Nombre, c.Apellido, c.Numero, c.Mail, d.Categoria FROM Contacto AS c INNER JOIN Categorias AS d ON d.Id = c.Categoria WHERE c.Nombre LIKE @Nombre;";

                       
                        comando.Parameters.AddWithValue("@Nombre", "%" + Nombre + "%");

                        DataTable tablaContactos = new DataTable();
                        adaptador = new OleDbDataAdapter(comando);
                        adaptador.Fill(tablaContactos);

                        buscar.DataSource = tablaContactos;

                        
                       
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }
        public void Buscar_num(DataGridView buscar, String Numero)
        {
            try
            {
                using (conexion = new OleDbConnection(cadena))
                {
                    conexion.Open();
                    using (comando = new OleDbCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandType = CommandType.Text;
                        comando.CommandText = "SELECT c.Nombre, c.Apellido, c.Numero, c.Mail, d.Categoria FROM Contacto AS c INNER JOIN Categorias AS d ON d.Id = c.Categoria WHERE c.Numero LIKE @Numero;";

                       
                        comando.Parameters.AddWithValue("@Numero", "%" + Numero + "%");

                        DataTable tablaContactos = new DataTable();
                        adaptador = new OleDbDataAdapter(comando);
                        adaptador.Fill(tablaContactos);

                        buscar.DataSource = tablaContactos;

                        
                       
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }
        public void Buscar_cat(DataGridView buscar, Int32 categoria)
        {
           
                try
                {
                    conexion = new OleDbConnection(cadena);
                    conexion.Open();
                    comando = new OleDbCommand();

                    comando.Connection = conexion;
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = $"SELECT  c.Nombre, c.Apellido , c.Numero, c.Mail, p.Categoria\r\nFROM Contacto AS c\r\nINNER JOIN Categorias AS p ON p.Id = c.Categoria Where c.Categoria ={categoria};";

                    DataTable tablainventario = new DataTable();
                    adaptador = new OleDbDataAdapter(comando);
                    adaptador.Fill(tablainventario);
                    buscar.DataSource = tablainventario;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conexion.Close();
                }
            
        }
        public void Exportar_txt(DataGridView dgv)
        {
            try
            {
                string nombreArchivo = "Exportar.txt";
                StringBuilder sb = new StringBuilder();


                foreach (DataGridViewColumn columna in dgv.Columns)
                {
                    sb.Append(columna.HeaderText + "\t");
                }
                sb.AppendLine();
                foreach (DataGridViewRow fila in dgv.Rows)
                {
                    foreach (DataGridViewCell celda in fila.Cells)
                    {
                        sb.Append(celda.Value?.ToString() + "\t\t");
                    }
                    sb.AppendLine();
                }

                File.WriteAllText(nombreArchivo, sb.ToString());

                MessageBox.Show("Datos guardados en Bin/Debug como:" + nombreArchivo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }
        }
        public void Exportar_csv(DataGridView tabla)
        {
            try
            {
                using (StreamWriter archivo = new StreamWriter("Exportar.csv", false, Encoding.UTF8))
                {
                    archivo.WriteLine("Productos\n");
                    archivo.WriteLine("Nombre;Apellido;Numero;Mail;Categoria");


                    foreach (DataGridViewRow fila in tabla.Rows)
                    {

                        if (!fila.IsNewRow)
                        {


                            string nombre = fila.Cells[0].Value?.ToString() ?? "";
                            string apellido = fila.Cells[1].Value?.ToString() ?? "";
                            string numero = fila.Cells[2].Value?.ToString() ?? "";
                            string mail = fila.Cells[3].Value?.ToString() ?? "";
                            string categoria = fila.Cells[4].Value?.ToString() ?? "";


                            archivo.WriteLine($"{nombre};{apellido};{numero};{mail};{categoria}");
                        }
                    }
                }

                MessageBox.Show("Reporte guardado como 'Reporte_Excel.csv'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el reporte: " + ex.Message);
            }
        }
    }
}
