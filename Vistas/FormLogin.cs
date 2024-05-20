using Sis_GestionActivos.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sis_GestionActivos.Vistas
{
    public partial class FormLogin : Form
    {
        private LoginControlador loginControlador;
        public FormLogin()
        {
            InitializeComponent();
            
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            loginControlador = new LoginControlador();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            string usuario = txt_usuario.Text;
            string password = txt_pwd.Text;

            if (!string.IsNullOrEmpty(usuario))
            {
                if (!string.IsNullOrEmpty(password))
                {

                    bool usuarioAutenticado = loginControlador.AutenticarLogin(usuario, password);

                    if (usuarioAutenticado)
                    {
                        MessageBox.Show("Usuario encontrado");
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado");
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar una contraseña antes de intentar acceder.");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un usuario antes de intentar acceder.");
            }
        }

        
    }
}
