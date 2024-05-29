using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sis_GestionActivos.Modelos
{
    internal class OperariosModelo
    {
        public static DataTable ObtenerOperarios()
        {
            DataTable dtOperarios = new DataTable();
            string query = "SELECT * FROM tb_operarios";
            using (SqlConnection conexion = DBConexion.ConectarSQL())
            using (SqlCommand comando = new SqlCommand(query, conexion))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    adapter.Fill(dtOperarios);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Models", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            return dtOperarios;
        }

        public static int EliminarOperario(string idOperario)
        {
            int filasAfectadas = 0;
            string deleteQuery = "DELETE FROM tb_operarios WHERE id_operario = @ID";

            try
            {
                using (SqlConnection conexion = DBConexion.ConectarSQL())
                using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, conexion))
                {
                    deleteCommand.Parameters.AddWithValue("@ID", idOperario);
                    filasAfectadas = deleteCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el operario: " + ex.Message);
            }

            return filasAfectadas;
        }

        public static bool ExistenRegistrosRelacionados(string idOperario)
        {
            string query = "SELECT COUNT(*) FROM tb_activos WHERE id_operario_ac = @ID";
            int count;

            using (SqlConnection conexion = DBConexion.ConectarSQL())
            using (SqlCommand comando = new SqlCommand(query, conexion))
            {
                comando.Parameters.AddWithValue("@ID", idOperario);

                try
                {
                    count = (int)comando.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al verificar registros relacionados: " + ex.Message);
                }
            }

            return count > 0;
        }
    }
}
