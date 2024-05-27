using Sis_GestionActivos.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sis_GestionActivos.Controladores
{
    public class ClasificacionesActivosControlador
    {
        public static DataTable DataGridViewCL()
        {
            try
            {
                DataTable dtClasificacionesActivos = ClasificacionesActivosModelo.ViewClasificacionesActivos();
                return dtClasificacionesActivos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error controllers: " + ex.Message);
            }

            return null;
        }

        public static int ContarEdificiosRegistrados(string idEdificios)
        {
            int numEdificios = ClasificacionesActivosModelo.contarActivosPorClasificacion(idEdificios);
            return numEdificios;
        }

        public static int ContarMaquinariaRegistrados(string idMaquinaria)
        {
            int numMaquinaria = ClasificacionesActivosModelo.contarActivosPorClasificacion(idMaquinaria);
            return numMaquinaria;
        }

        public static int ContarVehiculosRegistrados(string idVehiculos)
        {
            int numVehiculos = ClasificacionesActivosModelo.contarActivosPorClasificacion(idVehiculos);
            return numVehiculos;
        }

        public static int ContarMobiliarioRegistrados(string idMobiliario)
        {
            int numMobiliario = ClasificacionesActivosModelo.contarActivosPorClasificacion(idMobiliario);
            return numMobiliario;
        }
    }
}
