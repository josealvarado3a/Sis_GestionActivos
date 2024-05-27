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
        public string IDBuscado;
        public string ColumnaBuscada;
        public string nombreColumnaBuscar;
        public FormBuscar()
        {
            InitializeComponent();
        }

        private void FormBuscar_Load(object sender, EventArgs e)
        {
            this.fb_data_grid_view.Focus();
            txt_buscar.TextChanged += new EventHandler(txt_buscar_TextChanged);
        }

        public void DataGridView(DataTable dt)
        {
            try
            {
                this.fb_data_grid_view.DataSource = dt;

            }catch(Exception ex)
            {
                MessageBox.Show("Error Form: " + ex.Message);
            }
        }

        public void TextBuscar(string referencia)
        {
            txt_buscar.Text = referencia;
        }

        private void txt_buscar_Click(object sender, EventArgs e)
        {
            txt_buscar.Text = string.Empty;
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            string textoFiltrar = txt_buscar.Text;
            try
            {
                (fb_data_grid_view.DataSource as DataTable).DefaultView.RowFilter = string.Format("{0} LIKE '%{1}%'", this.nombreColumnaBuscar, textoFiltrar);
            }catch(Exception ex)
            {
                MessageBox.Show("Error Form: " + ex.Message);
            }
        }

        public void ColumnaBuscar(string ColumnaBuscar, string ColumnaSeleccionar)
        {
            this.nombreColumnaBuscar = ColumnaBuscar.ToString();
            this.ColumnaBuscada = ColumnaSeleccionar.ToString();

        }

        private void fb_data_grid_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow seleccionFila = this.fb_data_grid_view.Rows[e.RowIndex];
                this.IDBuscado = Convert.ToString(seleccionFila.Cells[$"{this.ColumnaBuscada}"].Value);
            }
        }

        public string IDEncontrado()
        {
            return this.IDBuscado;
        }

        private void btn_aceptar_buscar_Click(object sender, EventArgs e)
        {
            string IDEncontrado = this.IDBuscado;
            if (IDEncontrado != string.Empty)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("No has seleccionado el registro que buscas");
            }
        }

        private void btn_cancelar_aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
