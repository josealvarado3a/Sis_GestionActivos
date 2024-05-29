namespace Sis_GestionActivos.Vistas
{
    partial class FormDepreciacionActivos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDepreciacionActivos));
            this.panel_top = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_control_DAF = new System.Windows.Forms.TabControl();
            this.page_activos_depreciados = new System.Windows.Forms.TabPage();
            this.panel_botones_AD = new System.Windows.Forms.Panel();
            this.btn_eliminar_ad = new System.Windows.Forms.Button();
            this.btn_modificar_ad = new System.Windows.Forms.Button();
            this.btn_nuevo_ad = new System.Windows.Forms.Button();
            this.AD_data_grid = new System.Windows.Forms.DataGridView();
            this.page_registro_DAF = new System.Windows.Forms.TabPage();
            this.txt_valor_residual = new System.Windows.Forms.NumericUpDown();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.cb_estado_depreciacion = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_registrado_por = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_ultimo_anio = new System.Windows.Forms.TextBox();
            this.txt_anio_compra = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_ubicacion_activo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_valor_activo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_porcentaje_anual = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_anio_vida_util = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_nombre_clasificacion = new System.Windows.Forms.TextBox();
            this.txt_id_clasificacion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nombre_activo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_rehacer_35 = new System.Windows.Forms.Button();
            this.btn_buscar_35 = new System.Windows.Forms.Button();
            this.txt_id_activo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_activo_depreciar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_fecha_registro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.page_tarjeta_depreciacion = new System.Windows.Forms.TabPage();
            this.td_data_grid = new System.Windows.Forms.DataGridView();
            this.td_anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.td_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.td_depreciacion_anual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.td_depreciacion_acumulada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.td_valor_libros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_limpiar_td = new System.Windows.Forms.Button();
            this.btn_generar_pdf_td = new System.Windows.Forms.Button();
            this.btn_calcular_td = new System.Windows.Forms.Button();
            this.btn_rehacer_td = new System.Windows.Forms.Button();
            this.txt_activo_td = new System.Windows.Forms.TextBox();
            this.btn_buscar_td = new System.Windows.Forms.Button();
            this.txt_codigo_td = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_eliminar_da = new System.Windows.Forms.Button();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tab_control_DAF.SuspendLayout();
            this.page_activos_depreciados.SuspendLayout();
            this.panel_botones_AD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AD_data_grid)).BeginInit();
            this.page_registro_DAF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_valor_residual)).BeginInit();
            this.page_tarjeta_depreciacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.td_data_grid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(82)))), ((int)(((byte)(179)))));
            this.panel_top.Controls.Add(this.pictureBox1);
            this.panel_top.Controls.Add(this.label1);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(984, 50);
            this.panel_top.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(57, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Depreciación de Activos Fijos";
            // 
            // tab_control_DAF
            // 
            this.tab_control_DAF.Controls.Add(this.page_activos_depreciados);
            this.tab_control_DAF.Controls.Add(this.page_registro_DAF);
            this.tab_control_DAF.Controls.Add(this.page_tarjeta_depreciacion);
            this.tab_control_DAF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_control_DAF.Location = new System.Drawing.Point(0, 50);
            this.tab_control_DAF.Name = "tab_control_DAF";
            this.tab_control_DAF.SelectedIndex = 0;
            this.tab_control_DAF.Size = new System.Drawing.Size(984, 511);
            this.tab_control_DAF.TabIndex = 1;
            // 
            // page_activos_depreciados
            // 
            this.page_activos_depreciados.Controls.Add(this.panel_botones_AD);
            this.page_activos_depreciados.Controls.Add(this.AD_data_grid);
            this.page_activos_depreciados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page_activos_depreciados.Location = new System.Drawing.Point(4, 22);
            this.page_activos_depreciados.Name = "page_activos_depreciados";
            this.page_activos_depreciados.Padding = new System.Windows.Forms.Padding(3);
            this.page_activos_depreciados.Size = new System.Drawing.Size(976, 485);
            this.page_activos_depreciados.TabIndex = 0;
            this.page_activos_depreciados.Text = "Activos depreciados";
            this.page_activos_depreciados.UseVisualStyleBackColor = true;
            // 
            // panel_botones_AD
            // 
            this.panel_botones_AD.Controls.Add(this.btn_eliminar_ad);
            this.panel_botones_AD.Controls.Add(this.btn_modificar_ad);
            this.panel_botones_AD.Controls.Add(this.btn_nuevo_ad);
            this.panel_botones_AD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_botones_AD.Location = new System.Drawing.Point(3, 3);
            this.panel_botones_AD.Name = "panel_botones_AD";
            this.panel_botones_AD.Size = new System.Drawing.Size(970, 35);
            this.panel_botones_AD.TabIndex = 2;
            // 
            // btn_eliminar_ad
            // 
            this.btn_eliminar_ad.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar_ad.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar_ad.Image")));
            this.btn_eliminar_ad.Location = new System.Drawing.Point(191, 5);
            this.btn_eliminar_ad.Name = "btn_eliminar_ad";
            this.btn_eliminar_ad.Size = new System.Drawing.Size(90, 27);
            this.btn_eliminar_ad.TabIndex = 3;
            this.btn_eliminar_ad.Text = "Eliminar";
            this.btn_eliminar_ad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_eliminar_ad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_eliminar_ad.UseVisualStyleBackColor = true;
            this.btn_eliminar_ad.Click += new System.EventHandler(this.btn_eliminar_ad_Click);
            // 
            // btn_modificar_ad
            // 
            this.btn_modificar_ad.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar_ad.Image = ((System.Drawing.Image)(resources.GetObject("btn_modificar_ad.Image")));
            this.btn_modificar_ad.Location = new System.Drawing.Point(95, 5);
            this.btn_modificar_ad.Name = "btn_modificar_ad";
            this.btn_modificar_ad.Size = new System.Drawing.Size(90, 27);
            this.btn_modificar_ad.TabIndex = 2;
            this.btn_modificar_ad.Text = "Modificar";
            this.btn_modificar_ad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_modificar_ad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_modificar_ad.UseVisualStyleBackColor = true;
            this.btn_modificar_ad.Click += new System.EventHandler(this.btn_modificar_ad_Click);
            // 
            // btn_nuevo_ad
            // 
            this.btn_nuevo_ad.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo_ad.Image = ((System.Drawing.Image)(resources.GetObject("btn_nuevo_ad.Image")));
            this.btn_nuevo_ad.Location = new System.Drawing.Point(5, 5);
            this.btn_nuevo_ad.Name = "btn_nuevo_ad";
            this.btn_nuevo_ad.Size = new System.Drawing.Size(84, 27);
            this.btn_nuevo_ad.TabIndex = 1;
            this.btn_nuevo_ad.Text = "Nuevo";
            this.btn_nuevo_ad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_nuevo_ad.UseVisualStyleBackColor = true;
            this.btn_nuevo_ad.Click += new System.EventHandler(this.btn_nuevo_ad_Click);
            // 
            // AD_data_grid
            // 
            this.AD_data_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AD_data_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AD_data_grid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.AD_data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AD_data_grid.Location = new System.Drawing.Point(3, 41);
            this.AD_data_grid.Name = "AD_data_grid";
            this.AD_data_grid.ReadOnly = true;
            this.AD_data_grid.RowTemplate.Height = 15;
            this.AD_data_grid.Size = new System.Drawing.Size(970, 441);
            this.AD_data_grid.TabIndex = 1;
            this.AD_data_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AD_data_grid_CellClick);
            // 
            // page_registro_DAF
            // 
            this.page_registro_DAF.Controls.Add(this.btn_eliminar_da);
            this.page_registro_DAF.Controls.Add(this.btn_actualizar);
            this.page_registro_DAF.Controls.Add(this.txt_valor_residual);
            this.page_registro_DAF.Controls.Add(this.btn_cancelar);
            this.page_registro_DAF.Controls.Add(this.btn_guardar);
            this.page_registro_DAF.Controls.Add(this.cb_estado_depreciacion);
            this.page_registro_DAF.Controls.Add(this.label15);
            this.page_registro_DAF.Controls.Add(this.txt_registrado_por);
            this.page_registro_DAF.Controls.Add(this.label14);
            this.page_registro_DAF.Controls.Add(this.txt_ultimo_anio);
            this.page_registro_DAF.Controls.Add(this.txt_anio_compra);
            this.page_registro_DAF.Controls.Add(this.label13);
            this.page_registro_DAF.Controls.Add(this.label12);
            this.page_registro_DAF.Controls.Add(this.txt_ubicacion_activo);
            this.page_registro_DAF.Controls.Add(this.label11);
            this.page_registro_DAF.Controls.Add(this.label10);
            this.page_registro_DAF.Controls.Add(this.txt_valor_activo);
            this.page_registro_DAF.Controls.Add(this.label9);
            this.page_registro_DAF.Controls.Add(this.txt_porcentaje_anual);
            this.page_registro_DAF.Controls.Add(this.label8);
            this.page_registro_DAF.Controls.Add(this.txt_anio_vida_util);
            this.page_registro_DAF.Controls.Add(this.label7);
            this.page_registro_DAF.Controls.Add(this.txt_nombre_clasificacion);
            this.page_registro_DAF.Controls.Add(this.txt_id_clasificacion);
            this.page_registro_DAF.Controls.Add(this.label6);
            this.page_registro_DAF.Controls.Add(this.txt_nombre_activo);
            this.page_registro_DAF.Controls.Add(this.label5);
            this.page_registro_DAF.Controls.Add(this.btn_rehacer_35);
            this.page_registro_DAF.Controls.Add(this.btn_buscar_35);
            this.page_registro_DAF.Controls.Add(this.txt_id_activo);
            this.page_registro_DAF.Controls.Add(this.label4);
            this.page_registro_DAF.Controls.Add(this.txt_activo_depreciar);
            this.page_registro_DAF.Controls.Add(this.label3);
            this.page_registro_DAF.Controls.Add(this.txt_fecha_registro);
            this.page_registro_DAF.Controls.Add(this.label2);
            this.page_registro_DAF.Location = new System.Drawing.Point(4, 22);
            this.page_registro_DAF.Name = "page_registro_DAF";
            this.page_registro_DAF.Padding = new System.Windows.Forms.Padding(3);
            this.page_registro_DAF.Size = new System.Drawing.Size(976, 485);
            this.page_registro_DAF.TabIndex = 1;
            this.page_registro_DAF.Text = "Registro";
            this.page_registro_DAF.UseVisualStyleBackColor = true;
            // 
            // txt_valor_residual
            // 
            this.txt_valor_residual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_valor_residual.DecimalPlaces = 2;
            this.txt_valor_residual.Location = new System.Drawing.Point(52, 180);
            this.txt_valor_residual.Name = "txt_valor_residual";
            this.txt_valor_residual.Size = new System.Drawing.Size(120, 20);
            this.txt_valor_residual.TabIndex = 40;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.AutoSize = true;
            this.btn_cancelar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(480, 246);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(87, 27);
            this.btn_cancelar.TabIndex = 38;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(82)))), ((int)(((byte)(179)))));
            this.btn_guardar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.Location = new System.Drawing.Point(382, 243);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(92, 30);
            this.btn_guardar.TabIndex = 37;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // cb_estado_depreciacion
            // 
            this.cb_estado_depreciacion.FormattingEnabled = true;
            this.cb_estado_depreciacion.Items.AddRange(new object[] {
            "1. Activo",
            "2. Depreciado"});
            this.cb_estado_depreciacion.Location = new System.Drawing.Point(211, 252);
            this.cb_estado_depreciacion.Name = "cb_estado_depreciacion";
            this.cb_estado_depreciacion.Size = new System.Drawing.Size(120, 21);
            this.cb_estado_depreciacion.TabIndex = 36;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(208, 228);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(133, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "Estado de la depreciación:";
            // 
            // txt_registrado_por
            // 
            this.txt_registrado_por.Enabled = false;
            this.txt_registrado_por.Location = new System.Drawing.Point(52, 253);
            this.txt_registrado_por.Name = "txt_registrado_por";
            this.txt_registrado_por.Size = new System.Drawing.Size(100, 20);
            this.txt_registrado_por.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(49, 228);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Registrado por:";
            // 
            // txt_ultimo_anio
            // 
            this.txt_ultimo_anio.Location = new System.Drawing.Point(819, 180);
            this.txt_ultimo_anio.Name = "txt_ultimo_anio";
            this.txt_ultimo_anio.Size = new System.Drawing.Size(100, 20);
            this.txt_ultimo_anio.TabIndex = 32;
            // 
            // txt_anio_compra
            // 
            this.txt_anio_compra.Enabled = false;
            this.txt_anio_compra.Location = new System.Drawing.Point(654, 180);
            this.txt_anio_compra.Name = "txt_anio_compra";
            this.txt_anio_compra.Size = new System.Drawing.Size(100, 20);
            this.txt_anio_compra.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(816, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Ultimo año de vida útil:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(651, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Año de compra:";
            // 
            // txt_ubicacion_activo
            // 
            this.txt_ubicacion_activo.Enabled = false;
            this.txt_ubicacion_activo.Location = new System.Drawing.Point(211, 180);
            this.txt_ubicacion_activo.Name = "txt_ubicacion_activo";
            this.txt_ubicacion_activo.Size = new System.Drawing.Size(383, 20);
            this.txt_ubicacion_activo.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(208, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Ubicación del activo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Valor residual:";
            // 
            // txt_valor_activo
            // 
            this.txt_valor_activo.Enabled = false;
            this.txt_valor_activo.Location = new System.Drawing.Point(819, 111);
            this.txt_valor_activo.Name = "txt_valor_activo";
            this.txt_valor_activo.Size = new System.Drawing.Size(100, 20);
            this.txt_valor_activo.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(816, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Valor del activo:";
            // 
            // txt_porcentaje_anual
            // 
            this.txt_porcentaje_anual.Enabled = false;
            this.txt_porcentaje_anual.Location = new System.Drawing.Point(654, 111);
            this.txt_porcentaje_anual.Name = "txt_porcentaje_anual";
            this.txt_porcentaje_anual.Size = new System.Drawing.Size(100, 20);
            this.txt_porcentaje_anual.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(651, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Procentaje anual:";
            // 
            // txt_anio_vida_util
            // 
            this.txt_anio_vida_util.Enabled = false;
            this.txt_anio_vida_util.Location = new System.Drawing.Point(494, 111);
            this.txt_anio_vida_util.Name = "txt_anio_vida_util";
            this.txt_anio_vida_util.Size = new System.Drawing.Size(100, 20);
            this.txt_anio_vida_util.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(491, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Años de vida útil:";
            // 
            // txt_nombre_clasificacion
            // 
            this.txt_nombre_clasificacion.Enabled = false;
            this.txt_nombre_clasificacion.Location = new System.Drawing.Point(167, 111);
            this.txt_nombre_clasificacion.Name = "txt_nombre_clasificacion";
            this.txt_nombre_clasificacion.Size = new System.Drawing.Size(249, 20);
            this.txt_nombre_clasificacion.TabIndex = 17;
            // 
            // txt_id_clasificacion
            // 
            this.txt_id_clasificacion.Enabled = false;
            this.txt_id_clasificacion.Location = new System.Drawing.Point(52, 111);
            this.txt_id_clasificacion.Name = "txt_id_clasificacion";
            this.txt_id_clasificacion.Size = new System.Drawing.Size(100, 20);
            this.txt_id_clasificacion.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Clasifiación del Activo:";
            // 
            // txt_nombre_activo
            // 
            this.txt_nombre_activo.Enabled = false;
            this.txt_nombre_activo.Location = new System.Drawing.Point(602, 42);
            this.txt_nombre_activo.Name = "txt_nombre_activo";
            this.txt_nombre_activo.Size = new System.Drawing.Size(328, 20);
            this.txt_nombre_activo.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(599, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "ID Activo:";
            // 
            // btn_rehacer_35
            // 
            this.btn_rehacer_35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(82)))), ((int)(((byte)(179)))));
            this.btn_rehacer_35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rehacer_35.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_rehacer_35.Image = ((System.Drawing.Image)(resources.GetObject("btn_rehacer_35.Image")));
            this.btn_rehacer_35.Location = new System.Drawing.Point(535, 27);
            this.btn_rehacer_35.Name = "btn_rehacer_35";
            this.btn_rehacer_35.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_rehacer_35.Size = new System.Drawing.Size(35, 35);
            this.btn_rehacer_35.TabIndex = 12;
            this.btn_rehacer_35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_rehacer_35.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_rehacer_35.UseVisualStyleBackColor = false;
            this.btn_rehacer_35.Click += new System.EventHandler(this.btn_rehacer_35_Click);
            // 
            // btn_buscar_35
            // 
            this.btn_buscar_35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(82)))), ((int)(((byte)(179)))));
            this.btn_buscar_35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar_35.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_buscar_35.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar_35.Image")));
            this.btn_buscar_35.Location = new System.Drawing.Point(494, 27);
            this.btn_buscar_35.Name = "btn_buscar_35";
            this.btn_buscar_35.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_buscar_35.Size = new System.Drawing.Size(35, 35);
            this.btn_buscar_35.TabIndex = 11;
            this.btn_buscar_35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_buscar_35.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_buscar_35.UseVisualStyleBackColor = false;
            this.btn_buscar_35.Click += new System.EventHandler(this.btn_buscar_35_Click);
            // 
            // txt_id_activo
            // 
            this.txt_id_activo.Enabled = false;
            this.txt_id_activo.Location = new System.Drawing.Point(365, 42);
            this.txt_id_activo.Name = "txt_id_activo";
            this.txt_id_activo.Size = new System.Drawing.Size(100, 20);
            this.txt_id_activo.TabIndex = 5;
            this.txt_id_activo.TextChanged += new System.EventHandler(this.txt_id_activo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "ID Activo:";
            // 
            // txt_activo_depreciar
            // 
            this.txt_activo_depreciar.Enabled = false;
            this.txt_activo_depreciar.Location = new System.Drawing.Point(211, 42);
            this.txt_activo_depreciar.Name = "txt_activo_depreciar";
            this.txt_activo_depreciar.Size = new System.Drawing.Size(100, 20);
            this.txt_activo_depreciar.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID Depreciación:";
            // 
            // txt_fecha_registro
            // 
            this.txt_fecha_registro.Enabled = false;
            this.txt_fecha_registro.Location = new System.Drawing.Point(52, 42);
            this.txt_fecha_registro.Name = "txt_fecha_registro";
            this.txt_fecha_registro.Size = new System.Drawing.Size(100, 20);
            this.txt_fecha_registro.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha de Registro:";
            // 
            // page_tarjeta_depreciacion
            // 
            this.page_tarjeta_depreciacion.Controls.Add(this.td_data_grid);
            this.page_tarjeta_depreciacion.Controls.Add(this.panel1);
            this.page_tarjeta_depreciacion.Location = new System.Drawing.Point(4, 22);
            this.page_tarjeta_depreciacion.Name = "page_tarjeta_depreciacion";
            this.page_tarjeta_depreciacion.Padding = new System.Windows.Forms.Padding(3);
            this.page_tarjeta_depreciacion.Size = new System.Drawing.Size(976, 485);
            this.page_tarjeta_depreciacion.TabIndex = 2;
            this.page_tarjeta_depreciacion.Text = "Tarjeta de depreciación";
            this.page_tarjeta_depreciacion.UseVisualStyleBackColor = true;
            // 
            // td_data_grid
            // 
            this.td_data_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.td_data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.td_data_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.td_anio,
            this.td_descripcion,
            this.td_depreciacion_anual,
            this.td_depreciacion_acumulada,
            this.td_valor_libros});
            this.td_data_grid.Location = new System.Drawing.Point(3, 71);
            this.td_data_grid.Name = "td_data_grid";
            this.td_data_grid.Size = new System.Drawing.Size(970, 411);
            this.td_data_grid.TabIndex = 1;
            // 
            // td_anio
            // 
            this.td_anio.HeaderText = "Años";
            this.td_anio.Name = "td_anio";
            // 
            // td_descripcion
            // 
            this.td_descripcion.HeaderText = "Descripción";
            this.td_descripcion.Name = "td_descripcion";
            // 
            // td_depreciacion_anual
            // 
            this.td_depreciacion_anual.HeaderText = "Depreciación Anual";
            this.td_depreciacion_anual.Name = "td_depreciacion_anual";
            // 
            // td_depreciacion_acumulada
            // 
            this.td_depreciacion_acumulada.HeaderText = "Depreciación Acumulada";
            this.td_depreciacion_acumulada.Name = "td_depreciacion_acumulada";
            // 
            // td_valor_libros
            // 
            this.td_valor_libros.HeaderText = "Valor en libros";
            this.td_valor_libros.Name = "td_valor_libros";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_limpiar_td);
            this.panel1.Controls.Add(this.btn_generar_pdf_td);
            this.panel1.Controls.Add(this.btn_calcular_td);
            this.panel1.Controls.Add(this.btn_rehacer_td);
            this.panel1.Controls.Add(this.txt_activo_td);
            this.panel1.Controls.Add(this.btn_buscar_td);
            this.panel1.Controls.Add(this.txt_codigo_td);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 67);
            this.panel1.TabIndex = 0;
            // 
            // btn_limpiar_td
            // 
            this.btn_limpiar_td.AutoSize = true;
            this.btn_limpiar_td.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar_td.Image = ((System.Drawing.Image)(resources.GetObject("btn_limpiar_td.Image")));
            this.btn_limpiar_td.Location = new System.Drawing.Point(5, 35);
            this.btn_limpiar_td.Name = "btn_limpiar_td";
            this.btn_limpiar_td.Size = new System.Drawing.Size(92, 27);
            this.btn_limpiar_td.TabIndex = 47;
            this.btn_limpiar_td.Text = "Limpiar";
            this.btn_limpiar_td.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_limpiar_td.UseVisualStyleBackColor = true;
            // 
            // btn_generar_pdf_td
            // 
            this.btn_generar_pdf_td.AutoSize = true;
            this.btn_generar_pdf_td.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generar_pdf_td.Image = ((System.Drawing.Image)(resources.GetObject("btn_generar_pdf_td.Image")));
            this.btn_generar_pdf_td.Location = new System.Drawing.Point(103, 4);
            this.btn_generar_pdf_td.Name = "btn_generar_pdf_td";
            this.btn_generar_pdf_td.Size = new System.Drawing.Size(109, 27);
            this.btn_generar_pdf_td.TabIndex = 44;
            this.btn_generar_pdf_td.Text = "Generar PDF";
            this.btn_generar_pdf_td.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_generar_pdf_td.UseVisualStyleBackColor = true;
            // 
            // btn_calcular_td
            // 
            this.btn_calcular_td.AutoSize = true;
            this.btn_calcular_td.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(82)))), ((int)(((byte)(179)))));
            this.btn_calcular_td.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular_td.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_calcular_td.Image = ((System.Drawing.Image)(resources.GetObject("btn_calcular_td.Image")));
            this.btn_calcular_td.Location = new System.Drawing.Point(5, 3);
            this.btn_calcular_td.Name = "btn_calcular_td";
            this.btn_calcular_td.Size = new System.Drawing.Size(92, 30);
            this.btn_calcular_td.TabIndex = 43;
            this.btn_calcular_td.Text = "Calcular";
            this.btn_calcular_td.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_calcular_td.UseVisualStyleBackColor = false;
            // 
            // btn_rehacer_td
            // 
            this.btn_rehacer_td.AutoSize = true;
            this.btn_rehacer_td.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(82)))), ((int)(((byte)(179)))));
            this.btn_rehacer_td.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rehacer_td.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_rehacer_td.Image = ((System.Drawing.Image)(resources.GetObject("btn_rehacer_td.Image")));
            this.btn_rehacer_td.Location = new System.Drawing.Point(571, 3);
            this.btn_rehacer_td.Name = "btn_rehacer_td";
            this.btn_rehacer_td.Size = new System.Drawing.Size(30, 30);
            this.btn_rehacer_td.TabIndex = 42;
            this.btn_rehacer_td.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_rehacer_td.UseVisualStyleBackColor = false;
            // 
            // txt_activo_td
            // 
            this.txt_activo_td.Enabled = false;
            this.txt_activo_td.Location = new System.Drawing.Point(607, 9);
            this.txt_activo_td.Name = "txt_activo_td";
            this.txt_activo_td.Size = new System.Drawing.Size(354, 20);
            this.txt_activo_td.TabIndex = 40;
            // 
            // btn_buscar_td
            // 
            this.btn_buscar_td.AutoSize = true;
            this.btn_buscar_td.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(82)))), ((int)(((byte)(179)))));
            this.btn_buscar_td.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar_td.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_buscar_td.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar_td.Image")));
            this.btn_buscar_td.Location = new System.Drawing.Point(535, 3);
            this.btn_buscar_td.Name = "btn_buscar_td";
            this.btn_buscar_td.Size = new System.Drawing.Size(30, 30);
            this.btn_buscar_td.TabIndex = 39;
            this.btn_buscar_td.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_buscar_td.UseVisualStyleBackColor = false;
            this.btn_buscar_td.Click += new System.EventHandler(this.btn_buscar_td_Click);
            // 
            // txt_codigo_td
            // 
            this.txt_codigo_td.Enabled = false;
            this.txt_codigo_td.Location = new System.Drawing.Point(425, 8);
            this.txt_codigo_td.Name = "txt_codigo_td";
            this.txt_codigo_td.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo_td.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(215, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(204, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Selecciona el activo que deseas calcular:";
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(382, 246);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_actualizar.TabIndex = 41;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Visible = false;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_eliminar_da
            // 
            this.btn_eliminar_da.AutoSize = true;
            this.btn_eliminar_da.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar_da.Location = new System.Drawing.Point(387, 246);
            this.btn_eliminar_da.Name = "btn_eliminar_da";
            this.btn_eliminar_da.Size = new System.Drawing.Size(87, 27);
            this.btn_eliminar_da.TabIndex = 42;
            this.btn_eliminar_da.Text = "Eliminar";
            this.btn_eliminar_da.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_eliminar_da.UseVisualStyleBackColor = true;
            this.btn_eliminar_da.Click += new System.EventHandler(this.btn_eliminar_da_Click);
            // 
            // FormDepreciacionActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tab_control_DAF);
            this.Controls.Add(this.panel_top);
            this.Name = "FormDepreciacionActivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depreciación de activos";
            this.Load += new System.EventHandler(this.FormDepreciacionActivos_Load);
            this.Resize += new System.EventHandler(this.FormDepreciacionActivos_Resize);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tab_control_DAF.ResumeLayout(false);
            this.page_activos_depreciados.ResumeLayout(false);
            this.panel_botones_AD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AD_data_grid)).EndInit();
            this.page_registro_DAF.ResumeLayout(false);
            this.page_registro_DAF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_valor_residual)).EndInit();
            this.page_tarjeta_depreciacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.td_data_grid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tab_control_DAF;
        private System.Windows.Forms.TabPage page_activos_depreciados;
        private System.Windows.Forms.TabPage page_registro_DAF;
        private System.Windows.Forms.TabPage page_tarjeta_depreciacion;
        private System.Windows.Forms.Panel panel_botones_AD;
        private System.Windows.Forms.DataGridView AD_data_grid;
        private System.Windows.Forms.Button btn_nuevo_ad;
        private System.Windows.Forms.Button btn_modificar_ad;
        private System.Windows.Forms.Button btn_eliminar_ad;
        private System.Windows.Forms.TextBox txt_id_activo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_activo_depreciar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_fecha_registro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_buscar_35;
        private System.Windows.Forms.TextBox txt_nombre_activo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_rehacer_35;
        private System.Windows.Forms.TextBox txt_nombre_clasificacion;
        private System.Windows.Forms.TextBox txt_id_clasificacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_valor_activo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_porcentaje_anual;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_anio_vida_util;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ubicacion_activo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_estado_depreciacion;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_registrado_por;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_ultimo_anio;
        private System.Windows.Forms.TextBox txt_anio_compra;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_rehacer_td;
        private System.Windows.Forms.TextBox txt_activo_td;
        private System.Windows.Forms.Button btn_buscar_td;
        private System.Windows.Forms.TextBox txt_codigo_td;
        private System.Windows.Forms.Button btn_limpiar_td;
        private System.Windows.Forms.Button btn_generar_pdf_td;
        private System.Windows.Forms.Button btn_calcular_td;
        private System.Windows.Forms.DataGridView td_data_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn td_anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn td_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn td_depreciacion_anual;
        private System.Windows.Forms.DataGridViewTextBoxColumn td_depreciacion_acumulada;
        private System.Windows.Forms.DataGridViewTextBoxColumn td_valor_libros;
        private System.Windows.Forms.NumericUpDown txt_valor_residual;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_eliminar_da;
    }
}