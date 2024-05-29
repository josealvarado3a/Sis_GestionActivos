using Sis_GestionActivos.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace Sis_GestionActivos.Controladores
{
    internal class OperariosControlador
    {
        public static DataTable ObtenerOperarios()
        {
            return OperariosModelo.ObtenerOperarios();
        }

        public static int EliminarOperario(string idOperario)
        {
            return OperariosModelo.EliminarOperario(idOperario);
        }

        public static bool ExisteOperario(string idOperario)
        {
            bool existe = false;

            // Query SQL para verificar si existe un operario con el id_operario especificado
            string query = "SELECT COUNT(*) FROM tb_operarios WHERE id_operario = @IdOperario";

            using (SqlConnection conexion = DBConexion.ConectarSQL())
            using (SqlCommand comando = new SqlCommand(query, conexion))
            {
                comando.Parameters.AddWithValue("@IdOperario", idOperario);

                try
                {
                    int count = (int)comando.ExecuteScalar();
                    existe = (count > 0);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al verificar la existencia del operario: " + ex.Message);
                }
            }

            return existe;
        }

    }
}
