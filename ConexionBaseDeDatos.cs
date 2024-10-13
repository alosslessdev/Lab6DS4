using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    internal class ConexionBaseDeDatos
    {

        private string detallesConexion = "Data Source=localhost;Initial Catalog=Libreria;Integrated Security=True";

        public DataSet ObtenerDatos()
        {
            DataSet datos = new DataSet();
            try
            {
                using (SqlConnection conexion = new SqlConnection(detallesConexion))
                {
                    string query = "SELECT Titulo, Autor, CantidadDisponible FROM Libros";
                    SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);
                    adaptador.Fill(datos, "Libros");
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al obtener libros: " + ex.Message);
            }
            return datos;
        }

        public void InsertDatos(string tituloMetodo, string salario, int cantidadDisponibleMetodo)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(detallesConexion))
                {
                    string query = "INSERT INTO Libros(Titulo, Autor, CantidadDisponible) VALUES (@Titulo, @Autor, @CantidadDisponible)";
                    SqlCommand instruccion = new SqlCommand(query, conexion);
                    instruccion.Parameters.AddWithValue("@Titulo", tituloMetodo);
                    instruccion.Parameters.AddWithValue("@Autor", salario);
                    instruccion.Parameters.AddWithValue("@CantidadDisponible", cantidadDisponibleMetodo);
                    conexion.Open();
                    instruccion.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al insertar libros: " + ex.Message);
            }

        }

        public void UpdateDatos(int cantidadDisponibleMetodo)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(detallesConexion))
                {
                    string query = "UPDATE Libros SET CantidadDisponible = @CantidadDisponible";
                    SqlCommand instruccion = new SqlCommand(query, conexion);
                    instruccion.Parameters.AddWithValue("@CantidadDisponible", cantidadDisponibleMetodo);
                    conexion.Open();
                    instruccion.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al insertar libros: " + ex.Message);
            }

        }

        public void DeleteDatos(string tituloMetodo, string salario, int cantidadDisponibleMetodo)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(detallesConexion))
                {
                    string query = "DELETE FROM Libros WHERE Titulo = @Titulo";
                    SqlCommand instruccion = new SqlCommand(query, conexion);
                    instruccion.Parameters.AddWithValue("@Titulo", tituloMetodo);
                    conexion.Open();
                    instruccion.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al insertar libros: " + ex.Message);
            }

        }

    }



}
