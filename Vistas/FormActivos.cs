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
        public string IdSelec;
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

            txt_idActivo.Text = CorrActivo().ToString();

            cb_clasficaciones.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
            this.habilitarControles();
        }

        private void CargarClasificacionActivos()
        {
            try
            {
                DataTable dt = ActivosControlador.ObtenerClasificaciones();

                List<string> cl = new List<string>();
                foreach (DataRow dr in dt.Rows)
                {
                    string list = $"{dr["id_clasificacion_ca"]}. {dr["nombre_clasificacion_ca"]}";
                    cl.Add(list);
                }
                cb_clasficaciones.Items.AddRange(cl.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la clasificación de activos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarOperarios()
        {
            try
            {
                DataTable dt = ActivosControlador.ObtenerOperarios();

                List<string> cl = new List<string>();
                foreach (DataRow dr in dt.Rows)
                {
                    string list = $"{dr["id_operario"]}. {dr["nombre_operario"]}";
                    cl.Add(list);
                }
                cbEncargado.Items.AddRange(cl.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar operarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarUbicaciones()
        {
            try
            {
                DataTable dt = ActivosControlador.ObtenerUbicaciones();

                List<string> cl = new List<string>();
                foreach (DataRow dr in dt.Rows)
                {
                    string list = $"{dr["id_ubicacion"]}. {dr["nombre_ubicacion"]}";
                    cl.Add(list);
                }
                cbUbicaciones.Items.AddRange(cl.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ubicaciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatosCategorias(string idCt)
        {
            try
            {
                DataTable dt = ActivosControlador.ObtenerCtAsocciado(idCt);

                List<string> cl = new List<string>();
                foreach (DataRow dr in dt.Rows)
                {
                    string list = $"{dr["id_categoria_ct"]}. {dr["nombre_categoria"]}";
                    cl.Add(list);
                }
                cb_categoria.Items.AddRange(cl.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos categorias: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Método para simular la obtención del último registro
        private int ObtenerUltimoRegistro()
        {
            // Lógica para obtener el último registro
            return 1000; // Ejemplo
        }

        public void habilitarControles(bool key = false)
        {
            bool estadoControles = false;
            if (key)
            {
                estadoControles = true;
            }
            btnGuardar.Enabled = estadoControles;

            cb_clasficaciones.Enabled = estadoControles;
            cb_categoria.Enabled = estadoControles;

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
            txtFecha.Text = fechaActual;
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
            cb_categoria.Items.Clear();

            string idSeleccionado = Funciones.DiezCaracteres(cb_clasficaciones.SelectedItem.ToString());

            CargarDatosCategorias(idSeleccionado);
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CargarClasificacionActivos();
            CargarOperarios();
            CargarUbicaciones();
            txt_registrado_por.Text = Funciones.SetUsuarioLogin();
            txtFechaAlta.Text = Funciones.FechaActual();
            this.habilitarControles(true);
            btnGuardar.Enabled = true;
        }

        private void cb_categoria_TextChanged(object sender, EventArgs e)
        {
           
        }

        public void limpiarControles()
        {
            txt_idActivo.Text = string.Empty;
            txtFecha.Text = string.Empty;
            txtCodigo.Text = string.Empty;
            txtnombre.Text = string.Empty;
            txt_registrado_por.Text = string.Empty;
            cb_clasficaciones.Text = string.Empty;
            cb_categoria.Text = string.Empty;
            txtFechaAlta.Text = string.Empty;
            txtValor.Text = string.Empty;
            cbEncargado.Text = string.Empty;
            cbUbicaciones.Text = string.Empty;
            txtDescrip.Text = string.Empty;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string idActivo = txt_idActivo.Text;
                DateTime fecha = Convert.ToDateTime(txtFecha.Text);
                string codigo = txtCodigo.Text;
                string nombre = txtnombre.Text;
                string registro = txt_registrado_por.Text;
                string cl = Funciones.DiezCaracteres(cb_clasficaciones.Text);
                string ct = Funciones.DiezCaracteres(cb_categoria.Text);
                DateTime fechaAlta = Convert.ToDateTime(txtFechaAlta.Text);
                decimal valor = Convert.ToDecimal(txtValor.Text);
                string encargado = Funciones.DiezCaracteres(cbEncargado.Text);
                string ubicacion = Funciones.DiezCaracteres(cbUbicaciones.Text);
                string descrip = txtDescrip.Text;

                ActivosControlador.InsertarActivo(idActivo, fecha, codigo, nombre, cl, ct, registro, fechaAlta, valor, encargado, ubicacion, descrip);

                limpiarControles();
                habilitarControles();
                CargarDatosActivos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error forms: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow seleccionFila = dataGridView1.Rows[e.RowIndex];
                this.IdSelec = Convert.ToString(seleccionFila.Cells["id_activo"].Value);

                DialogResult resultado =  MessageBox.Show("Deseas Eliminar el registro con ID" + IdSelec + "?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    ActivosControlador.EliminarActivo(this.IdSelec);
                    CargarDatosActivos();
                }
                else
                {
                    return;
                }
            }
        }
    }
}
