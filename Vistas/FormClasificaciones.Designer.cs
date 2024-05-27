namespace Sis_GestionActivos.Vistas
{
    partial class FormClasificaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClasificaciones));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_control_clasificacion = new System.Windows.Forms.TabControl();
            this.page_clasificacion = new System.Windows.Forms.TabPage();
            this.page_categorias = new System.Windows.Forms.TabPage();
            this.panelEdificios = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_num_edificios = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_num_maquinaria = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_num_vehiculos = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lb_num_mobiliario = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.grid_view_clasificaciones = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tab_control_clasificacion.SuspendLayout();
            this.page_clasificacion.SuspendLayout();
            this.panelEdificios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view_clasificaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(82)))), ((int)(((byte)(179)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 50);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(57, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Clasificación de activos";
            // 
            // tab_control_clasificacion
            // 
            this.tab_control_clasificacion.Controls.Add(this.page_clasificacion);
            this.tab_control_clasificacion.Controls.Add(this.page_categorias);
            this.tab_control_clasificacion.Location = new System.Drawing.Point(0, 51);
            this.tab_control_clasificacion.Name = "tab_control_clasificacion";
            this.tab_control_clasificacion.SelectedIndex = 0;
            this.tab_control_clasificacion.Size = new System.Drawing.Size(800, 401);
            this.tab_control_clasificacion.TabIndex = 1;
            // 
            // page_clasificacion
            // 
            this.page_clasificacion.Controls.Add(this.grid_view_clasificaciones);
            this.page_clasificacion.Controls.Add(this.panel7);
            this.page_clasificacion.Controls.Add(this.panel5);
            this.page_clasificacion.Controls.Add(this.panel3);
            this.page_clasificacion.Controls.Add(this.panelEdificios);
            this.page_clasificacion.Location = new System.Drawing.Point(4, 22);
            this.page_clasificacion.Name = "page_clasificacion";
            this.page_clasificacion.Padding = new System.Windows.Forms.Padding(3);
            this.page_clasificacion.Size = new System.Drawing.Size(792, 375);
            this.page_clasificacion.TabIndex = 0;
            this.page_clasificacion.Text = "Clasificaciones";
            this.page_clasificacion.UseVisualStyleBackColor = true;
            // 
            // page_categorias
            // 
            this.page_categorias.Location = new System.Drawing.Point(4, 22);
            this.page_categorias.Name = "page_categorias";
            this.page_categorias.Padding = new System.Windows.Forms.Padding(3);
            this.page_categorias.Size = new System.Drawing.Size(792, 375);
            this.page_categorias.TabIndex = 1;
            this.page_categorias.Text = "Categorías";
            this.page_categorias.UseVisualStyleBackColor = true;
            // 
            // panelEdificios
            // 
            this.panelEdificios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(157)))));
            this.panelEdificios.Controls.Add(this.panel2);
            this.panelEdificios.Controls.Add(this.label2);
            this.panelEdificios.Controls.Add(this.lb_num_edificios);
            this.panelEdificios.Controls.Add(this.pictureBox2);
            this.panelEdificios.Location = new System.Drawing.Point(59, 15);
            this.panelEdificios.Name = "panelEdificios";
            this.panelEdificios.Size = new System.Drawing.Size(153, 114);
            this.panelEdificios.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Edificios";
            // 
            // lb_num_edificios
            // 
            this.lb_num_edificios.AutoSize = true;
            this.lb_num_edificios.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_num_edificios.Location = new System.Drawing.Point(13, 19);
            this.lb_num_edificios.Name = "lb_num_edificios";
            this.lb_num_edificios.Size = new System.Drawing.Size(36, 40);
            this.lb_num_edificios.TabIndex = 0;
            this.lb_num_edificios.Text = "0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(84, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(106)))));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(0, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 23);
            this.panel2.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 14);
            this.label5.TabIndex = 5;
            this.label5.Text = "Registros Asociados";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(216)))), ((int)(((byte)(241)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.lb_num_maquinaria);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(233, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(153, 114);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(172)))), ((int)(((byte)(215)))));
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(0, 91);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(153, 23);
            this.panel4.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Registros Asociados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Maquinaria";
            // 
            // lb_num_maquinaria
            // 
            this.lb_num_maquinaria.AutoSize = true;
            this.lb_num_maquinaria.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_num_maquinaria.Location = new System.Drawing.Point(13, 19);
            this.lb_num_maquinaria.Name = "lb_num_maquinaria";
            this.lb_num_maquinaria.Size = new System.Drawing.Size(36, 40);
            this.lb_num_maquinaria.TabIndex = 0;
            this.lb_num_maquinaria.Text = "0";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(84, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(148)))), ((int)(((byte)(252)))));
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.lb_num_vehiculos);
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Location = new System.Drawing.Point(406, 15);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(153, 114);
            this.panel5.TabIndex = 12;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(82)))), ((int)(((byte)(179)))));
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(0, 91);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(153, 23);
            this.panel6.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(15, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 14);
            this.label7.TabIndex = 5;
            this.label7.Text = "Registros Asociados";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Vehículos";
            // 
            // lb_num_vehiculos
            // 
            this.lb_num_vehiculos.AutoSize = true;
            this.lb_num_vehiculos.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_num_vehiculos.Location = new System.Drawing.Point(13, 19);
            this.lb_num_vehiculos.Name = "lb_num_vehiculos";
            this.lb_num_vehiculos.Size = new System.Drawing.Size(36, 40);
            this.lb_num_vehiculos.TabIndex = 0;
            this.lb_num_vehiculos.Text = "0";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(84, 13);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 60);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.lb_num_mobiliario);
            this.panel7.Controls.Add(this.pictureBox5);
            this.panel7.Location = new System.Drawing.Point(578, 15);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(153, 114);
            this.panel7.TabIndex = 13;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(203)))), ((int)(((byte)(176)))));
            this.panel8.Controls.Add(this.label10);
            this.panel8.Location = new System.Drawing.Point(0, 91);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(153, 23);
            this.panel8.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 14);
            this.label10.TabIndex = 5;
            this.label10.Text = "Registros Asociados";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "Mobiliario y equipo";
            // 
            // lb_num_mobiliario
            // 
            this.lb_num_mobiliario.AutoSize = true;
            this.lb_num_mobiliario.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_num_mobiliario.Location = new System.Drawing.Point(13, 19);
            this.lb_num_mobiliario.Name = "lb_num_mobiliario";
            this.lb_num_mobiliario.Size = new System.Drawing.Size(36, 40);
            this.lb_num_mobiliario.TabIndex = 0;
            this.lb_num_mobiliario.Text = "0";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(84, 13);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(60, 60);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // grid_view_clasificaciones
            // 
            this.grid_view_clasificaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_view_clasificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_view_clasificaciones.Location = new System.Drawing.Point(57, 153);
            this.grid_view_clasificaciones.Name = "grid_view_clasificaciones";
            this.grid_view_clasificaciones.ReadOnly = true;
            this.grid_view_clasificaciones.Size = new System.Drawing.Size(674, 212);
            this.grid_view_clasificaciones.TabIndex = 14;
            // 
            // FormClasificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tab_control_clasificacion);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormClasificaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Clasificación de activos";
            this.Load += new System.EventHandler(this.FormClasificaciones_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tab_control_clasificacion.ResumeLayout(false);
            this.page_clasificacion.ResumeLayout(false);
            this.panelEdificios.ResumeLayout(false);
            this.panelEdificios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view_clasificaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tab_control_clasificacion;
        private System.Windows.Forms.TabPage page_clasificacion;
        private System.Windows.Forms.TabPage page_categorias;
        private System.Windows.Forms.Panel panelEdificios;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_num_edificios;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lb_num_mobiliario;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_num_vehiculos;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_num_maquinaria;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView grid_view_clasificaciones;
    }
}