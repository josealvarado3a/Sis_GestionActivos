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
            this.data_grid_activo_dp = new System.Windows.Forms.DataGridView();
            this.Id_Depreciacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_registro_depreciacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo_activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clasificacion_activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrado_por = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_activo_dp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.page_registro_DAF = new System.Windows.Forms.TabPage();
            this.page_tarjeta_depreciacion = new System.Windows.Forms.TabPage();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tab_control_DAF.SuspendLayout();
            this.page_activos_depreciados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_activo_dp)).BeginInit();
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
            this.page_activos_depreciados.Controls.Add(this.data_grid_activo_dp);
            this.page_activos_depreciados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page_activos_depreciados.Location = new System.Drawing.Point(4, 22);
            this.page_activos_depreciados.Name = "page_activos_depreciados";
            this.page_activos_depreciados.Padding = new System.Windows.Forms.Padding(3);
            this.page_activos_depreciados.Size = new System.Drawing.Size(976, 485);
            this.page_activos_depreciados.TabIndex = 0;
            this.page_activos_depreciados.Text = "Activos depreciados";
            this.page_activos_depreciados.UseVisualStyleBackColor = true;
            // 
            // data_grid_activo_dp
            // 
            this.data_grid_activo_dp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.data_grid_activo_dp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_grid_activo_dp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Depreciacion,
            this.fecha_registro_depreciacion,
            this.codigo_activo,
            this.nombre_activo,
            this.clasificacion_activo,
            this.registrado_por,
            this.estado_activo_dp});
            this.data_grid_activo_dp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_grid_activo_dp.Location = new System.Drawing.Point(3, 47);
            this.data_grid_activo_dp.Name = "data_grid_activo_dp";
            this.data_grid_activo_dp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.data_grid_activo_dp.Size = new System.Drawing.Size(970, 435);
            this.data_grid_activo_dp.TabIndex = 2;
            // 
            // Id_Depreciacion
            // 
            this.Id_Depreciacion.HeaderText = "ID Depreciación";
            this.Id_Depreciacion.Name = "Id_Depreciacion";
            this.Id_Depreciacion.Width = 148;
            // 
            // fecha_registro_depreciacion
            // 
            this.fecha_registro_depreciacion.HeaderText = "Fecha Registro";
            this.fecha_registro_depreciacion.Name = "fecha_registro_depreciacion";
            this.fecha_registro_depreciacion.Width = 143;
            // 
            // codigo_activo
            // 
            this.codigo_activo.HeaderText = "Código Activo";
            this.codigo_activo.Name = "codigo_activo";
            this.codigo_activo.Width = 131;
            // 
            // nombre_activo
            // 
            this.nombre_activo.HeaderText = "Nombre del activo";
            this.nombre_activo.Name = "nombre_activo";
            this.nombre_activo.Width = 160;
            // 
            // clasificacion_activo
            // 
            this.clasificacion_activo.HeaderText = "Clasificación";
            this.clasificacion_activo.Name = "clasificacion_activo";
            this.clasificacion_activo.Width = 122;
            // 
            // registrado_por
            // 
            this.registrado_por.HeaderText = "Registrado por";
            this.registrado_por.Name = "registrado_por";
            this.registrado_por.Width = 139;
            // 
            // estado_activo_dp
            // 
            this.estado_activo_dp.HeaderText = "Estado del activo";
            this.estado_activo_dp.Name = "estado_activo_dp";
            this.estado_activo_dp.Width = 155;
            // 
            // page_registro_DAF
            // 
            this.page_registro_DAF.Location = new System.Drawing.Point(4, 22);
            this.page_registro_DAF.Name = "page_registro_DAF";
            this.page_registro_DAF.Padding = new System.Windows.Forms.Padding(3);
            this.page_registro_DAF.Size = new System.Drawing.Size(976, 485);
            this.page_registro_DAF.TabIndex = 1;
            this.page_registro_DAF.Text = "Registro";
            this.page_registro_DAF.UseVisualStyleBackColor = true;
            // 
            // page_tarjeta_depreciacion
            // 
            this.page_tarjeta_depreciacion.Location = new System.Drawing.Point(4, 22);
            this.page_tarjeta_depreciacion.Name = "page_tarjeta_depreciacion";
            this.page_tarjeta_depreciacion.Padding = new System.Windows.Forms.Padding(3);
            this.page_tarjeta_depreciacion.Size = new System.Drawing.Size(976, 485);
            this.page_tarjeta_depreciacion.TabIndex = 2;
            this.page_tarjeta_depreciacion.Text = "Tarjeta de depreciación";
            this.page_tarjeta_depreciacion.UseVisualStyleBackColor = true;
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
            this.Resize += new System.EventHandler(this.FormDepreciacionActivos_Resize);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tab_control_DAF.ResumeLayout(false);
            this.page_activos_depreciados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_activo_dp)).EndInit();
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
        private System.Windows.Forms.DataGridView data_grid_activo_dp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Depreciacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_registro_depreciacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clasificacion_activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrado_por;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_activo_dp;
    }
}