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
    public partial class FormInicial : Form
    {
        public string idRolUsuario;
        public FormInicial()
        {
            InitializeComponent();
        }

        private void FormInicial_Load(object sender, EventArgs e)
        {
            this.Text = lb_nombre_sistema.Text;
            this.WindowState = FormWindowState.Maximized;
            this.habilitarAccesos(this.idRolUsuario);
            this.HorayFecha();
        }

        public void responisvo()
        {
            this.panel_encabezado.Width = this.Width;
            this.panel_footer.Width = this.Width;

            // Calcular la nueva posición X para centrar el control horizontalmente
            int groupbtnX = (this.Width - this.group_btn_acesos.Width) / 2;
            int footerY = (this.Height - this.panel_footer.Height);
            int panelFechaX = (this.Width - this.panel_fecha.Width - 15);

            // Calcular la nueva posición Y para centrar el control verticalmente
            int groupbtnY = (this.Height - this.group_btn_acesos.Height - 5) / 2;

            // Asignar la nueva posición al control
            this.group_btn_acesos.Location = new Point(groupbtnX, groupbtnY);
            this.panel_footer.Location = new Point(this.group_btn_acesos.Location.X, footerY);
            this.panel_fecha.Location = new Point(panelFechaX, this.panel_fecha.Location.Y);
        }

        private void FormInicial_Resize(object sender, EventArgs e)
        {
            this.responisvo();
        }

        public void HorayFecha ()
        {
            lb_hora.Text = DateTime.Now.ToString("HH:mm:ss");
            lb_fecha.Text = DateTime.Now.ToString("dddd:MMMM:yyyy");
        }

        private void btn_depreciacion_activos_Click(object sender, EventArgs e)
        {
            FormDepreciacionActivos formDepreciacionActivos = new FormDepreciacionActivos();
            formDepreciacionActivos.ShowDialog();
        }

        private void btn_empresa_Click(object sender, EventArgs e)
        {
            FormEmpresa formEmpresa = new FormEmpresa();
            formEmpresa.ShowDialog();
        }

        public void datosInicioSesion(string nombre_usuario, string id_rol, string rol_usuario)
        {
            lb_nombre_usuario.Text = nombre_usuario;
            lb_rol.Text = rol_usuario;
            this.idRolUsuario = id_rol;
        }

        public void habilitarAccesos(string id_rol)
        {
            if (id_rol.Equals("2"))
            {
                btn_empresa.Enabled = false;
                btn_usuarios.Enabled = false;
            }
        }

        private void btn_operarios_Click(object sender, EventArgs e)
        {
            Operarios formOperarios = new Operarios();
            formOperarios.ShowDialog();
        }

        private void btn_activos_Click(object sender, EventArgs e)
        {

        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {

        }

        private void btn_clasificacion_activos_Click(object sender, EventArgs e)
        {

        }

        private void btn_ubicaciones_Click(object sender, EventArgs e)
        {

        }
    }
}
