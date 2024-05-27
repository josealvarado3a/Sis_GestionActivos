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
    public partial class FormDepreciacionActivos : Form
    {
        public FormDepreciacionActivos()
        {
            InitializeComponent();
        }

        public void Responsivo()
        {
            panel_top.Width = this.Width;

            this.tab_control_DAF.Width = this.Width;
            this.tab_control_DAF.Height = this.Height - panel_top.Height;

            this.panel_botones_AD.Width = this.tab_control_DAF.Width;
            
            this.AD_data_grid.Width = this.panel_botones_AD.Width;
            this.AD_data_grid.Height = this.tab_control_DAF.Height;
        }

        private void FormDepreciacionActivos_Resize(object sender, EventArgs e)
        {
            this.Responsivo();
        }

        private void btn_buscar_td_Click(object sender, EventArgs e)
        {
            FormBuscar formBuscar = new FormBuscar();
            formBuscar.Text = "Buscar activo fijo";
            formBuscar.TextBuscar("Utilice este campo para buscar por nombre");
            formBuscar.ShowDialog();
        }

        public void GridViewADLoad()
        {
            AD_data_grid.DataSource = DepreciacionActivosControlador.DataGridViewDA();
        }

        private void FormDepreciacionActivos_Load(object sender, EventArgs e)
        {
            this.GridViewADLoad();
            this.habilitarControles();
        }

        public void habilitarControles(bool key = false)
        {
            bool estadoControles = false;
            if (key)
            {
                estadoControles = true;
            }

            txt_valor_residual.Enabled = estadoControles;
            txt_ultimo_anio.Enabled = estadoControles;
            cb_estado_depreciacion.Enabled = estadoControles;

            btn_buscar_35.Enabled = estadoControles;
            btn_rehacer_35.Enabled = estadoControles;
            btn_guardar.Enabled = estadoControles;
            btn_cancelar.Enabled = estadoControles;

        }

        private void btn_nuevo_ad_Click(object sender, EventArgs e)
        {
            tab_control_DAF.SelectedTab = tab_control_DAF.TabPages[1];
            habilitarControles(true);

            txt_fecha_registro.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void btn_buscar_35_Click(object sender, EventArgs e)
        {
            FormBuscar formBuscar = new FormBuscar();
            formBuscar.DataGridView(DepreciacionActivosControlador.ListaActivosBuscar());
            formBuscar.ColumnaBuscar("[Nombre del activo]", "ID Activo");
            formBuscar.Text = "Buscar activos";
            formBuscar.ShowDialog();

            string idSeleccionado = formBuscar.IDBuscado;
            txt_id_activo.Text = idSeleccionado;
        }
    }
}
