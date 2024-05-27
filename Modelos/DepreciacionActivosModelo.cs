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

        public static DataTable ListadoActivos()
        {
            DataTable dtListadoActivos = new DataTable();
            string query = "SELECT id_activo AS 'ID Activo', codigo_interno_ac AS 'Codigo Interno', nombre_activo AS 'Nombre del activo' FROM tb_activos";
            SqlCommand sqlLista = new SqlCommand(query, DBConexion.ConectarSQL());
            try
            {
                SqlDataAdapter listaActivos = new SqlDataAdapter(sqlLista);
                listaActivos.Fill(dtListadoActivos);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Models", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return dtListadoActivos;
        }
    }
}
