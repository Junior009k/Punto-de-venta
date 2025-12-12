using PV.bbdd.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TuProyectoWinForm.Clases;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PV.bbdd.Controladores
{
    class SalesDetailsController
    {
        private readonly Conexion _conexion = new Conexion();

        public void InsertarDetalleVenta(SalesDetailsI SalesDetails)
        {
            using (SqlConnection con = _conexion.AbrirConexion())
            {
                string query = "INSERT INTO SalesDetails (idProduct, idSales, amount,  total) VALUES (@idProduct, @idSales, @amount, @total)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@idProduct", SalesDetails.idProduct);
                    cmd.Parameters.AddWithValue("@idSales", SalesDetails.idSales);
                    cmd.Parameters.AddWithValue("@amount", SalesDetails.amount ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@total", SalesDetails.total ?? (object)DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<SalesDetailsI> ObtenerDetalleVentas(string id)
        {
            var lista = new List<SalesDetailsI>();
            if (id == "sin factura") id = "0";
            using (SqlConnection con = _conexion.AbrirConexion())
            {
                string query = "SELECT sd.id as id,s.id as idSales,p.id as idProdut, p.name as productName, p.price as productPrice,sd.amount as cant, sd.total as total FROM SalesDetails as sd Inner Join Sales s ON sd.idSales= s.id Inner Join Product p ON sd.idProduct= p.id where s.id=" + id ;
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new SalesDetailsI
                    {
                        id = Convert.ToInt64(reader["id"]),
                        idSales= Convert.ToInt64(reader["idSales"]),
                        idProduct = Convert.ToInt64(reader["idProdut"]),
                        nameProduct = reader["productName"]?.ToString(),
                        priceProduct = reader["productPrice"]?.ToString(),
                        amount = reader["cant"]?.ToString(),
                        total = reader["total"]?.ToString()
                    });
                }
            }
            return lista;
        }

        public List<SalesDetailsI> ObtenerDetalleVentasReport(DateTime dateDesde, DateTime dateHasta)
        {
            //DateTime fechaDesde = DateTime.ParseExact(dateDesde, "MM/dd/yyyy hh:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture);
            //DateTime fechaHasta = DateTime.ParseExact(dateHasta, "MM/dd/yyyy hh:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture);
            //dateDesde= fechaDesde.ToString("yyyy-MM-dd HH:mm:ss.fff");
            //dateHasta= fechaHasta.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine(dateDesde);
            Console.WriteLine(dateHasta.ToString());


            var lista = new List<SalesDetailsI>();
            using (SqlConnection con = _conexion.AbrirConexion())
            {
                string query = "SELECT sd.id as id,s.id as idSales,p.id as idProdut, p.name as productName, p.price as productPrice,sd.amount as cant, sd.total as total , s.[date] as fecha from  SalesDetails as sd Inner Join Sales s ON sd.idSales= s.id Inner Join Product p ON sd.idProduct= p.id where s.[date]> '"+dateDesde+"' and s.[date] < '"+ dateHasta + "'";
                Console.WriteLine(query);
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new SalesDetailsI
                    {
                        id = Convert.ToInt64(reader["id"]),
                        idSales = Convert.ToInt64(reader["idSales"]),
                        idProduct = Convert.ToInt64(reader["idProdut"]),
                        nameProduct = reader["productName"]?.ToString(),
                        priceProduct = reader["productPrice"]?.ToString(),
                        amount = reader["cant"]?.ToString(),
                        total = reader["total"]?.ToString()
                    });
                }
            }
            return lista;
        }

        public string ObtenerTotalVentas(string id)
        {
            var lista = new List<SalesDetailsI>();
            using (SqlConnection con = _conexion.AbrirConexion())
            {
                string query = "SELECT TOP (1)  sum([Total]) as total FROM [SalesDetails] where idSales=" + id;
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    return reader["total"].ToString();
                }

                return "";
            }
        }

        public void ActualizarDetalleVentas(SalesDetailsI SalesDetails)
        {
            using (SqlConnection con = _conexion.AbrirConexion())
            {
                string query = @"UPDATE SalesDetails 
                             SET idProduct = @idProduct,
                                     idSales = @idSales,
                                 amount=@amount,
                                 total = @total
                             WHERE id = @id";
       
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", SalesDetails.id);
                    cmd.Parameters.AddWithValue("@idProduct", SalesDetails.idProduct);
                    cmd.Parameters.AddWithValue("@idSales", SalesDetails.idSales);
                    cmd.Parameters.AddWithValue("@amount", SalesDetails.amount ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@total", SalesDetails.total ?? (object)DBNull.Value);
                    cmd.ExecuteNonQuery();

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No se encontró ningún cliente con el ID especificado.");
                    }
                }
            }
        }

        public void EliminarDetallesVentas(int id)
        {
            using (SqlConnection con = _conexion.AbrirConexion())
            {
                string query = "DELETE FROM SalesDetails WHERE id = @id";

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
