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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Operarios));
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbCargo = new System.Windows.Forms.TextBox();
            this.cmbEstado1 = new System.Windows.Forms.ComboBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbFecha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEstado2 = new System.Windows.Forms.ComboBox();
            this.dgvOperarios = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelOperarios = new System.Windows.Forms.Label();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperarios)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(19, 61);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(79, 28);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(100, 61);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(90, 28);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(192, 61);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(82, 28);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
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
            this.gbDatos.Location = new System.Drawing.Point(18, 96);
            this.gbDatos.Margin = new System.Windows.Forms.Padding(2);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Padding = new System.Windows.Forms.Padding(2);
            this.gbDatos.Size = new System.Drawing.Size(562, 119);
            this.gbDatos.TabIndex = 3;
            this.gbDatos.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(470, 81);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 28);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(376, 81);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(71, 28);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(19, 86);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(2);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(311, 20);
            this.tbNombre.TabIndex = 9;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // tbCargo
            // 
            this.tbCargo.Location = new System.Drawing.Point(355, 36);
            this.tbCargo.Margin = new System.Windows.Forms.Padding(2);
            this.tbCargo.Name = "tbCargo";
            this.tbCargo.Size = new System.Drawing.Size(204, 20);
            this.tbCargo.TabIndex = 8;
            this.tbCargo.TextChanged += new System.EventHandler(this.tbCargo_TextChanged);
            // 
            // cmbEstado1
            // 
            this.cmbEstado1.FormattingEnabled = true;
            this.cmbEstado1.Location = new System.Drawing.Point(236, 36);
            this.cmbEstado1.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEstado1.Name = "cmbEstado1";
            this.cmbEstado1.Size = new System.Drawing.Size(92, 21);
            this.cmbEstado1.TabIndex = 7;
            this.cmbEstado1.SelectedIndexChanged += new System.EventHandler(this.cmbEstado1_SelectedIndexChanged);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(130, 36);
            this.tbID.Margin = new System.Windows.Forms.Padding(2);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(76, 20);
            this.tbID.TabIndex = 6;
            this.tbID.TextChanged += new System.EventHandler(this.tbID_TextChanged);
            // 
            // tbFecha
            // 
            this.tbFecha.Location = new System.Drawing.Point(19, 36);
            this.tbFecha.Margin = new System.Windows.Forms.Padding(2);
            this.tbFecha.Name = "tbFecha";
            this.tbFecha.Size = new System.Drawing.Size(85, 20);
            this.tbFecha.TabIndex = 5;
            this.tbFecha.TextChanged += new System.EventHandler(this.tbFecha_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre del operario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cargo del operario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID de operario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha de registro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 227);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Filtrar por estado:";
            // 
            // cmbEstado2
            // 
            this.cmbEstado2.FormattingEnabled = true;
            this.cmbEstado2.Location = new System.Drawing.Point(106, 223);
            this.cmbEstado2.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEstado2.Name = "cmbEstado2";
            this.cmbEstado2.Size = new System.Drawing.Size(92, 21);
            this.cmbEstado2.TabIndex = 6;
            this.cmbEstado2.SelectedIndexChanged += new System.EventHandler(this.cmbEstado2_SelectedIndexChanged);
            // 
            // dgvOperarios
            // 
            this.dgvOperarios.AllowUserToOrderColumns = true;
            this.dgvOperarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperarios.Location = new System.Drawing.Point(19, 252);
            this.dgvOperarios.Margin = new System.Windows.Forms.Padding(2);
            this.dgvOperarios.Name = "dgvOperarios";
            this.dgvOperarios.RowHeadersWidth = 51;
            this.dgvOperarios.RowTemplate.Height = 24;
            this.dgvOperarios.Size = new System.Drawing.Size(562, 151);
            this.dgvOperarios.TabIndex = 7;
            this.dgvOperarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOperarios_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.LabelOperarios);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 56);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // LabelOperarios
            // 
            this.LabelOperarios.AutoSize = true;
            this.LabelOperarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOperarios.ForeColor = System.Drawing.Color.Transparent;
            this.LabelOperarios.Location = new System.Drawing.Point(47, 18);
            this.LabelOperarios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelOperarios.Name = "LabelOperarios";
            this.LabelOperarios.Size = new System.Drawing.Size(87, 20);
            this.LabelOperarios.TabIndex = 0;
            this.LabelOperarios.Text = "Operarios";
            // 
            // Operarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 413);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvOperarios);
            this.Controls.Add(this.cmbEstado2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Operarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operarios";
            this.Load += new System.EventHandler(this.Operarios_Load);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox gbDatos;
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
        private System.Windows.Forms.DataGridView dgvOperarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelOperarios;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}