using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab_6
{
    public partial class fBiblioteca : Form
    {
        public fBiblioteca()
        {
            InitializeComponent();
        }

        private void btMostrarLibro_Click(object sender, EventArgs e)
        {
            string connectionString = "your_connection_string_here";  // Actualiza con tu cadena de conexión
            string query = "SELECT * FROM Libros";  // Consulta para obtener todos los libros

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();

                try
                {
                    connection.Open();
                    dataAdapter.Fill(dataSet, "Libros");
                    dgvLibro.DataSource = dataSet.Tables["Libros"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al mostrar libros: " + ex.Message);
                }
            }
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
            if (dgvLibro.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione un solo libro para actualizar.");
                return;
            }

            DataGridViewRow row = dgvLibro.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells["id"].Value);
            string titulo = row.Cells["Titulo"].Value.ToString();
            int cantidadDisponible = Convert.ToInt32(row.Cells["CantidadDisponible"].Value);

            // Mostrar un cuadro de diálogo para actualizar la cantidad
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                $"Actualizar cantidad disponible para '{titulo}':",
                "Actualizar cantidad",
                cantidadDisponible.ToString());

            if (int.TryParse(input, out int nuevaCantidad))
            {
                string connectionString = "your_connection_string_here";
                string query = "UPDATE Libros SET CantidadDisponible = @Cantidad WHERE id = @id";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Cantidad", nuevaCantidad);
                    command.Parameters.AddWithValue("@id", id);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Cantidad actualizada correctamente.");

                        // Refrescar el DataGridView
                        btMostrarLibro_Click(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar libro: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número válido.");
            }
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
            }
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