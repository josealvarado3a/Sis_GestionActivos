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
    public class UsuarioModelo
    {
        public static DataTable ViewUsuarios()
        {
            DataTable dtViewUsuarios = new DataTable();
            string query = "SELECT * FROM V_Usuarios";
            SqlCommand sqlView = new SqlCommand(query, DBConexion.ConectarSQL());
            try
            {
                SqlDataAdapter ViewDA = new SqlDataAdapter(sqlView);
                ViewDA.Fill(dtViewUsuarios);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Models", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return dtViewUsuarios;
        }

        public static DataTable RolesUsuario()
        {
            DataTable dtRoles = new DataTable();
            string query = "select id_rol, nombre_rol from tb_roles";
            SqlCommand sqlLista = new SqlCommand(query, DBConexion.ConectarSQL());
            try
            {
                SqlDataAdapter roles = new SqlDataAdapter(sqlLista);
                roles.Fill(dtRoles);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Models", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return dtRoles;
        }

        public static void InsertarUsuario(string idUsuario, DateTime fechaRegistro, string nombres, string apellidos, string usuarioLogin, string contrasenia, string email, int idRol, int estado)
        {
            string insert = "INSERT INTO tb_usuarios (id_usuario, fecha_registro_us, nombre_usuario, apellidos_usuario, usuario_login, contrasenia_usuario, email_usuario, rol_usuario, estado_usuario) VALUES (@idUsuario, @fechaRegistro, @nombres, @apellidos, @usuarioLogin, @contrasenia, @email, @idRol, @estado);";

            SqlCommand sqlInsert = new SqlCommand(insert, DBConexion.ConectarSQL());

            sqlInsert.Parameters.AddWithValue("@idUsuario", idUsuario);
            sqlInsert.Parameters.AddWithValue("@fechaRegistro", fechaRegistro);
            sqlInsert.Parameters.AddWithValue("@nombres", nombres);
            sqlInsert.Parameters.AddWithValue("@apellidos", apellidos);
            sqlInsert.Parameters.AddWithValue("@usuarioLogin", usuarioLogin);
            sqlInsert.Parameters.AddWithValue("@contrasenia", contrasenia);
            sqlInsert.Parameters.AddWithValue("@email", email);
            sqlInsert.Parameters.AddWithValue("@idRol", idRol);
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

        public static void ActualizarUsuario(string idUsuario, DateTime fechaRegistro, string nombres, string apellidos, string usuarioLogin, string contrasenia, string email, int idRol, int estado)
        {
            string insert = "UPDATE tb_usuarios SET id_usuario = @idUsuario, fecha_registro_us = @fechaRegistro, nombre_usuario = @nombres, apellidos_usuario = @apellidos, usuario_login = @usuarioLogin, contrasenia_usuario = @contrasenia, email_usuario = @email, rol_usuario = @idRol, estado_usuario = @estado";

            SqlCommand sqlInsert = new SqlCommand(insert, DBConexion.ConectarSQL());

            sqlInsert.Parameters.AddWithValue("@idUsuario", idUsuario);
            sqlInsert.Parameters.AddWithValue("@fechaRegistro", fechaRegistro);
            sqlInsert.Parameters.AddWithValue("@nombres", nombres);
            sqlInsert.Parameters.AddWithValue("@apellidos", apellidos);
            sqlInsert.Parameters.AddWithValue("@usuarioLogin", usuarioLogin);
            sqlInsert.Parameters.AddWithValue("@contrasenia", contrasenia);
            sqlInsert.Parameters.AddWithValue("@email", email);
            sqlInsert.Parameters.AddWithValue("@idRol", idRol);
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

        public static int UltimoIdUsuario()
        {
            int ultimoId = -1; // valor por default en caso de error
            string query = "SELECT dbo.FN_ObtenerUltimoIDUsuarios()";
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
    }
}
