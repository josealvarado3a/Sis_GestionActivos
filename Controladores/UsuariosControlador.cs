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
    }
}
