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
    }
}
