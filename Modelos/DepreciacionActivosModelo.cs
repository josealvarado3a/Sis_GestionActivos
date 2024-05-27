using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sis_GestionActivos.Modelos
{
    public class DepreciacionActivosModelo
    {
        public static DataTable ViewDepreciacionActivos()
        {
            DataTable dtViewDepreciacionActivos = new DataTable();
            string query = "SELECT * FROM V_Depreciacion_Activos";
            SqlCommand sqlViewDA = new SqlCommand(query, DBConexion.ConectarSQL());
            try
            {
                SqlDataAdapter ViewDA = new SqlDataAdapter(sqlViewDA);
                ViewDA.Fill(dtViewDepreciacionActivos);

            }catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,"Error Models",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return dtViewDepreciacionActivos;
        }
    }
}
