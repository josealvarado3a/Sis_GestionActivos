using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sis_GestionActivos.Modelos
{
    public class ActivosModelo
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

        public static DataTable ObtenerClasificaciones()
        {
            DataTable dtClasficaciones = new DataTable();
            string query = "SELECT id_clasificacion_ca, nombre_clasificacion_ca FROM tb_clasificacion_activos";
            SqlCommand sqlLista = new SqlCommand(query, DBConexion.ConectarSQL());
            try
            {
                SqlDataAdapter listaActivos = new SqlDataAdapter(sqlLista);
                listaActivos.Fill(dtClasficaciones);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Models", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return dtClasficaciones;
        }

        public static DataTable ObtenerCategorias(string idClAsocc)
        {
            DataTable dt = new DataTable();
            string query = "select ct.id_categoria_ct, ct.nombre_categoria from tb_categorias_activos ct Inner join tb_clasificacion_activos cl ON ct.id_clasificacion_ct = cl.id_clasificacion_ca where cl.id_clasificacion_ca = @idClAsocc";

            SqlCommand sqlLista = new SqlCommand(query, DBConexion.ConectarSQL());
            sqlLista.Parameters.AddWithValue("@idClAsocc", idClAsocc);

            try
            {
                SqlDataAdapter lista = new SqlDataAdapter(sqlLista);
                lista.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Models", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return dt;
        }

        public static DataTable ObtenerOperarios()
        {
            DataTable dt = new DataTable();
            string query = "select id_operario, nombre_operario from tb_operarios";

            SqlCommand sqlLista = new SqlCommand(query, DBConexion.ConectarSQL());
            

            try
            {
                SqlDataAdapter lista = new SqlDataAdapter(sqlLista);
                lista.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Models", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return dt;
        }

        public static DataTable ObtenerUbicaciones()
        {
            DataTable dt = new DataTable();
            string query = "select id_ubicacion, nombre_ubicacion from tb_ubicaciones";

            SqlCommand sqlLista = new SqlCommand(query, DBConexion.ConectarSQL());


            try
            {
                SqlDataAdapter lista = new SqlDataAdapter(sqlLista);
                lista.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Models", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return dt;
        }

        public static void EliminarActivo(string id)
        {
            string query = "DELETE FROM tb_activos WHERE id_activo = @id";
            SqlCommand sqlDelete = new SqlCommand(query, DBConexion.ConectarSQL());

            sqlDelete.Parameters.AddWithValue("@id", id);

            // Ejecutamos la consulta y obtenemos el número de filas afectadas
            int registroEliminado = sqlDelete.ExecuteNonQuery();

            // Verificar si se elimino
            if (registroEliminado > 0)
            {
                MessageBox.Show("El registro ha sido eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("No se encontró ninguna fila para eliminar.");
            }
        }

        public static void InsertarActivo(string idActivo, DateTime fechaRegistro,string codigoInterno, string nombreActivo, string idClasificacion, string idCategoria, string usuarioRegistro, DateTime fechaAlta, decimal valorActivo, string idOperario, string idUbicacion, string descrip)
        {
            string insert = "INSERT INTO tb_activos (id_activo, id_clasificacion_ac, id_categoria_ac, codigo_interno_ac, fecha_registro_ac, nombre_activo, fecha_compra_ac, valor_activo, fecha_alta_ac, id_operario_ac, usuario_registro_ac, id_ubicacion_ac, observaciones_ac) VALUES (@idActivo, @idClasificacion, @idCategoria, @codigoInterno, @fechaRegistro, @nombreActivo, @fechaAlta, @valorActivo, @fechaAlta, @idOperario, @usuarioRegistro, @idUbicacion, @descrip);";

            SqlCommand sqlInsert = new SqlCommand(insert, DBConexion.ConectarSQL());

            sqlInsert.Parameters.AddWithValue("@idActivo", idActivo);
            sqlInsert.Parameters.AddWithValue("@idClasificacion", idClasificacion);
            sqlInsert.Parameters.AddWithValue("@idCategoria", idCategoria);
            sqlInsert.Parameters.AddWithValue("@codigoInterno", codigoInterno);
            sqlInsert.Parameters.AddWithValue("@nombreActivo", nombreActivo);
            sqlInsert.Parameters.AddWithValue("@fechaAlta", fechaAlta);
            sqlInsert.Parameters.AddWithValue("@valorActivo", valorActivo);
            sqlInsert.Parameters.AddWithValue("@usuarioRegistro", usuarioRegistro);
            sqlInsert.Parameters.AddWithValue("@idOperario", idOperario);
            sqlInsert.Parameters.AddWithValue("@idUbicacion", idUbicacion);
            sqlInsert.Parameters.AddWithValue("@fechaRegistro", fechaRegistro);
            sqlInsert.Parameters.AddWithValue("@descrip", descrip);

            try
            {
                // Ejecutamos la consulta y obtenemos el número de filas afectadas
                int resultado = sqlInsert.ExecuteNonQuery();

                // Validamos si existen filas afectadas
                if (resultado > 0)
                {
                    MessageBox.Show("Datos ingresados correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se ingresaron los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Models: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

