using Sis_GestionActivos.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sis_GestionActivos.Vistas
{
    public partial class FormDepreciacionActivos : Form
    {
        public string IdUbicacion;
        public string IdSelect;
        public FormDepreciacionActivos()
        {
            InitializeComponent();
        }

        public void Responsivo()
        {
            panel_top.Width = this.Width;

            this.tab_control_DAF.Width = this.Width;
            this.tab_control_DAF.Height = this.Height - panel_top.Height;

            this.panel_botones_AD.Width = this.tab_control_DAF.Width;
            
            this.AD_data_grid.Width = this.panel_botones_AD.Width;
            this.AD_data_grid.Height = this.tab_control_DAF.Height;
        }

        private void FormDepreciacionActivos_Resize(object sender, EventArgs e)
        {
            this.Responsivo();
        }

        private void btn_buscar_td_Click(object sender, EventArgs e)
        {
            FormBuscar formBuscar = new FormBuscar();
            formBuscar.Text = "Buscar activo fijo";
            formBuscar.TextBuscar("Utilice este campo para buscar por nombre");
            formBuscar.ShowDialog();
        }

        public void GridViewADLoad()
        {
            AD_data_grid.DataSource = DepreciacionActivosControlador.DataGridViewDA();
        }

        private void FormDepreciacionActivos_Load(object sender, EventArgs e)
        {
            this.GridViewADLoad();
            this.habilitarControles();
            
        }

        public void habilitarControles(bool key = false)
        {
            bool estadoControles = false;
            if (key)
            {
                estadoControles = true;
            }

            txt_valor_residual.Enabled = estadoControles;
            txt_ultimo_anio.Enabled = false;
            cb_estado_depreciacion.Enabled = estadoControles;

            btn_buscar_35.Enabled = estadoControles;
            btn_rehacer_35.Enabled = estadoControles;
            btn_guardar.Enabled = estadoControles;
            btn_cancelar.Enabled = estadoControles;

        }

        private void btn_nuevo_ad_Click(object sender, EventArgs e)
        {
            tab_control_DAF.SelectedTab = tab_control_DAF.TabPages[1];
            habilitarControles(true);

            txt_fecha_registro.Text = Funciones.FechaActual();
            txt_activo_depreciar.Text = DepreciacionActivosControlador.IdDepreciacion();
            txt_registrado_por.Text = Funciones.SetUsuarioLogin();
        }

        private void btn_buscar_35_Click(object sender, EventArgs e)
        {
            FormBuscar formBuscar = new FormBuscar();
            formBuscar.DataGridView(DepreciacionActivosControlador.ListaActivosBuscar());
            formBuscar.ColumnaBuscar("[Nombre del activo]", "ID Activo");
            formBuscar.Text = "Buscar activos";
            formBuscar.ShowDialog();

            string idSeleccionado = formBuscar.IDBuscado;
            txt_id_activo.Text = idSeleccionado;
        }

        private void txt_id_activo_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txt_id_activo.Text))
            {
                string IdActivo = txt_id_activo.Text;
                this.ActivoDepreciar(IdActivo);
            }
        }

        public void ActivoDepreciar(string IdActivo)
        {
            DataTable dtActivo = new DataTable();
            if (!string.IsNullOrEmpty(IdActivo))
            {
                dtActivo = DepreciacionActivosControlador.ActivoDepreciacion(IdActivo);

                try
                {
                    txt_nombre_activo.Text = dtActivo.Rows[0]["nombre_activo"].ToString();
                    txt_id_clasificacion.Text = dtActivo.Rows[0]["id_clasificacion_ac"].ToString();
                    txt_nombre_clasificacion.Text = dtActivo.Rows[0]["nombre_clasificacion_ca"].ToString();
                    txt_anio_vida_util.Text = dtActivo.Rows[0]["anios_vida_util_ca"].ToString();
                    txt_porcentaje_anual.Text = (Convert.ToDouble(dtActivo.Rows[0]["porcentaje_anual_ca"])*100).ToString();
                    txt_valor_activo.Text = dtActivo.Rows[0]["valor_activo"].ToString();
                    txt_ubicacion_activo.Text = dtActivo.Rows[0]["nombre_ubicacion"].ToString();
                    this.IdUbicacion = dtActivo.Rows[0]["id_ubicacion_ac"].ToString();
                    txt_anio_compra.Text = dtActivo.Rows[0]["Anio_alta"].ToString();
                    txt_ultimo_anio.Text = dtActivo.Rows[0]["Ultimo_Anio"].ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Form");
                }
            }
        }

        private void btn_rehacer_35_Click(object sender, EventArgs e)
        {
            txt_id_activo.Text = string.Empty;
            txt_nombre_activo.Text = string.Empty;
            txt_id_clasificacion.Text = string.Empty;
            txt_nombre_clasificacion.Text = string.Empty;
            txt_anio_vida_util.Text = string.Empty;
            txt_porcentaje_anual.Text = string.Empty;
            txt_valor_activo.Text = string.Empty;
            txt_ubicacion_activo.Text = string.Empty;
            txt_anio_compra.Text = string.Empty;
            txt_ultimo_anio.Text = string.Empty;

            MessageBox.Show("Los campos han sido restablecidos.", "Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cb_estado_depreciacion.Text))
            {
                MessageBox.Show("Debe elegir un estado para el activo a depreciar. Revise el campo Estado de la depreciación.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                //capturar datos
                string IdDepreciacion = txt_activo_depreciar.Text;
                DateTime fechaRegistro = Convert.ToDateTime(txt_fecha_registro.Text);
                string idActivo = txt_id_activo.Text;
                string nombreActivo = txt_nombre_activo.Text;
                string idClasificacion = txt_id_clasificacion.Text;
                string nombreClasificacion = txt_nombre_clasificacion.Text;
                int vidaUtil = int.Parse(txt_anio_vida_util.Text);
                decimal porcentaje = (decimal.Parse(txt_porcentaje_anual.Text) / 100);
                decimal valorActivo = (decimal.Parse(txt_valor_activo.Text));
                decimal valorResidual = (decimal.Parse(txt_valor_residual.Text));

                string idUbicacion = this.IdUbicacion;
                string nomUbicacion = txt_ubicacion_activo.Text;
                int anioCompra = int.Parse(txt_anio_compra.Text);
                int ultimoAnio = int.Parse(txt_ultimo_anio.Text);
                string registradoPor = txt_registrado_por.Text;

                string stringEstado = cb_estado_depreciacion.Text;
                char charEstado = stringEstado[0];

                int estado = (int)char.GetNumericValue(charEstado);


                try
                {
                    DepreciacionActivosControlador.InsertarDepreciacion(IdDepreciacion, idActivo, idClasificacion, fechaRegistro, vidaUtil, porcentaje, valorActivo, valorResidual, idUbicacion, anioCompra, ultimoAnio, registradoPor, estado);

                    this.limpiarControles();
                    this.tab_control_DAF.SelectedTab = tab_control_DAF.TabPages[0];
                    this.habilitarControles();
                    this.GridViewADLoad();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Forms: " + ex.Message);
                }
            }
        }

        public void limpiarControles()
        {
            txt_fecha_registro.Text = string.Empty;
            txt_activo_depreciar.Text = string.Empty;
            txt_id_activo.Text = string.Empty;
            txt_nombre_activo.Text = string.Empty;
            txt_id_clasificacion.Text = string.Empty;
            txt_nombre_clasificacion.Text = string.Empty;
            txt_anio_vida_util.Text = string.Empty;
            txt_porcentaje_anual.Text = string.Empty;
            txt_valor_activo.Text = string.Empty;
            this.IdUbicacion = string.Empty;
            txt_ubicacion_activo.Text = string.Empty;
            txt_anio_compra.Text = string.Empty;
            txt_ultimo_anio.Text = string.Empty;
            txt_registrado_por.Text = string.Empty;
            cb_estado_depreciacion.Text = string.Empty;
        }

        private void btn_modificar_ad_Click(object sender, EventArgs e)
        {
            string idSelect = this.IdSelect;
            limpiarControles();
            if (idSelect != null)
            {
                DataTable dt = DepreciacionActivosControlador.ObtnerDepreciacionPorID(idSelect);

                if (dt.Rows.Count > 0)
                {
                    DataRow fila = dt.Rows[0];

                    habilitarControles(true);


                    txt_fecha_registro.Text = Convert.ToDateTime(fila["fecha_registro_da"]).ToString("dd-MM-yyyy");
                    txt_activo_depreciar.Text = fila["id_depreciacion_activo"].ToString();
                    txt_id_activo.Text = fila["id_activo_da"].ToString();
                    txt_registrado_por.Text = fila["usuario_registro_da"].ToString();

                    this.tab_control_DAF.SelectedTab = tab_control_DAF.TabPages[1];
                    btn_actualizar.Visible = true;
                    btn_guardar.Visible = false;

                    btn_buscar_35.Enabled = false;
                    btn_rehacer_35.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No se encontro el ID");
                }



            }
            else
            {
                MessageBox.Show("Selecciona la fila que deseas editar y vuelve a intentarlo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AD_data_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow seleccionFila = AD_data_grid.Rows[e.RowIndex];
                this.IdSelect = Convert.ToString(seleccionFila.Cells["ID Depreciación"].Value);
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            //capturar datos
            string IdDepreciacion = txt_activo_depreciar.Text;
            DateTime fechaRegistro = Convert.ToDateTime(txt_fecha_registro.Text);
            string idActivo = txt_id_activo.Text;
            string nombreActivo = txt_nombre_activo.Text;
            string idClasificacion = txt_id_clasificacion.Text;
            string nombreClasificacion = txt_nombre_clasificacion.Text;
            int vidaUtil = int.Parse(txt_anio_vida_util.Text);
            decimal porcentaje = (decimal.Parse(txt_porcentaje_anual.Text) / 100);
            decimal valorActivo = (decimal.Parse(txt_valor_activo.Text));
            decimal valorResidual = (decimal.Parse(txt_valor_residual.Text));

            string idUbicacion = this.IdUbicacion;
            string nomUbicacion = txt_ubicacion_activo.Text;
            int anioCompra = int.Parse(txt_anio_compra.Text);
            int ultimoAnio = int.Parse(txt_ultimo_anio.Text);
            string registradoPor = txt_registrado_por.Text;

            string stringEstado = cb_estado_depreciacion.Text;
            char charEstado = stringEstado[0];

            int estado = (int)char.GetNumericValue(charEstado);


            try
            {
                DepreciacionActivosControlador.ActualizarDepreciacion(IdDepreciacion, idActivo, idClasificacion, fechaRegistro, vidaUtil, porcentaje, valorActivo, valorResidual, idUbicacion, anioCompra, ultimoAnio, registradoPor, estado);

                this.limpiarControles();
                this.tab_control_DAF.SelectedTab = tab_control_DAF.TabPages[0];
                this.habilitarControles();
                this.GridViewADLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Forms: " + ex.Message);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limpiarControles();
            habilitarControles();
            this.tab_control_DAF.SelectedTab = tab_control_DAF.TabPages[0];
        }

        private void btn_eliminar_ad_Click(object sender, EventArgs e)
        {
            string idSelect = this.IdSelect;
            limpiarControles();
            if (idSelect != null)
            {
                DataTable dt = DepreciacionActivosControlador.ObtnerDepreciacionPorID(idSelect);

                if (dt.Rows.Count > 0)
                {
                    DataRow fila = dt.Rows[0];

                    habilitarControles(true);


                    txt_fecha_registro.Text = Convert.ToDateTime(fila["fecha_registro_da"]).ToString("dd-MM-yyyy");
                    txt_activo_depreciar.Text = fila["id_depreciacion_activo"].ToString();
                    txt_id_activo.Text = fila["id_activo_da"].ToString();
                    txt_registrado_por.Text = fila["usuario_registro_da"].ToString();

                    this.tab_control_DAF.SelectedTab = tab_control_DAF.TabPages[1];
                    btn_actualizar.Visible = false;
                    btn_guardar.Visible = false;

                    btn_buscar_35.Enabled = false;
                    btn_rehacer_35.Enabled = false;
                    cb_estado_depreciacion.Enabled = false;
                    txt_valor_residual.Enabled = false;

                    btn_eliminar_da.Visible = true;

                }
                else
                {
                    MessageBox.Show("No se encontro el ID");
                }



            }
            else
            {
                MessageBox.Show("Selecciona la fila que deseas editar y vuelve a intentarlo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_eliminar_da_Click(object sender, EventArgs e)
        {
            string idEliminar = this.IdSelect;
            if (idEliminar != null && idEliminar != "")
            {
                // ejecutamos el SQL Delete
                DepreciacionActivosControlador.EliminarDepreciacion(idEliminar);

                // refrescamos nuestro formulario
                this.limpiarControles();
                this.tab_control_DAF.SelectedTab = tab_control_DAF.TabPages[0];
                this.habilitarControles();
                this.GridViewADLoad();
            }

        }
    }
}
