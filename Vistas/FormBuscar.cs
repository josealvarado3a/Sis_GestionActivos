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
    public partial class FormBuscar : Form
    {
        public FormBuscar()
        {
            InitializeComponent();
        }

        private void FormBuscar_Load(object sender, EventArgs e)
        {
            this.fb_data_grid_view.Focus();
        }

        public void TextBuscar(string referencia)
        {
            txt_buscar.Text = referencia;
        }

        private void txt_buscar_Click(object sender, EventArgs e)
        {
            txt_buscar.Text = string.Empty;
        }
    }
}
