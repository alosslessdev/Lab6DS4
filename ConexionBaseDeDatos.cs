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
                    string query = "SELECT Nombre, Departamento, Salario FROM Empleados";
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

        public DataSet InsertDatos()
        {
            DataSet datos = new DataSet();
            try
            {
                using (SqlConnection conexion = new SqlConnection(detallesConexion))
                {
                    string query = "SELECT Nombre, Departamento, Salario FROM Empleados";
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

        public DataSet UpdateDatos()
        {
            DataSet datos = new DataSet();
            try
            {
                using (SqlConnection conexion = new SqlConnection(detallesConexion))
                {
                    string query = "SELECT Nombre, Departamento, Salario FROM Empleados";
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

        public DataSet DeleteDatos()
        {
            DataSet datos = new DataSet();
            try
            {
                using (SqlConnection conexion = new SqlConnection(detallesConexion))
                {
                    string query = "SELECT Nombre, Departamento, Salario FROM Empleados";
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

    }



}
