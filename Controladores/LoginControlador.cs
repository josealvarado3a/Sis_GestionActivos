using Sis_GestionActivos.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace Sis_GestionActivos.Controladores
{
    public class LoginControlador
    {
        public bool AutenticarLogin(string usuarioLogin, string password)
        {
            try
            {
                LoginModelo loginModelo = new LoginModelo();
                DataTable dtControllerUsuario = new DataTable();

                dtControllerUsuario = loginModelo.BuscarUsuarioLogin(usuarioLogin);

                if (dtControllerUsuario.Rows.Count > 0)
                {
                    DataRow fila = dtControllerUsuario.Rows[0];

                    if (fila["usuario_login"] != DBNull.Value && fila["contraseña_usuario"] != DBNull.Value)
                    {
                        bool usuarioValido = usuarioLogin.Equals(fila["usuario_login"].ToString(), StringComparison.Ordinal);
                        bool passwordValido = password.Equals(fila["contraseña_usuario"].ToString(), StringComparison.Ordinal);

                        return usuarioValido && passwordValido;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
        }

        public bool IniciarSesion(string txtUsuario, string txtPassword)
        {
            bool autenticar = this.AutenticarLogin(txtUsuario, txtPassword);
            return autenticar;
        }
    }
}
