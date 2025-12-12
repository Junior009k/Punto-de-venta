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
    class BoxController
    {
        private readonly Conexion _conexion = new Conexion();

        public void InsertarCaja(BoxI caja)
        {
            using (SqlConnection con = _conexion.AbrirConexion())
            {
                string query = "INSERT INTO Box (id,concept, date, amount) VALUES (@id, @concept, @date, @amount)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", caja.id);
                    cmd.Parameters.AddWithValue("@concept", caja.concept ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@date", DateTime.ParseExact(caja.date, "dddd, MMMM d, yyyy", null));
                    cmd.Parameters.AddWithValue("@amount", caja.amount);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<BoxI> ObtenerCaja()
        {
            var lista = new List<BoxI>();
            using (SqlConnection con = _conexion.AbrirConexion())
            {
                string query = "SELECT id,concept, date, amount FROM Box";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new BoxI
                    {
                        id = Convert.ToInt64(reader["id"]),
                        concept = reader["concept"]?.ToString(),
                        date = reader["date"]?.ToString(),
                        amount = reader["amount"].ToString()
                    });
                }
            }
            return lista;
        }

        public void ActualizarCaja(BoxI caja)
        {
            using (SqlConnection con = _conexion.AbrirConexion())
            {
                string query = @"UPDATE Box 
                             SET concept = @concept, 
                                 date = @date, 
                                 amount = @amount 
                             WHERE id = @id";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", caja.id);
                    cmd.Parameters.AddWithValue("@concept", caja.concept ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@date", DateTime.ParseExact(caja.date, "dddd, MMMM d, yyyy", null));
                    cmd.Parameters.AddWithValue("@amount", caja.amount);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No se encontró ningún cliente con el ID especificado.");
                    }
                }
            }
        }

        public void EliminarCaja(int id)
        {
            using (SqlConnection con = _conexion.AbrirConexion())
            {
                string query = "DELETE FROM Box WHERE id = @id";

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
