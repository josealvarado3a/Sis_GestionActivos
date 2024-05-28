using Sis_GestionActivos.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace Sis_GestionActivos.Controladores
{
    internal class OperariosControlador
    {
        public static DataTable ObtenerOperarios()
        {
            return OperariosModelo.ObtenerOperarios();
        }

        public static int EliminarOperario(string idOperario)
        {
            return OperariosModelo.EliminarOperario(idOperario);
        }
    }
}
