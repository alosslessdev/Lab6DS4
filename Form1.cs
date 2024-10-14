using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab_6
{
    public partial class FBiblioteca : Form
    {
        public FBiblioteca()
        {
            InitializeComponent();
        }


        private void btMostrarLibro_Click(object sender, EventArgs e)
        {
            ConexionBaseDeDatos conexionBaseDeDatos = new ConexionBaseDeDatos();
            DataSet datos = conexionBaseDeDatos.ObtenerDatos(false);
            dgvLibro.DataSource = datos.Tables["Libros"];

        }

        private void btEliminarLibro_Click(object sender, EventArgs e)
        {
            if (dgvLibro.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione los libros que desea eliminar.");
                return;
            }

            DialogResult confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar los libros seleccionados?",
                                                        "Confirmar eliminación",
                                                        MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.No)
            {
                return;
            }

            string connectionString = "your_connection_string_here";
            List<int> idsEliminar = new List<int>();

            foreach (DataGridViewRow row in dgvLibro.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells["id"].Value);
                idsEliminar.Add(id);
            }

            string ids = string.Join(",", idsEliminar);
            string query = $"DELETE FROM Libros WHERE id IN ({ids})";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    int filasEliminadas = command.ExecuteNonQuery();
                    MessageBox.Show($"{filasEliminadas} libros eliminados.");

                    // Refrescar el DataGridView
                    btMostrarLibro_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar libros: " + ex.Message);
                }
            }
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            
        }

        private void btAgregarLibro_Click(object sender, EventArgs e)
        {
            // Mensaje para solicitar datos del nuevo libro
            string titulo = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el título del libro:", "Agregar libro");
            if (string.IsNullOrEmpty(titulo))
            {
                MessageBox.Show("Debe ingresar un título.");
                return;
            }

            string autor = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el autor del libro:", "Agregar libro");
            if (string.IsNullOrEmpty(autor))
            {
                MessageBox.Show("Debe ingresar un autor.");
                return;
            }

            string cantidadStr = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad disponible:", "Agregar libro");
            if (!int.TryParse(cantidadStr, out int cantidadDisponible))
            {
                MessageBox.Show("Debe ingresar una cantidad válida.");
                return;
            }

             string connectionString = "your_connection_string_here";
             string query = "INSERT INTO Libros (Titulo, Autor, CantidadDisponible) VALUES (@Titulo, @Autor, @Cantidad)";

             using (SqlConnection connection = new SqlConnection(connectionString))
             {
                 SqlCommand command = new SqlCommand(query, connection);
                 command.Parameters.AddWithValue("@Titulo", titulo);
                 command.Parameters.AddWithValue("@Autor", autor);
                 command.Parameters.AddWithValue("@Cantidad", cantidadDisponible);

                 try
                 {
                     connection.Open();
                     command.ExecuteNonQuery();
                     MessageBox.Show("Libro agregado correctamente.");

                     // Refrescar el DataGridView
                     btMostrarLibro_Click(sender, e);
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("Error al agregar libro: " + ex.Message);
                 }
             }*/
            

            FormAniadirLibro formAniadirLibro = new FormAniadirLibro(this);
            formAniadirLibro.Show();


        }

        private void fBiblioteca_Load(object sender, EventArgs e)
        {
            // Aquí podrías cargar la lista de libros al iniciar la aplicación
        }

        private void dgvLibro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evento del DataGridView, si necesitas alguna funcionalidad aquí
        }
    }
}