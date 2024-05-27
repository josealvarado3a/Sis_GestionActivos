using Sis_GestionActivos.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
