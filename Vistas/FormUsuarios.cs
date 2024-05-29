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
                // Verificar si el usuario ya existe en la base de datos
                if (UsuariosControlador.UsuarioExiste(idUsuario))
                {
                    // Si el usuario existe, actualizar los datos
                    UsuariosControlador.ActualizarUsuario(idUsuario, fecha, nombres, apellidos, usuario, contrasenia, email, intRol, idEstado);
                    MessageBox.Show("Datos actualizados correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Si el usuario no existe, insertarlo en la base de datos
                    UsuariosControlador.InsertarUsuario(idUsuario, fecha, nombres, apellidos, usuario, contrasenia, email, intRol, idEstado);
                    MessageBox.Show("Usuario ingresado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Limpiar controles y actualizar DataGridView
                limpiarControles();
                dataGridUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Forms: " + ex.Message);
            }
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btn_modificar_ad_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView
            if (grid_lista_usuarios.SelectedRows.Count > 0)
            {
                // Obtener el ID de usuario seleccionado en el DataGridView
                string idUsuarioSeleccionado = grid_lista_usuarios.SelectedRows[0].Cells["ID Usuario"].Value.ToString();

                // Realizar una consulta a la base de datos para obtener los datos del usuario
                DataTable dtUsuario = UsuariosControlador.ObtenerUsuarioPorId(idUsuarioSeleccionado);

                // Verificar si se encontraron datos para el usuario seleccionado
                if (dtUsuario.Rows.Count > 0)
                {
                    // Obtener los datos del primer registro (se supone que solo habrá uno)
                    DataRow usuario = dtUsuario.Rows[0];

                    // Llenar los campos del formulario con la información obtenida de la base de datos
                    txtId.Text = usuario["id_usuario"].ToString();
                    txtFecha.Text = usuario["fecha_registro_us"].ToString();
                    txtNombre.Text = usuario["nombre_usuario"].ToString();
                    txtApellidos.Text = usuario["apellidos_usuario"].ToString();
                    txtUsuarioLogin.Text = usuario["usuario_login"].ToString();
                    txt_contrasenia.Text = usuario["contrasenia_usuario"].ToString();
                    txt_email.Text = usuario["email_usuario"].ToString();
                    cbRol.Text = usuario["rol_usuario"].ToString();
                    cb_estado.Text = usuario["estado_usuario"].ToString();

                    // Cambiar al tab correspondiente para mostrar los datos del usuario
                    tab_listado_usuarios.SelectedTab = tab_listado_usuarios.TabPages[1];
                    habilitarControles(true);
                }
                else
                {
                    MessageBox.Show("No se encontraron datos para el usuario seleccionado.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario en la lista.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void grid_lista_usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuarioLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_contrasenia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_estado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limpiarControles();
            tab_listado_usuarios.SelectedTab = tab_listado_usuarios.TabPages[0];
        }
    }
}
