using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sis_GestionActivos.Controladores
{
    public class Funciones
    {
        public static string CorrelativoRegistro(int ultimoRegistro)
        {
            int num = ultimoRegistro;
            string correlativo = num.ToString("D10");
            return correlativo;
        }
    }
}
