namespace Sis_GestionActivos.Vistas
{
    partial class Operarios
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
            this.components = new System.ComponentModel.Container();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dBControlActivosDataSet = new Sis_GestionActivos.DBControlActivosDataSet();
            this.tboperariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_operariosTableAdapter = new Sis_GestionActivos.DBControlActivosDataSetTableAdapters.tb_operariosTableAdapter();
            this.idoperarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecharegistroopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreoperarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargooperarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadooperarioDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEstado2 = new System.Windows.Forms.ComboBox();
            this.tbFecha = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.cmbEstado1 = new System.Windows.Forms.ComboBox();
            this.tbCargo = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBControlActivosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboperariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::Sis_GestionActivos.Properties.Resources.icons8_añadir_24;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(25, 31);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(85, 35);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::Sis_GestionActivos.Properties.Resources.icons8_modificar_20;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(133, 31);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 35);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::Sis_GestionActivos.Properties.Resources.icons8_borrar_20;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(256, 31);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 35);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.btnCancelar);
            this.gbDatos.Controls.Add(this.btnGuardar);
            this.gbDatos.Controls.Add(this.tbNombre);
            this.gbDatos.Controls.Add(this.tbCargo);
            this.gbDatos.Controls.Add(this.cmbEstado1);
            this.gbDatos.Controls.Add(this.tbID);
            this.gbDatos.Controls.Add(this.tbFecha);
            this.gbDatos.Controls.Add(this.label5);
            this.gbDatos.Controls.Add(this.label4);
            this.gbDatos.Controls.Add(this.label3);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Location = new System.Drawing.Point(24, 74);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(750, 147);
            this.gbDatos.TabIndex = 3;
            this.gbDatos.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idoperarioDataGridViewTextBoxColumn,
            this.fecharegistroopDataGridViewTextBoxColumn,
            this.nombreoperarioDataGridViewTextBoxColumn,
            this.cargooperarioDataGridViewTextBoxColumn,
            this.estadooperarioDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tboperariosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(750, 140);
            this.dataGridView1.TabIndex = 4;
            // 
            // dBControlActivosDataSet
            // 
            this.dBControlActivosDataSet.DataSetName = "DBControlActivosDataSet";
            this.dBControlActivosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tboperariosBindingSource
            // 
            this.tboperariosBindingSource.DataMember = "tb_operarios";
            this.tboperariosBindingSource.DataSource = this.dBControlActivosDataSet;
            // 
            // tb_operariosTableAdapter
            // 
            this.tb_operariosTableAdapter.ClearBeforeFill = true;
            // 
            // idoperarioDataGridViewTextBoxColumn
            // 
            this.idoperarioDataGridViewTextBoxColumn.DataPropertyName = "id_operario";
            this.idoperarioDataGridViewTextBoxColumn.HeaderText = "id_operario";
            this.idoperarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idoperarioDataGridViewTextBoxColumn.Name = "idoperarioDataGridViewTextBoxColumn";
            this.idoperarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // fecharegistroopDataGridViewTextBoxColumn
            // 
            this.fecharegistroopDataGridViewTextBoxColumn.DataPropertyName = "fecha_registro_op";
            this.fecharegistroopDataGridViewTextBoxColumn.HeaderText = "fecha_registro_op";
            this.fecharegistroopDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fecharegistroopDataGridViewTextBoxColumn.Name = "fecharegistroopDataGridViewTextBoxColumn";
            this.fecharegistroopDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreoperarioDataGridViewTextBoxColumn
            // 
            this.nombreoperarioDataGridViewTextBoxColumn.DataPropertyName = "nombre_operario";
            this.nombreoperarioDataGridViewTextBoxColumn.HeaderText = "nombre_operario";
            this.nombreoperarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreoperarioDataGridViewTextBoxColumn.Name = "nombreoperarioDataGridViewTextBoxColumn";
            this.nombreoperarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // cargooperarioDataGridViewTextBoxColumn
            // 
            this.cargooperarioDataGridViewTextBoxColumn.DataPropertyName = "cargo_operario";
            this.cargooperarioDataGridViewTextBoxColumn.HeaderText = "cargo_operario";
            this.cargooperarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cargooperarioDataGridViewTextBoxColumn.Name = "cargooperarioDataGridViewTextBoxColumn";
            this.cargooperarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // estadooperarioDataGridViewCheckBoxColumn
            // 
            this.estadooperarioDataGridViewCheckBoxColumn.DataPropertyName = "estado_operario";
            this.estadooperarioDataGridViewCheckBoxColumn.HeaderText = "estado_operario";
            this.estadooperarioDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.estadooperarioDataGridViewCheckBoxColumn.Name = "estadooperarioDataGridViewCheckBoxColumn";
            this.estadooperarioDataGridViewCheckBoxColumn.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha de registro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID de operario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cargo del operario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre del operario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Filtrar por estado:";
            // 
            // cmbEstado2
            // 
            this.cmbEstado2.FormattingEnabled = true;
            this.cmbEstado2.Location = new System.Drawing.Point(142, 233);
            this.cmbEstado2.Name = "cmbEstado2";
            this.cmbEstado2.Size = new System.Drawing.Size(121, 24);
            this.cmbEstado2.TabIndex = 6;
            // 
            // tbFecha
            // 
            this.tbFecha.Location = new System.Drawing.Point(25, 44);
            this.tbFecha.Name = "tbFecha";
            this.tbFecha.Size = new System.Drawing.Size(112, 22);
            this.tbFecha.TabIndex = 5;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(174, 44);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 22);
            this.tbID.TabIndex = 6;
            // 
            // cmbEstado1
            // 
            this.cmbEstado1.FormattingEnabled = true;
            this.cmbEstado1.Location = new System.Drawing.Point(315, 44);
            this.cmbEstado1.Name = "cmbEstado1";
            this.cmbEstado1.Size = new System.Drawing.Size(121, 24);
            this.cmbEstado1.TabIndex = 7;
            // 
            // tbCargo
            // 
            this.tbCargo.Location = new System.Drawing.Point(473, 44);
            this.tbCargo.Name = "tbCargo";
            this.tbCargo.Size = new System.Drawing.Size(271, 22);
            this.tbCargo.TabIndex = 8;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(25, 106);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(413, 22);
            this.tbNombre.TabIndex = 9;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::Sis_GestionActivos.Properties.Resources.icons8_guardar_16;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(502, 100);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 35);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::Sis_GestionActivos.Properties.Resources.icons8_cancelar_20;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(626, 100);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 35);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Operarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbEstado2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Name = "Operarios";
            this.Text = "Operarios";
            this.Load += new System.EventHandler(this.Operarios_Load);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBControlActivosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboperariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DBControlActivosDataSet dBControlActivosDataSet;
        private System.Windows.Forms.BindingSource tboperariosBindingSource;
        private DBControlActivosDataSetTableAdapters.tb_operariosTableAdapter tb_operariosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idoperarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecharegistroopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreoperarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargooperarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadooperarioDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbEstado2;
        private System.Windows.Forms.ComboBox cmbEstado1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbCargo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox tbNombre;
    }
}