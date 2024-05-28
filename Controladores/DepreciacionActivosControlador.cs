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
    }
}
