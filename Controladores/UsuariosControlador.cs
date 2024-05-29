using Sis_GestionActivos.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sis_GestionActivos.Controladores
{
    public class UsuariosControlador
    {
        public static DataTable DataGridViewDA()
        {
            DataTable dtUsuarios = UsuarioModelo.ViewUsuarios();

            return dtUsuarios;
        }

        public static string IdUltimoUsuario()
        {
            return Funciones.CorrelativoRegistro(UsuarioModelo.UltimoIdUsuario());
        }

        public static DataTable RolesUsuario()
        {
            DataTable dtRoles = UsuarioModelo.RolesUsuario();

            return dtRoles;
        }

        public static void InsertarUsuario(string idUsuario, DateTime fechaRegistro, string nombres, string apellidos, string usuarioLogin, string contrasenia, string email, int idRol, int estado)
        {
            UsuarioModelo.InsertarUsuario(idUsuario, fechaRegistro, nombres, apellidos,  usuarioLogin, contrasenia, email, idRol, estado);
        }

        public static DataTable ObtenerUsuarioPorId(string idUsuario)
        {
            // Define tu consulta SQL para obtener los datos del usuario por su ID
            string query = "SELECT * FROM tb_usuarios WHERE id_usuario = @idUsuario";

            // Crea una instancia de DataTable para almacenar los resultados de la consulta
            DataTable dtUsuario = new DataTable();

            // Utiliza un objeto SqlCommand para ejecutar la consulta
            using (SqlCommand cmd = new SqlCommand(query, DBConexion.ConectarSQL()))
            {
                // Añade el parámetro de ID de usuario a la consulta
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                try
                {
                    // Utiliza un SqlDataAdapter para llenar el DataTable con los resultados de la consulta
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dtUsuario);
                }
                catch (Exception ex)
                {
                    // Maneja cualquier error que pueda ocurrir al ejecutar la consulta
                    MessageBox.Show("Error al obtener usuario por ID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Devuelve el DataTable con los datos del usuario (puede estar vacío si no se encuentra ningún usuario con el ID proporcionado)
            return dtUsuario;
        }

        public static bool UsuarioExiste(string idUsuario)
        {
            // Realiza una consulta a la base de datos para verificar si el usuario existe
            // Debes implementar la lógica para consultar la base de datos y retornar true si el usuario existe, de lo contrario, false

            // Aquí un ejemplo simple (debes ajustarlo a tu base de datos)
            string query = "SELECT COUNT(*) FROM tb_usuarios WHERE id_usuario = @idUsuario";
            SqlCommand command = new SqlCommand(query, DBConexion.ConectarSQL());
            command.Parameters.AddWithValue("@idUsuario", idUsuario);

            int count = (int)command.ExecuteScalar();
            return count > 0;
        }

        public static void ActualizarUsuario(string idUsuario, DateTime fechaRegistro, string nombres, string apellidos, string usuarioLogin, string contrasenia, string email, int idRol, int estado)
        {
            // Realiza la lógica para actualizar un usuario en la base de datos

            // Aquí tienes un ejemplo básico de cómo podrías hacerlo (debes ajustarlo según tu base de datos y tu lógica de negocio)
            string updateQuery = "UPDATE tb_usuarios SET fecha_registro_us = @fechaRegistro, nombre_usuario = @nombres, apellidos_usuario = @apellidos, usuario_login = @usuarioLogin, contrasenia_usuario = @contrasenia, email_usuario = @email, rol_usuario = @idRol, estado_usuario = @estado WHERE id_usuario = @idUsuario";

            SqlCommand command = new SqlCommand(updateQuery, DBConexion.ConectarSQL());
            command.Parameters.AddWithValue("@fechaRegistro", fechaRegistro);
            command.Parameters.AddWithValue("@nombres", nombres);
            command.Parameters.AddWithValue("@apellidos", apellidos);
            command.Parameters.AddWithValue("@usuarioLogin", usuarioLogin);
            command.Parameters.AddWithValue("@contrasenia", contrasenia);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@idRol", idRol);
            command.Parameters.AddWithValue("@estado", estado);
            command.Parameters.AddWithValue("@idUsuario", idUsuario);

            try
            {
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Usuario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
