using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Sis_GestionActivos.Controladores
{
    public class Funciones
    {
        static string nombreUsuario;
        public static string CorrelativoRegistro(int ultimoRegistro)
        {
            int num = ultimoRegistro;
            string correlativo = num.ToString("D10");
            return correlativo;
        }

        public static string FechaActual()
        {
            DateTime fecha = DateTime.Now;
            return fecha.ToString("dd-MM-yyyy");
        }

        public static void GetUsuarioLogin(string usuario) 
        {
           nombreUsuario = usuario;
        }

        public static string SetUsuarioLogin()
        {
            return nombreUsuario;
        }

        public static string DiezCaracteres(string cadena)
        {
            return cadena.Substring(0, 10);
        }
    }
}
