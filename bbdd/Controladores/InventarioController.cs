using PV.bbdd.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuProyectoWinForm.Clases;

namespace PV.bbdd.Controladores
{
    class InventarioController
    {
        private readonly Conexion _conexion = new Conexion();

        public void InsertarInventario(InventarioI InventarioI)
        {
            using (SqlConnection con = _conexion.AbrirConexion())
            {
                string query = "INSERT INTO Product(id,name, amount, price) VALUES (@id, @name, @amount, @price)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    try
                    { 
                        cmd.Parameters.AddWithValue("@id", InventarioI.id);
                        cmd.Parameters.AddWithValue("@name", InventarioI.name ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@amount", InventarioI.amount ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@price", InventarioI.price ?? (object)DBNull.Value);
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Código que se ejecuta si ocurre una excepción
                        Console.WriteLine("Ocurrió un error: " + ex.Message);
                    }
                }
            }
        }

        public List<InventarioI> ObtenerInventario()
        {
            var lista = new List<InventarioI>();
            using (SqlConnection con = _conexion.AbrirConexion())
            {
                string query = "SELECT id,name, amount, price FROM Product";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new InventarioI
                    {
                        id = Convert.ToInt64(reader["id"]),
                        name = reader["name"]?.ToString(),
                        amount = reader["amount"]?.ToString(),
                        price = reader["price"]?.ToString()
                    });
                }
            }
            return lista;
        }

        public void ActualizarInventario(InventarioI InventarioI)
        {
            using (SqlConnection con = _conexion.AbrirConexion())
            {
                string query = @"UPDATE Product
                             SET name = @name, 
                                 amount = @amount,
                                 price = @price
                             WHERE id = @id";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", InventarioI.id);
                    cmd.Parameters.AddWithValue("@name", InventarioI.name ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@amount", InventarioI.amount ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@price", InventarioI.price ?? (object)DBNull.Value);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No se encontró ningún inventario con el ID especificado.");
                    }
                }
            }
        }

        public void EliminarInventario(int id)
        {
            using (SqlConnection con = _conexion.AbrirConexion())
            {
                string query = "DELETE FROM Product WHERE id = @id";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No se encontró ningún Inventario con el ID especificado para eliminar.");
                    }
                }
            }
        }
    }
}
