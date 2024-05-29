using Sis_GestionActivos.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sis_GestionActivos.Controladores
{
    internal class ActivosControlador
    {
        public static DataTable ObtenerActivos()
        {
            return ActivosModelo.ObtenerActivos();
        }

    }
}
