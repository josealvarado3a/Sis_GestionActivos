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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sis_GestionActivos.Vistas
{
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

        public void dataGridUsuarios()
        {
            grid_lista_usuarios.DataSource = UsuariosControlador.DataGridViewDA();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            dataGridUsuarios();
            habilitarControles();
        }

        private void btn_nuevo_ad_Click(object sender, EventArgs e)
        {

            tab_listado_usuarios.SelectedTab = tab_listado_usuarios.TabPages[1];
            habilitarControles(true);

            txtFecha.Text = Funciones.FechaActual();
            txtId.Text = UsuariosControlador.IdUltimoUsuario();
            EstadoUsuario();
            Roles();
            habilitarControles(true);
        }

        public void Roles()
        {
            DataTable dt = UsuariosControlador.RolesUsuario();

            List<string> roles = new List<string>();
            foreach (DataRow dr in dt.Rows)
            {
                string listRoles = $"{dr["id_rol"]}. {dr["nombre_rol"]}";
                roles.Add(listRoles);
            }
            cbRol.Items.AddRange(roles.ToArray());
        }

        public void EstadoUsuario()
        {
            cb_estado.Items.Add("Activo");
            cb_estado.Items.Add("Inactivo");
        }

        public void habilitarControles(bool key = false)
        {
            bool estadoControles = false;
            if (key)
            {
                estadoControles = true;
            }

            txtNombre.Enabled = estadoControles;
            txtApellidos.Enabled = estadoControles;
            txtUsuarioLogin.Enabled = estadoControles;
            
            txt_contrasenia.Enabled = estadoControles;
            txt_email.Enabled = estadoControles;
            cbRol.Enabled = estadoControles;
            cb_estado.Enabled = estadoControles;

            btn_guardar.Enabled = estadoControles;
            btn_cancelar.Enabled = estadoControles;

        }

        public void limpiarControles()
        {
            txtFecha.Text = string.Empty;
            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtUsuarioLogin.Text = string.Empty;
            txt_contrasenia.Text = string.Empty;
            txt_email.Text = string.Empty;
            cbRol.Text = string.Empty;
            cb_estado.Text = string.Empty;

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            DateTime fecha = Convert.ToDateTime(txtFecha.Text);
            string idUsuario = txtId.Text;
            string nombres = txtNombre.Text;
            string apellidos = txtApellidos.Text;
            string usuario = txtUsuarioLogin.Text;
            string contrasenia = txt_contrasenia.Text;
            string email = txt_email.Text;

            string stringRol = cbRol.Text;
            char rol = stringRol[0];

            int intRol = (int)char.GetNumericValue(rol);

            string stringEstado = cb_estado.Text;
            int idEstado;

            switch (stringEstado)
            {
                case "Activo":
                    idEstado = 1;
                    break;
                case "Inactivo":
                    idEstado = 0;
                    break;
                default: 
                    idEstado = -1; 
                   break;
            }

            try
            {
                UsuariosControlador.InsertarUsuario(idUsuario,fecha,nombres,apellidos,usuario,contrasenia,email, intRol, idEstado);

                this.limpiarControles();
                tab_listado_usuarios.SelectedTab = tab_listado_usuarios.TabPages[0];
                this.habilitarControles();
                this.dataGridUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Forms: " + ex.Message);
            }
        }
    }
}
