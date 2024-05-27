using Sis_GestionActivos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sis_GestionActivos.Vistas
{
    public partial class Operarios : Form
    {
        public Operarios()
        {
            InitializeComponent();;
        }

        private int correlativo = 1;



        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tbID.Text = "OP" + correlativo.ToString("D8");
            correlativo++;

            tbCargo.Text = string.Empty;
            tbNombre.Text = string.Empty;

            cmbEstado1.SelectedIndex = 0;
            cmbEstado2.SelectedIndex = 0;
        }

        private void Operarios_Load(object sender, EventArgs e)
        {

            tbFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
            tbFecha.ReadOnly = true;

            tbID.Text = "OP00000001";

            cmbEstado1.Items.AddRange(new string[] { "Activo", "Inactivo" });
            cmbEstado1.SelectedIndex = 0;

            cmbEstado2.Items.AddRange(new string[] { "Activo", "Inactivo", "Todos" });
            cmbEstado2.SelectedIndex = 0;

            string connectionString = "Data Source=EMMANUEL\\SQLEXPRESS;Initial Catalog=DBControlActivos;Integrated Security=True;\r\n";

            // Escribir la consulta SQL para seleccionar todos los datos de la tabla tb_operarios
            string query = "SELECT * FROM tb_operarios";

            // Crear la conexión a la base de datos y el adaptador de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                try
                {
                    // Abrir la conexión
                    connection.Open();

                    // Crear un DataSet para contener los datos
                    DataSet dataSet = new DataSet();

                    // Llenar el DataSet con los datos obtenidos de la base de datos
                    adapter.Fill(dataSet, "tb_operarios");

                    // Asignar el DataSet como origen de datos del DataGridView
                    dgvOperarios.DataSource = dataSet.Tables["tb_operarios"];

                    dgvOperarios.Columns[0].HeaderText = "Id de operario";
                    dgvOperarios.Columns[1].HeaderText = "Fecha";
                    dgvOperarios.Columns[2].HeaderText = "Nombre del operario";
                    dgvOperarios.Columns[3].HeaderText = "Cargo";
                    dgvOperarios.Columns[4].HeaderText = "Estado";
                    dgvOperarios.Columns.RemoveAt(5);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al llenar el DataGridView: " + ex.Message);
                }
            }

        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbEstado1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvOperarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbEstado2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbID.Text))
            {
                tbID.Text = "OP" + correlativo.ToString("D8");
            }
        }

        private void tbFecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCargo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Establece la cadena de conexión a tu base de datos
                string connectionString = "Data Source=EMMANUEL\\SQLEXPRESS;Initial Catalog=DBControlActivos;Integrated Security=True;\r\n";

                // Crea una nueva conexión SQL
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    // Abre la conexión
                    conexion.Open();

                    // Escribir la consulta SQL para actualizar datos en tu base de datos
                    string consulta = @"UPDATE tb_operarios 
                                SET fecha_registro_op = @Fecha, 
                                    id_operario = @ID, 
                                    estado_operario = @Estado, 
                                    cargo_operario = @Cargo, 
                                    nombre_operario = @Nombre";

                    // Crea un nuevo comando SQL con la consulta y la conexión
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        // Asigna los valores de los campos TextBox y ComboBox a los parámetros SQL
                        comando.Parameters.AddWithValue("@Fecha", tbFecha.Text);
                        comando.Parameters.AddWithValue("@ID", tbID.Text);
                        comando.Parameters.AddWithValue("@Estado", cmbEstado1.SelectedItem.ToString().ToLower() == "activo" ? 1 : 0); // Convierte "Activo" a 1 y "Inactivo" a 0
                        comando.Parameters.AddWithValue("@Cargo", tbCargo.Text);
                        comando.Parameters.AddWithValue("@Nombre", tbNombre.Text);

                        // Ejecuta la consulta SQL
                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Datos actualizados exitosamente en la base de datos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar los datos en la base de datos: " + ex.Message);
            }

            CargarDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void CargarDatos()
        {
            string connectionString = "Data Source=EMMANUEL\\SQLEXPRESS;Initial Catalog=DBControlActivos;Integrated Security=True;\r\n";

            // Escribir la consulta SQL para seleccionar todos los datos de la tabla tb_operarios
            string query = "SELECT * FROM tb_operarios";

            // Crear la conexión a la base de datos y el adaptador de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                try
                {
                    // Abrir la conexión
                    connection.Open();

                    // Crear un DataSet para contener los datos
                    DataSet dataSet = new DataSet();

                    // Llenar el DataSet con los datos obtenidos de la base de datos
                    adapter.Fill(dataSet, "tb_operarios");

                    // Asignar el DataSet como origen de datos del DataGridView
                    dgvOperarios.DataSource = dataSet.Tables["tb_operarios"];

                    dgvOperarios.Columns[0].HeaderText = "Id de operario";
                    dgvOperarios.Columns[1].HeaderText = "Fecha";
                    dgvOperarios.Columns[2].HeaderText = "Nombre del operario";
                    dgvOperarios.Columns[3].HeaderText = "Cargo";
                    dgvOperarios.Columns[4].HeaderText = "Estado";
                    dgvOperarios.Columns.RemoveAt(5);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }
        }

    }
}
