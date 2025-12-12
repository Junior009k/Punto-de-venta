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
    class ProveedorController
    {
        private readonly Conexion _conexion = new Conexion();

        public void InsertarProveedor(ProveedorI ProveedorI)
        {
            using (SqlConnection con = _conexion.AbrirConexion())
            {
                string query = "INSERT INTO Supplier(id,name, RNC) VALUES (@id, @name, @RNC)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", ProveedorI.id);
                    cmd.Parameters.AddWithValue("@name", ProveedorI.name ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@RNC", ProveedorI.RNC ?? (object)DBNull.Value);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<ProveedorI> ObtenerProveedor()
        {
            var lista = new List<ProveedorI>();
            using (SqlConnection con = _conexion.AbrirConexion())
            {
                string query = "SELECT id,name, RNC FROM Supplier";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new ProveedorI
                    {
                        id = Convert.ToInt64(reader["id"]),
                        name = reader["name"]?.ToString(),
                        RNC = reader["RNC"]?.ToString()
                    });
                }
            }
            return lista;
        }

        public void ActualizarProveedor(ProveedorI ProveedorI)
        {
            using (SqlConnection con = _conexion.AbrirConexion())
            {
                string query = @"UPDATE Supplier
                             SET name = @name, 
                                 RNC = @RNC 
                             WHERE id = @id";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", ProveedorI.id);
                    cmd.Parameters.AddWithValue("@name", ProveedorI.name ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@RNC", ProveedorI.RNC ?? (object)DBNull.Value);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No se encontró ningún inventario con el ID especificado.");
                    }
                }
            }
        }

        public void EliminarProveedor(int id)
        {
            using (SqlConnection con = _conexion.AbrirConexion())
            {
                string query = "DELETE FROM Supplier WHERE id = @id";

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
