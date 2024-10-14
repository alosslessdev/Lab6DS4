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
            ConexionBaseDeDatos conexionBaseDeDatos = new ConexionBaseDeDatos();
            DataSet datos = conexionBaseDeDatos.ObtenerDatos(false);
            dgvLibro.DataSource = datos.Tables["Libros"];
        }

        private void btEliminarLibro_Click(object sender, EventArgs e)
        {
            if (dgvLibro.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione los libros que desea eliminar. Para seleccionar un libro, vaya a la fila que tiene el libro que quiera eliminar, " +
                    "mire a la celda vacia a la izquierda de la fila, y haga click en esa celda vacia.");
                return;
            }

            DialogResult confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar los libros seleccionados?",
                                                        "Confirmar eliminación",
                                                        MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.No)
            {
                return;
            }

            List<int> idsEliminar = new List<int>();

            foreach (DataGridViewRow row in dgvLibro.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells["id"].Value);
                idsEliminar.Add(id);
            }

            string ids = string.Join(",", idsEliminar);
            string query = $"DELETE FROM Libros WHERE id IN ({ids})";

            ConexionBaseDeDatos conexionBaseDeDatos = new ConexionBaseDeDatos();
            conexionBaseDeDatos.DeleteDatos(query);

            DataSet datos = conexionBaseDeDatos.ObtenerDatos(false);
            dgvLibro.DataSource = datos.Tables["Libros"];


        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            if (dgvLibro.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione un solo libro para actualizar. Para seleccionar un libro, vaya a la fila que tiene el libro que quiera actualizar, " +
                                "mire a la celda vacia a la izquierda de la fila, y haga click en esa celda vacia.");
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

                ConexionBaseDeDatos conexionBaseDeDatos = new ConexionBaseDeDatos();
                conexionBaseDeDatos.UpdateDatos(nuevaCantidad, id);

                DataSet datos = conexionBaseDeDatos.ObtenerDatos(false);
                dgvLibro.DataSource = datos.Tables["Libros"];

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


            ConexionBaseDeDatos conexionBaseDeDatos = new ConexionBaseDeDatos();
            conexionBaseDeDatos.InsertDatos(titulo, autor, cantidadDisponible);

            DataSet datos = conexionBaseDeDatos.ObtenerDatos(false);
            dgvLibro.DataSource = datos.Tables["Libros"];

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