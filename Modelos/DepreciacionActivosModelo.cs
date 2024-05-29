using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

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

        public static DataTable BuscarActivoParaDepreciar(string IdActivo)
        {
            DataTable dtActivoDepreciar = new DataTable();
            string query = "EXEC STP_BuscarActivoParaDepreciacion @IdActivo";
            SqlCommand sqlActivo = new SqlCommand(query, DBConexion.ConectarSQL());
            sqlActivo.Parameters.AddWithValue("@IdActivo", IdActivo);
            try
            {
                SqlDataAdapter listaActivos = new SqlDataAdapter(sqlActivo);
                listaActivos.Fill(dtActivoDepreciar);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Models", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return dtActivoDepreciar;
        }

        public static int UltimoIdDepreciacion()
        {
            int ultimoId = -1; // valor por default en caso de error
            string query = "SELECT dbo.FN_ObtenerUltimoIDDepreciaciones()";
            SqlCommand select = new SqlCommand(query, DBConexion.ConectarSQL());
            try
            {
                object resultado = select.ExecuteScalar();

                if (resultado != null && resultado != DBNull.Value)
                {
                    ultimoId = Convert.ToInt32(resultado) + 1;
                }
                else
                {
                    ultimoId = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Models: " + ex.Message);
            }

            return ultimoId;
        }

        public static DataTable BuscarDepreciacionPorID(string id)
        {
            DataTable dtIdDepreciacion = new DataTable();

            string query = "SELECT da.fecha_registro_da, da.id_depreciacion_activo, da.id_activo_da, da.usuario_registro_da FROM tb_depreciacion_activos da WHERE da.id_depreciacion_activo = @id";

            SqlCommand select = new SqlCommand(query, DBConexion.ConectarSQL());
            select.Parameters.AddWithValue("@id", id);

            try
            {
                SqlDataAdapter depreciacion = new SqlDataAdapter(select);

                // llenamos el DataTable con la información recuperada de la consulta SQL
                depreciacion.Fill(dtIdDepreciacion);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return dtIdDepreciacion;
        }

        public static void InsertarDepreciacion(string idDepreciacion,string IdActivo, string IdClasificacion, DateTime fechaRegistro,int anioVidaUtil, decimal porcentaje, decimal valorActivo, decimal valorResidual, string IdUbicacion, int anioCompra, int ultimoAnio, string usuarioRegistro, int estado)
        {
            string insert = "INSERT INTO tb_depreciacion_activos (id_depreciacion_activo, id_activo_da, id_clasificacion_da, fecha_registro_da, anios_vida_util_da, porcentaje_anual_da, valor_activo_da, valor_residual_da,id_ubicacion_da, anio_compra_da, ultimo_anio_da, usuario_registro_da, estado_da)        VALUES (@idDepreciacion, @IdActivo, @IdClasificacion, @fechaRegistro, @anioVidaUtil, @porcentaje, @valorActivo, @valorResidual, @IdUbicacion, @anioCompra, @ultimoAnio, @usuarioRegistro, @estado)";

            SqlCommand sqlInsert = new SqlCommand(insert, DBConexion.ConectarSQL());

            sqlInsert.Parameters.AddWithValue("@idDepreciacion", idDepreciacion);
            sqlInsert.Parameters.AddWithValue("@IdActivo", IdActivo);
            sqlInsert.Parameters.AddWithValue("@IdClasificacion", IdClasificacion);
            sqlInsert.Parameters.AddWithValue("@fechaRegistro", fechaRegistro);
            sqlInsert.Parameters.AddWithValue("@anioVidaUtil", anioVidaUtil);
            sqlInsert.Parameters.AddWithValue("@porcentaje", porcentaje);
            sqlInsert.Parameters.AddWithValue("@valorActivo", valorActivo);
            sqlInsert.Parameters.AddWithValue("@valorResidual", valorResidual);
            sqlInsert.Parameters.AddWithValue("@IdUbicacion", IdUbicacion);
            sqlInsert.Parameters.AddWithValue("@anioCompra", anioCompra);
            sqlInsert.Parameters.AddWithValue("@ultimoAnio", ultimoAnio);
            sqlInsert.Parameters.AddWithValue("@usuarioRegistro", usuarioRegistro);
            sqlInsert.Parameters.AddWithValue("@estado", estado);

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

        public static void ActualizarDepreciacion(string idDepreciacion, string IdActivo, string IdClasificacion, DateTime fechaRegistro, int anioVidaUtil, decimal porcentaje, decimal valorActivo, decimal valorResidual, string IdUbicacion, int anioCompra, int ultimoAnio, string usuarioRegistro, int estado)
        {
            string insert = "UPDATE tb_depreciacion_activos SET id_activo_da = @IdActivo, id_clasificacion_da = @IdClasificacion, fecha_registro_da = @fechaRegistro, anios_vida_util_da = @anioVidaUtil, porcentaje_anual_da = @porcentaje, valor_activo_da = @valorActivo, valor_residual_da = @valorResidual, id_ubicacion_da = @IdUbicacion, anio_compra_da = @anioCompra, ultimo_anio_da = @ultimoAnio, usuario_registro_da = @usuarioRegistro, estado_da = @estado WHERE id_depreciacion_activo = @idDepreciacion";

            SqlCommand sqlUpdate = new SqlCommand(insert, DBConexion.ConectarSQL());

            sqlUpdate.Parameters.AddWithValue("@idDepreciacion", idDepreciacion);
            sqlUpdate.Parameters.AddWithValue("@IdActivo", IdActivo);
            sqlUpdate.Parameters.AddWithValue("@IdClasificacion", IdClasificacion);
            sqlUpdate.Parameters.AddWithValue("@fechaRegistro", fechaRegistro);
            sqlUpdate.Parameters.AddWithValue("@anioVidaUtil", anioVidaUtil);
            sqlUpdate.Parameters.AddWithValue("@porcentaje", porcentaje);
            sqlUpdate.Parameters.AddWithValue("@valorActivo", valorActivo);
            sqlUpdate.Parameters.AddWithValue("@valorResidual", valorResidual);
            sqlUpdate.Parameters.AddWithValue("@IdUbicacion", IdUbicacion);
            sqlUpdate.Parameters.AddWithValue("@anioCompra", anioCompra);
            sqlUpdate.Parameters.AddWithValue("@ultimoAnio", ultimoAnio);
            sqlUpdate.Parameters.AddWithValue("@usuarioRegistro", usuarioRegistro);
            sqlUpdate.Parameters.AddWithValue("@estado", estado);

            // Ejecutamos la consulta y obtenemos el número de filas afectadas
            int filasAfectadas = sqlUpdate.ExecuteNonQuery();

            // Verificar si se realizaron actualizaciones
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Registro actualizado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se encontró ninguna fila para actualizar.");
            }
        }

        public static void EliminarDepreciacion(string id)
        {
            string query = "DELETE FROM tb_depreciacion_activos WHERE id_depreciacion_activo = @id";
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

    }
}
