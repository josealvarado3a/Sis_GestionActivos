using Sis_GestionActivos.Controladores;
using Sis_GestionActivos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Sis_GestionActivos.Vistas
{
    public partial class Operarios : Form
    {
        public Operarios()
        {
            InitializeComponent(); ;
        }

        private bool loadingData = false;

        private void CargarDatosOperarios()
        {
            try
            {
                DataTable datosOperarios = OperariosControlador.ObtenerOperarios();
                dgvOperarios.DataSource = datosOperarios;

                // Opcional: Personalizar los encabezados de las columnas
                dgvOperarios.Columns["id_operario"].HeaderText = "Id de operario";
                dgvOperarios.Columns["fecha_registro_op"].HeaderText = "Fecha";
                dgvOperarios.Columns["nombre_operario"].HeaderText = "Nombre del operario";
                dgvOperarios.Columns["cargo_operario"].HeaderText = "Cargo";
                dgvOperarios.Columns["estado_operario"].HeaderText = "Estado";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de los operarios: " + ex.Message);
            }
        }

        public static int UltimoIdOperario()
        {
            int ultimoId = 1; // valor por defecto en caso de error
            string selectIdOperario = "SELECT dbo.FN_ObtenerUltimoIDOperarios()"; // Agrega los paréntesis para llamar a la función
            using (SqlConnection conexion = DBConexion.ConectarSQL())
            using (SqlCommand select = new SqlCommand(selectIdOperario, conexion))
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

        public static string CorrTarea()
        {
            int id = UltimoIdOperario() + 1;
            string corrTarea = id.ToString("D10"); // Formato de 10 dígitos
            return corrTarea;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView
            if (dgvOperarios.SelectedRows.Count > 0)
            {
                // Obtener el ID del operario seleccionado
                string idOperario = dgvOperarios.SelectedRows[0].Cells["id_operario"].Value.ToString();

                // Confirmar la eliminación mediante un mensaje de confirmación
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este operario?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Verificar si existen registros relacionados en la tabla tb_activos
                        bool existenRegistrosRelacionados = OperariosModelo.ExistenRegistrosRelacionados(idOperario);

                        // Si existen registros relacionados, mostrar un mensaje y salir del método
                        if (existenRegistrosRelacionados)
                        {
                            MessageBox.Show("No se puede eliminar el operario porque hay activos asociados a él.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Si no existen registros relacionados, proceder con la eliminación del operario
                        int filasAfectadas = OperariosControlador.EliminarOperario(idOperario);

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Operario eliminado exitosamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarDatosOperarios();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el operario.", "Error de Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el operario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.", "Seleccionar Fila", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView
            if (dgvOperarios.SelectedRows.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                int indiceFilaSeleccionada = dgvOperarios.SelectedRows[0].Index;

                // Obtener el valor de la fecha del DataGridView
                DateTime fechaOperario = Convert.ToDateTime(dgvOperarios.Rows[indiceFilaSeleccionada].Cells["fecha_registro_op"].Value);

                // Formatear la fecha como una cadena sin ceros iniciales en la hora
                string fechaFormateada = fechaOperario.ToString("yyyy-MM-dd");

                // Obtener los otros valores de la fila seleccionada
                string idOperario = dgvOperarios.Rows[indiceFilaSeleccionada].Cells["id_operario"].Value.ToString();
                string nombre = dgvOperarios.Rows[indiceFilaSeleccionada].Cells["nombre_operario"].Value.ToString();
                string cargo = dgvOperarios.Rows[indiceFilaSeleccionada].Cells["cargo_operario"].Value.ToString();
                bool estado = (bool)dgvOperarios.Rows[indiceFilaSeleccionada].Cells["estado_operario"].Value;

                // Asignar los valores a los controles en tu formulario de modificación
                tbID.Text = idOperario;
                tbFecha.Text = fechaFormateada; // Aquí se asigna la fecha formateada
                tbNombre.Text = nombre;
                tbCargo.Text = cargo;
                cmbEstado1.SelectedItem = estado ? "Activo" : "Inactivo"; // Asignar el valor al ComboBox según el estado
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para modificar.");
            }
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tbID.Text = CorrTarea();

            tbFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");

            tbCargo.Text = string.Empty;
            tbNombre.Text = string.Empty;

            cmbEstado1.SelectedIndex = 0;
            cmbEstado2.SelectedIndex = 0;
        }

        private void Operarios_Load(object sender, EventArgs e)
        {
            CargarDatosOperarios(); // Llama al nuevo método que carga los datos de los operarios

            tbFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
            tbFecha.ReadOnly = true;

            tbID.Text = CorrTarea();

            cmbEstado1.Items.Add("Activo");
            cmbEstado1.Items.Add("Inactivo");
            cmbEstado1.SelectedIndex = 0;

            cmbEstado2.Items.Add("Activo");
            cmbEstado2.Items.Add("Inactivo");
            cmbEstado2.Items.Add("Todos");
            cmbEstado2.SelectedIndex = 0;

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
            try
            {
                // Obtiene el estado seleccionado en el ComboBox
                string estadoSeleccionado = cmbEstado2.SelectedItem.ToString().ToLower();

                // Declaración de la consulta SQL
                string query;

                // Determina la consulta SQL según el estado seleccionado
                if (estadoSeleccionado == "todos")
                {
                    // Consulta para mostrar todos los registros
                    query = "SELECT id_operario, fecha_registro_op, nombre_operario, cargo_operario, estado_operario FROM tb_operarios";
                }
                else
                {
                    // Determina el valor del estado para la consulta (1 para "activo", 0 para "inactivo")
                    int estadoValor = estadoSeleccionado == "activo" ? 1 : 0;

                    // Consulta para filtrar registros según el estado seleccionado
                    query = "SELECT id_operario, fecha_registro_op, nombre_operario, cargo_operario, estado_operario FROM tb_operarios WHERE estado_operario = @Estado";
                }

                // Crear la conexión a la base de datos y el adaptador de datos utilizando DBConexion.ConectarSQL()
                using (SqlConnection connection = DBConexion.ConectarSQL())
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    // Asignar el valor del parámetro solo si no es "todos"
                    if (estadoSeleccionado != "todos")
                    {
                        int estadoValor = estadoSeleccionado == "activo" ? 1 : 0;
                        adapter.SelectCommand.Parameters.AddWithValue("@Estado", estadoValor);
                    }

                    // Crear un DataSet para contener los datos
                    DataSet dataSet = new DataSet();

                    // Llenar el DataSet con los datos obtenidos de la base de datos
                    adapter.Fill(dataSet, "tb_operarios");

                    // Asignar el DataSet como origen de datos del DataGridView
                    dgvOperarios.DataSource = dataSet.Tables["tb_operarios"];

                    // Asignar encabezados personalizados a las columnas del DataGridView
                    dgvOperarios.Columns[0].HeaderText = "Id de operario";
                    dgvOperarios.Columns[1].HeaderText = "Fecha";
                    dgvOperarios.Columns[2].HeaderText = "Nombre del operario";
                    dgvOperarios.Columns[3].HeaderText = "Cargo";
                    dgvOperarios.Columns[4].HeaderText = "Estado";

                    // Opcional: eliminar columnas no deseadas
                    // dgvOperarios.Columns.RemoveAt(5);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el DataGridView: " + ex.Message);
            }
        }



        private void tbID_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbID.Text))
            {
                tbID.Text = CorrTarea();
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
                // Utiliza DBConexion.ConectarSQL() para obtener una conexión SQL
                using (SqlConnection conexion = DBConexion.ConectarSQL())
                {
                    // Verifica si se ha ingresado un id_operario válido
                    if (string.IsNullOrEmpty(tbID.Text))
                    {
                        MessageBox.Show("El campo ID es obligatorio para la actualización.");
                        return;
                    }

                    // Verifica si el id_operario existe en la base de datos
                    bool idExistente = OperariosControlador.ExisteOperario(tbID.Text);

                    // Declara la consulta SQL y los parámetros
                    string consulta;
                    SqlCommand comando;

                    if (idExistente)
                    {
                        // Se ha encontrado el id_operario en la base de datos, por lo tanto, se ejecutará una consulta de actualización
                        consulta = @"UPDATE tb_operarios 
                             SET fecha_registro_op = @Fecha, 
                                 estado_operario = @Estado, 
                                 cargo_operario = @Cargo, 
                                 nombre_operario = @Nombre
                             WHERE id_operario = @ID";
                    }
                    else
                    {
                        // No se ha encontrado el id_operario en la base de datos, por lo tanto, se ejecutará una consulta de inserción
                        consulta = @"INSERT INTO tb_operarios (id_operario, fecha_registro_op, estado_operario, cargo_operario, nombre_operario, descripcion_operario)
                             VALUES (@ID, @Fecha, @Estado, @Cargo, @Nombre, @Descripcion)";
                    }

                    // Crea un nuevo comando SQL con la consulta y la conexión
                    comando = new SqlCommand(consulta, conexion);

                    // Asigna los valores de los parámetros SQL
                    comando.Parameters.AddWithValue("@ID", tbID.Text);
                    comando.Parameters.AddWithValue("@Fecha", DateTime.Now); // Puedes usar la fecha actual o el valor ingresado en tbFecha.Text
                    comando.Parameters.AddWithValue("@Estado", cmbEstado1.SelectedItem.ToString().ToLower() == "activo" ? 1 : 0);
                    comando.Parameters.AddWithValue("@Cargo", string.IsNullOrEmpty(tbCargo.Text) ? DBNull.Value : (object)tbCargo.Text);
                    comando.Parameters.AddWithValue("@Nombre", tbNombre.Text);
                    comando.Parameters.AddWithValue("@Descripcion", DBNull.Value); // Valor nulo por defecto

                    // Ejecuta la consulta SQL
                    int filasAfectadas = comando.ExecuteNonQuery();

                    // Verifica si se insertó o actualizó algún registro
                    if (filasAfectadas > 0)
                    {
                        if (idExistente)
                        {
                            MessageBox.Show("Datos actualizados exitosamente en la base de datos.");
                        }
                        else
                        {
                            MessageBox.Show("Datos insertados exitosamente en la base de datos.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo insertar o actualizar el registro.");
                    }
                }

                // Recargar los datos después de la inserción o actualización
                CargarDatosOperarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar o actualizar los datos en la base de datos: " + ex.ToString());
            }
        }




        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Limpiar los campos de texto
            tbID.Text = CorrTarea();
            tbFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
            tbNombre.Text = string.Empty;
            tbCargo.Text = string.Empty;

            // Restablecer el estado del ComboBox
            if (cmbEstado1.Items.Count > 0)
            {
                cmbEstado1.SelectedIndex = 0; // Selecciona el primer ítem del ComboBox (puede ser "Activo" o "Inactivo")
            }

            // Opcional: Muestra un mensaje indicando que los campos han sido limpiados
            MessageBox.Show("Campos limpiados. Listo para nueva entrada.");

            // Si tienes otros controles que necesitan ser limpiados o restablecidos, agrégalos aquí
        }


        private void CargarDatos()
        {
            try
            {
                // Utiliza DBConexion.ConectarSQL() para obtener una conexión SQL
                using (SqlConnection connection = DBConexion.ConectarSQL())
                {
                    // Escribir la consulta SQL para seleccionar todos los datos de la tabla tb_operarios
                    string query = "SELECT * FROM tb_operarios";

                    // Crear el adaptador de datos utilizando la conexión y la consulta
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        // Crear un DataSet para contener los datos
                        DataSet dataSet = new DataSet();

                        // Llenar el DataSet con los datos obtenidos de la base de datos
                        adapter.Fill(dataSet, "tb_operarios");

                        // Asignar el DataSet como origen de datos del DataGridView
                        dgvOperarios.DataSource = dataSet.Tables["tb_operarios"];

                        // Personalizar los encabezados de las columnas del DataGridView
                        dgvOperarios.Columns[0].HeaderText = "Id de operario";
                        dgvOperarios.Columns[1].HeaderText = "Fecha";
                        dgvOperarios.Columns[2].HeaderText = "Nombre del operario";
                        dgvOperarios.Columns[3].HeaderText = "Cargo";
                        dgvOperarios.Columns[4].HeaderText = "Estado";

                        // Eliminar la última columna (opcional)
                        if (dgvOperarios.Columns.Count > 5)
                        {
                            dgvOperarios.Columns.RemoveAt(5);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }
    }
}
