using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sis_GestionActivos.Modelos
{
    public class LoginModelo
    {
        string tbUsuarios = "tb_usuarios";
       public DataTable BuscarUsuarioLogin(string usuario)
        {
            DataTable dtUsuario = new DataTable();
            string queryUsuario = "SELECT nombre_usuario, apellidos_usuario, usuario_login, contraseña_usuario FROM "+this.tbUsuarios+" WHERE usuario_login = @usuario";

            SqlCommand sqlUsuario = new SqlCommand(queryUsuario, DBConexion.ConectarSQL());

            sqlUsuario.Parameters.AddWithValue("@usuario", usuario);

            try
            {
                SqlDataAdapter adapterUsuario = new SqlDataAdapter(sqlUsuario);
                adapterUsuario.Fill(dtUsuario);

            }catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return dtUsuario;
        }
    }
}
