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
    public partial class FormClasificaciones : Form
    {
        int cantidadEdificios = 0;
        int cantidadMaquinaria = 0;
        int cantidadVehiculos = 0;
        int cantidadMobiliario = 0;

        public FormClasificaciones()
        {
            InitializeComponent();
        }

        public void GridViewCLLoad()
        {

            this.grid_view_clasificaciones.DataSource = ClasificacionesActivosControlador.DataGridViewCL();
            this.cardActivos();
        }

        private void FormClasificaciones_Load(object sender, EventArgs e)
        {
            this.grid_view_clasificaciones.ReadOnly = true;
            this.GridViewCLLoad();
        }

        public void cardActivos()
        {
            string idEdificios = "0";
            string idMaquinaria = "0";
            string idVehiculos = "0";
            string idMobiliario = "0";

            if (grid_view_clasificaciones.Rows.Count > 4)
            {
                idEdificios = grid_view_clasificaciones.Rows[0].Cells["ID Clasificación"].Value.ToString();
                idMaquinaria = grid_view_clasificaciones.Rows[1].Cells["ID Clasificación"].Value.ToString();
                idVehiculos = grid_view_clasificaciones.Rows[2].Cells["ID Clasificación"].Value.ToString();
                idMobiliario = grid_view_clasificaciones.Rows[3].Cells["ID Clasificación"].Value.ToString();

                this.cantidadEdificios = ClasificacionesActivosControlador.ContarEdificiosRegistrados(idEdificios);
                this.cantidadMaquinaria = ClasificacionesActivosControlador.ContarMaquinariaRegistrados(idMaquinaria);
                this.cantidadVehiculos = ClasificacionesActivosControlador.ContarVehiculosRegistrados(idVehiculos);
                this.cantidadMobiliario = ClasificacionesActivosControlador.ContarMobiliarioRegistrados(idMobiliario);

                lb_num_edificios.Text = this.cantidadEdificios.ToString();
                lb_num_maquinaria.Text = this.cantidadMaquinaria.ToString();
                lb_num_vehiculos.Text = this.cantidadVehiculos.ToString();
                lb_num_mobiliario.Text = this.cantidadMobiliario.ToString();
            }
            else
            {
                MessageBox.Show("No hay filas");
            }
        }
    }
}
