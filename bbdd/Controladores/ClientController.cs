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
    class ClientController
    {
        private readonly Conexion _conexion = new Conexion();

        public void InsertarCliente(ClientI cliente)
        {
            using (SqlConnection con = _conexion.AbrirConexion())
            {
                string query = "INSERT INTO Client (id,name, lastName, age) VALUES (@id, @name, @lastName, @age)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", cliente.Id);
                    cmd.Parameters.AddWithValue("@name", cliente.Name ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@lastName", cliente.LastName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@age", cliente.Age ?? (object)DBNull.Value);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<ClientI> ObtenerClientes()
        {
            var lista = new List<ClientI>();
            using (SqlConnection con = _conexion.AbrirConexion())
            {
                string query = "SELECT id, name, lastName, name + ' ' + lastName as Fullname, age FROM Client";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new ClientI
                    {
                        Id = Convert.ToInt64(reader["id"]),
                        Name = reader["name"]?.ToString(),
                        LastName = reader["lastName"]?.ToString(),
                        Age = reader["age"]?.ToString(),
                        Fullname = reader["Fullname"]?.ToString()
                    });
                }
            }
            return lista;
        }

        public void ActualizarCliente(ClientI cliente)
        {
            using (SqlConnection con = _conexion.AbrirConexion())
            {
                string query = @"UPDATE Client 
                             SET name = @name, 
                                 lastName = @lastName, 
                                 age = @age 
                             WHERE id = @id";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", cliente.Id);
                    cmd.Parameters.AddWithValue("@name", cliente.Name ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@lastName", cliente.LastName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@age", cliente.Age ?? (object)DBNull.Value);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No se encontró ningún cliente con el ID especificado.");
                    }
                }
            }
        }

        public void EliminarCliente(int id)
        {
            using (SqlConnection con = _conexion.AbrirConexion())
            {
                string query = "DELETE FROM Client WHERE id = @id";

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
