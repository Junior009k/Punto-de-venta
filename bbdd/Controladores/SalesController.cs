using PV.bbdd.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TuProyectoWinForm.Clases;

namespace PV.bbdd.Controladores
{
    class SalesController
    {
        private readonly Conexion _conexion = new Conexion();

        public void InsertarVenta(SalesI sales)
        {
            using (SqlConnection con = _conexion.AbrirConexion())
            {
                string query = "INSERT INTO Sales (idClient, total, date) VALUES (@idClient, @total, @date)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@idClient", sales.idClient );
                    cmd.Parameters.AddWithValue("@total", sales.total ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@date", sales.date);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<SalesI> ObtenerVentas()
        {
            var lista = new List<SalesI>();
            using (SqlConnection con = _conexion.AbrirConexion())
            {
                string query = "SELECT s.id, idClient, c.name + ' ' + c.lastName as FullName, s.Total, s.date FROM Sales as s Inner Join Client c ON c.id= s.idClient";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new SalesI
                    {
                        id = Convert.ToInt64(reader["s.id"]),
                        idClient = Convert.ToInt64(reader["s.idClient"]),
                        fullName = reader["FullName"]?.ToString(),
                        total = reader["s.Total"]?.ToString(),
                        date = (DateTime)reader["s.date"]
                    });
                }
            }
            return lista;
        }

        public int ObtenerIdVentas()
        {
            var lista = new List<SalesI>();
            using (SqlConnection con = _conexion.AbrirConexion())
            {
                string query = "SELECT TOP (1) [id] FROM [Sales] ORDER BY id desc";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                   return  Convert.ToInt32(reader["id"]);
                }

                return 0;
            }
        }

        public List<SalesI> ObtenerVentasReport(DateTime dateDesde, DateTime dateHasta)
        {
            //DateTime fechaDesde = DateTime.ParseExact(dateDesde, "MM/dd/yyyy hh:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture);
            //DateTime fechaHasta = DateTime.ParseExact(dateHasta, "MM/dd/yyyy hh:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture);
            //dateDesde= fechaDesde.ToString("yyyy-MM-dd HH:mm:ss.fff");
            //dateHasta= fechaHasta.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine(dateDesde);
            Console.WriteLine(dateHasta.ToString());


            var lista = new List<SalesI>();
            using (SqlConnection con = _conexion.AbrirConexion())
            {
                string query = "SELECT s.id as id,s.idClient as idClient, c.[name] + ' ' + c.lastName as Fullname, c.age as edad,s.total as total , s.[date] as fecha from  Sales as s Inner Join Client c ON s.idClient= c.id where s.[date]> '"+dateDesde+"' and s.[date] < '"+ dateHasta + "'";
                Console.WriteLine(query);
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new SalesI
                    {
                        id = Convert.ToInt64(reader["id"]),
                        idClient = Convert.ToInt64(reader["idClient"]),
                        fullName = reader["Fullname"]?.ToString(),
                        ageClient = reader["edad"]?.ToString(),
                        total = reader["total"]?.ToString(),
                        dateS = reader["fecha"]?.ToString()
                    });
                }
            }
            return lista;
        }

        public void ActualizarVentas(SalesI sales)
        {
            using (SqlConnection con = _conexion.AbrirConexion())
            {
                string query = @"UPDATE Sales 
                             SET idClient = @idClient, 
                                 total = @total
                             WHERE id = @id";
                
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                cmd.Parameters.AddWithValue("@id", sales.id);
                cmd.Parameters.AddWithValue("@idClient", sales.idClient);
                cmd.Parameters.AddWithValue("@total", long.Parse(sales.total) );
                cmd.ExecuteNonQuery();

                int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No se encontró ningún cliente con el ID especificado.");
                    }
                }
            }
        }

        public void EliminarVentas(int id)
        {
            using (SqlConnection con = _conexion.AbrirConexion())
            {
                string query = "DELETE FROM Sales WHERE id = @id";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No se encontró ningún cliente con el ID especificado para eliminar.");
                    }
                }
            }
        }
    }
}
