using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sis_GestionActivos.Modelos
{
    internal class ActivosModelo
    {
        public static DataTable ObtenerActivos()
        {
            DataTable dtActivos = new DataTable();
            string query = @"SELECT A.id_activo, 
                                    C.nombre_clasificacion_ca AS clasificacion,
                                    CA.nombre_categoria AS categoria,
                                    A.fecha_registro_ac AS fecha_registro,
                                    A.nombre_activo,
                                    A.fecha_compra_ac AS fecha_compra,
                                    O.nombre_operario AS encargado
                             FROM tb_activos A
                             INNER JOIN tb_clasificacion_activos C ON A.id_clasificacion_ac = C.id_clasificacion_ca
                             INNER JOIN tb_categorias_activos CA ON A.id_categoria_ac = CA.id_categoria_ct
                             LEFT JOIN tb_operarios O ON A.id_operario_ac = O.id_operario";

            using (SqlConnection conexion = DBConexion.ConectarSQL())
            using (SqlCommand comando = new SqlCommand(query, conexion))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    adapter.Fill(dtActivos);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Models", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            return dtActivos;
        }
    }
}

