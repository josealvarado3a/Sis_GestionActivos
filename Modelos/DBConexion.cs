using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sis_GestionActivos.Modelos
{
    public class DBConexion
    {
        public static Dictionary<string, string> SetDataBase()
        {
            string serverName = Dns.GetHostName();
            Dictionary<string, string> oSetdb = new Dictionary<string, string>()
            {
                { "dbHost", ""},
                { "dbName", ""}
            };

            switch (serverName)
            {
                case "Jose":
                    oSetdb["dbHost"] = "localhost";
                    oSetdb["dbName"] = "DBControlActivos";
                    break;
                case "DESING":
                    oSetdb["dbHost"] = "DESING\\SQLEXPRESS";
                    oSetdb["dbName"] = "DBControlActivos";
                    break;
                case "EMMANUEL":
                    oSetdb["dbHost"] = "EMMANUEL\\SQLEXPRESS";
                    oSetdb["dbName"] = "DBControlActivos";
                    break;
                case "EMMANUEL":
                    oSetdb["dbHost"] = "EMMANUEL\\SQLEXPRESS";
                    oSetdb["dbName"] = "DBControlActivos";
                    break;
                default:
                    MessageBox.Show("Server no identificado");
                    break;
            }

            return oSetdb;
        }

        public static SqlConnection ConectarSQL()
        {
            Dictionary<string, string> setDB = new Dictionary<string, string>();
            setDB = SetDataBase();

            if (setDB != null)
            {
                string cadenaConexion = "server=" + setDB["dbHost"] + "; database=" + setDB["dbName"] + "; integrated security = true";
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                try
                {
                    conexion.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                return conexion;
            }
            return null;
        }
    }
}
