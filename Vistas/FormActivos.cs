using Sis_GestionActivos.Controladores;
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
    public partial class FormActivos : Form
    {
        public FormActivos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void FormActivos_Load(object sender, EventArgs e)
        {
            CargarDatosActivos();
            AsignarFechaActualATextBox();

            textBox2.Text = CorrActivo().ToString();

            CargarClasificacionActivos();
            CargarDatosComboBox2();


        }

        private void CargarClasificacionActivos()
        {
            try
            {
                // Lista de nombres de clasificación de activos
                List<string> clasificaciones = new List<string>
        {
            "Edificios",
            "Maquinaria",
            "Vehiculos",
            "Mobilario, equipo y otros bienes"
        };

                // Asignar la lista al ComboBox
                comboBox1.DataSource = clasificaciones;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la clasificación de activos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatosComboBox2()
        {
            try
            {
                // Lista de datos para el ComboBox2
                List<string> datosComboBox2 = new List<string>
        {
            "Camiones",
            "Vans",
            "PC Desktop",
            "Laptops",
            "Escritorios",
            "Sillas",
            "Empaquetadoras",
            "Edificios"
        };

                // Asignar la lista al ComboBox2
                comboBox2.DataSource = datosComboBox2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos en el ComboBox2: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Método para simular la obtención del último registro
        private int ObtenerUltimoRegistro()
        {
            // Lógica para obtener el último registro
            return 1000; // Ejemplo
        }

        private void CargarDatosActivos()
        {
            try
            {
                // Llama al método ObtenerActivos del controlador ActivosControlador
                var datosActivos = ActivosControlador.ObtenerActivos();

                // Asigna los datos al DataGridView
                dataGridView1.DataSource = datosActivos;

                dataGridView1.Columns["id_activo"].HeaderText = "Código";
                dataGridView1.Columns["nombre_activo"].HeaderText = "Nombre";
                dataGridView1.Columns["clasificacion"].HeaderText = "Clasificación";
                dataGridView1.Columns["categoria"].HeaderText = "Categoria";
                dataGridView1.Columns["fecha_registro"].HeaderText = "Fecha de registro";
                dataGridView1.Columns["fecha_compra"].HeaderText = "Fecha de compra";
                dataGridView1.Columns["encargado"].HeaderText = "Encargado";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de los activos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AsignarFechaActualATextBox()
        {
            // Utiliza la función FechaActual() de la clase Funciones para obtener la fecha actual
            string fechaActual = Funciones.FechaActual();

            // Asigna la fecha actual al TextBox1
            textBox1.Text = fechaActual;
        }

        public static int UltimoIdActivo()
        {
            int ultimoId = 1; // Valor por defecto en caso de error
            string selectIdActivo = "SELECT dbo.FN_ObtenerUltimoIDActivos()"; // Agrega los paréntesis para llamar a la función
            using (SqlConnection conexion = DBConexion.ConectarSQL())
            using (SqlCommand select = new SqlCommand(selectIdActivo, conexion))
            {
                try
                {
                    object resultado = select.ExecuteScalar();

                    if (resultado != null && resultado != DBNull.Value)
                    {
                        ultimoId = Convert.ToInt32(resultado);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error SQL: " + ex.Message);
                }
            }

            return ultimoId;
        }

        public static string CorrActivo()
        {
            int id = UltimoIdActivo() + 1;
            string corrActivo = id.ToString("D10"); // Formato de 10 dígitos
            return corrActivo;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
