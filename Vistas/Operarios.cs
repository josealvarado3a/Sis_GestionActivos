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
    public partial class Operarios : Form
    {
        public Operarios()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void Operarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBControlActivosDataSet.tb_operarios' Puede moverla o quitarla según sea necesario.
            this.tb_operariosTableAdapter.Fill(this.dBControlActivosDataSet.tb_operarios);

        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
