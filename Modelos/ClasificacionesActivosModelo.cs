using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace Sis_GestionActivos.Modelos
{
    public class ClasificacionesActivosModelo
    {
        public static DataTable ViewClasificacionesActivos()
        {
            DataTable dtViewClasificacionesActivos = new DataTable();
            string query = "SELECT * FROM V_Clasificaciones_Activos";
            SqlCommand sqlViewCL = new SqlCommand(query, DBConexion.ConectarSQL());
            try
            {
                SqlDataAdapter ViewLC = new SqlDataAdapter(sqlViewCL);
                ViewLC.Fill(dtViewClasificacionesActivos);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Models", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return dtViewClasificacionesActivos;
        }

        public static int contarActivosPorClasificacion(string id_clasificacion)
        {
            string query = "SELECT dbo.ContarActivosPorClasificacion(@idClasificacion)";
            SqlCommand sqlContador = new SqlCommand(query, DBConexion.ConectarSQL());

            sqlContador.Parameters.AddWithValue("@idClasificacion", id_clasificacion);

            int resultado = 0;
            try
            {
                object result = sqlContador.ExecuteScalar();

                if (result != null)
                {
                    resultado = (int)result;
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Error models: " + ex.Message);
            }

            return resultado;
        }
    }
}
