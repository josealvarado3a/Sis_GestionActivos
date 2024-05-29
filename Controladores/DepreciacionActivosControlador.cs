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
    public class DepreciacionActivosControlador
    {
        public static DataTable DataGridViewDA()
        {
            DataTable dtDepreciacionActivos = DepreciacionActivosModelo.ViewDepreciacionActivos();

            return dtDepreciacionActivos;
        }

        public static DataTable ListaActivosBuscar()
        {
            DataTable dtLista = new DataTable();
            dtLista = DepreciacionActivosModelo.ListadoActivos();
            return dtLista;
        }

        public static DataTable ActivoDepreciacion(string IdActivo)
        {
            DataTable dtActivo = new DataTable();

            try
            {
                dtActivo = DepreciacionActivosModelo.BuscarActivoParaDepreciar(IdActivo);
                return dtActivo;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Controllers");
            }

            return null;
        }

        public static string IdDepreciacion()
        {
            return Funciones.CorrelativoRegistro(DepreciacionActivosModelo.UltimoIdDepreciacion());
        }

        public static void InsertarDepreciacion(string idDepreciacion, string IdActivo, string IdClasificacion, DateTime fechaRegistro, int anioVidaUtil, decimal porcentaje, decimal valorActivo, decimal valorResidual, string IdUbicacion, int anioCompra, int ultimoAnio, string usuarioRegistro, int estado)
        {
            try
            {
                DepreciacionActivosModelo.InsertarDepreciacion(idDepreciacion, IdActivo, IdClasificacion, fechaRegistro, anioVidaUtil, porcentaje, valorActivo, valorResidual, IdUbicacion, anioCompra, ultimoAnio, usuarioRegistro, estado);

            }catch (Exception ex)
            {
                MessageBox.Show("Error Controllers: " + ex.Message);
            }
        }

        public static void ActualizarDepreciacion(string idDepreciacion, string IdActivo, string IdClasificacion, DateTime fechaRegistro, int anioVidaUtil, decimal porcentaje, decimal valorActivo, decimal valorResidual, string IdUbicacion, int anioCompra, int ultimoAnio, string usuarioRegistro, int estado)
        {
            try
            {
                DepreciacionActivosModelo.ActualizarDepreciacion(idDepreciacion, IdActivo, IdClasificacion, fechaRegistro, anioVidaUtil, porcentaje, valorActivo, valorResidual, IdUbicacion, anioCompra, ultimoAnio, usuarioRegistro, estado);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Controllers: " + ex.Message);
            }
        }

        public static DataTable ObtnerDepreciacionPorID(string id)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = DepreciacionActivosModelo.BuscarDepreciacionPorID(id);

                return dt;
            }catch (Exception ex)
            {
                MessageBox.Show("Error Controllers: " + ex.Message);
            }

            return null;
        }

        public static void EliminarDepreciacion(string id)
        {
            DepreciacionActivosModelo.EliminarDepreciacion(id);
        }
    }
}
