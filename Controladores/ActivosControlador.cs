using Sis_GestionActivos.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sis_GestionActivos.Controladores
{
    public class ActivosControlador
    {
        public static DataTable ObtenerActivos()
        {
            return ActivosModelo.ObtenerActivos();
        }

        public static DataTable ObtenerClasificaciones()
        {
            return ActivosModelo.ObtenerClasificaciones();
        }

        public static DataTable ObtenerOperarios()
        {
            return ActivosModelo.ObtenerOperarios();
        }

        public static DataTable ObtenerUbicaciones()
        {
            return ActivosModelo.ObtenerUbicaciones();
        }

        public static void EliminarActivo(string id)
        {
           ActivosModelo.EliminarActivo(id);
        }

        public static DataTable ObtenerCtAsocciado(string idCtAsocc)
        {
            return ActivosModelo.ObtenerCategorias(idCtAsocc);
        }

        public static void InsertarActivo(string idActivo, DateTime fechaRegistro, string codigoInterno, string nombreActivo, string idClasificacion, string idCategoria, string usuarioRegistro, DateTime fechaAlta, decimal valorActivo, string idOperario, string idUbicacion, string descrip)
        {
            ActivosModelo.InsertarActivo(idActivo, fechaRegistro, codigoInterno, nombreActivo, idClasificacion, idCategoria, usuarioRegistro, fechaAlta, valorActivo, idOperario, idUbicacion, descrip);
        }
    }
}
