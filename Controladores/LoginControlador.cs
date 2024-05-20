using Sis_GestionActivos.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.MonthCalendar;

namespace Sis_GestionActivos.Controladores
{
    public class LoginControlador
    {
        public bool AutenticarLogin(string usuarioLogin, string password)
        {
            LoginModelo loginModelo = new LoginModelo();
            DataTable dtControllerUsuario = new DataTable();

            dtControllerUsuario = loginModelo.BuscarUsuarioLogin(usuarioLogin);

            if(dtControllerUsuario.Rows.Count > 0)
            {
                DataRow fila = dtControllerUsuario.Rows[0];

                return usuarioLogin == fila["usuario_login"] && password == fila["contraseña_usuario"]; 
            }
            return false;
        }
    }
}
