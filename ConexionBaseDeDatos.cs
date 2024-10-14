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

        internal DataSet ObtenerDatos(bool entradaSiOrdenarPorNuevoPrimero)
        {
            DataSet datos = new DataSet();
            try
            {
                using (SqlConnection conexion = new SqlConnection(detallesConexion))
                {
                    if (entradaSiOrdenarPorNuevoPrimero)
                    {
                        string query = "SELECT ID, Titulo, Autor, CantidadDisponible FROM Libros ORDER BY ID Desc";
                        SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);
                        adaptador.Fill(datos, "Libros");
                    }
                    else
                    {

                        string query = "SELECT ID, Titulo, Autor, CantidadDisponible FROM Libros";
                        SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);
                        adaptador.Fill(datos, "Libros");
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al obtener libros: " + ex.Message);
            }
            return datos;
        }

        internal void InsertDatos(string tituloMetodo, string salario, int cantidadDisponibleMetodo)
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

        internal void UpdateDatos(int cantidadDisponibleMetodo, int idEntrada)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(detallesConexion))
                {
                    string query = "UPDATE Libros SET CantidadDisponible = @CantidadDisponible WHERE id = @id";
                    SqlCommand instruccion = new SqlCommand(query, conexion);
                    instruccion.Parameters.AddWithValue("@CantidadDisponible", cantidadDisponibleMetodo);
                    instruccion.Parameters.AddWithValue("@id", idEntrada);

                    conexion.Open();
                    instruccion.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al insertar libros: " + ex.Message);
            }

        }

        internal void DeleteDatos(string queryEntrada)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(detallesConexion))
                {
                    string query = queryEntrada;
                    SqlCommand instruccion = new SqlCommand(query, conexion);
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
