namespace Sis_GestionActivos.Vistas
{
    partial class FormUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuarios));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_top = new System.Windows.Forms.Panel();
            this.tab_listado_usuarios = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel_botones_AD = new System.Windows.Forms.Panel();
            this.btn_eliminar_ad = new System.Windows.Forms.Button();
            this.btn_modificar_ad = new System.Windows.Forms.Button();
            this.btn_nuevo_ad = new System.Windows.Forms.Button();
            this.grid_lista_usuarios = new System.Windows.Forms.DataGridView();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.lblrol = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblcontraseña = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.Label();
            this.txtIdUsuario = new System.Windows.Forms.Label();
            this.dtpFechaRegistro = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_top.SuspendLayout();
            this.tab_listado_usuarios.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel_botones_AD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_lista_usuarios)).BeginInit();
            this.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuarios";
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(82)))), ((int)(((byte)(179)))));
            this.panel_top.Controls.Add(this.pictureBox1);
            this.panel_top.Controls.Add(this.label1);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(800, 50);
            this.panel_top.TabIndex = 1;
            // 
            // tab_listado_usuarios
            // 
            this.tab_listado_usuarios.Controls.Add(this.tabPage1);
            this.tab_listado_usuarios.Controls.Add(this.tabPage2);
            this.tab_listado_usuarios.Location = new System.Drawing.Point(0, 51);
            this.tab_listado_usuarios.Name = "tab_listado_usuarios";
            this.tab_listado_usuarios.SelectedIndex = 0;
            this.tab_listado_usuarios.Size = new System.Drawing.Size(800, 424);
            this.tab_listado_usuarios.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grid_lista_usuarios);
            this.tabPage1.Controls.Add(this.panel_botones_AD);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_cancelar);
            this.tabPage2.Controls.Add(this.btn_guardar);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.cbRol);
            this.tabPage2.Controls.Add(this.txtApellido);
            this.tabPage2.Controls.Add(this.txtNombre);
            this.tabPage2.Controls.Add(this.txtId);
            this.tabPage2.Controls.Add(this.txtFecha);
            this.tabPage2.Controls.Add(this.lblestado);
            this.tabPage2.Controls.Add(this.lblrol);
            this.tabPage2.Controls.Add(this.lblemail);
            this.tabPage2.Controls.Add(this.lblcontraseña);
            this.tabPage2.Controls.Add(this.lblusuario);
            this.tabPage2.Controls.Add(this.lblApellidos);
            this.tabPage2.Controls.Add(this.txtNombres);
            this.tabPage2.Controls.Add(this.txtIdUsuario);
            this.tabPage2.Controls.Add(this.dtpFechaRegistro);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registro";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel_botones_AD
            // 
            this.panel_botones_AD.Controls.Add(this.btn_eliminar_ad);
            this.panel_botones_AD.Controls.Add(this.btn_modificar_ad);
            this.panel_botones_AD.Controls.Add(this.btn_nuevo_ad);
            this.panel_botones_AD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_botones_AD.Location = new System.Drawing.Point(3, 3);
            this.panel_botones_AD.Name = "panel_botones_AD";
            this.panel_botones_AD.Size = new System.Drawing.Size(786, 35);
            this.panel_botones_AD.TabIndex = 3;
            // 
            // btn_eliminar_ad
            // 
            this.btn_eliminar_ad.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar_ad.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar_ad.Image")));
            this.btn_eliminar_ad.Location = new System.Drawing.Point(191, 4);
            this.btn_eliminar_ad.Name = "btn_eliminar_ad";
            this.btn_eliminar_ad.Size = new System.Drawing.Size(90, 27);
            this.btn_eliminar_ad.TabIndex = 3;
            this.btn_eliminar_ad.Text = "Eliminar";
            this.btn_eliminar_ad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_eliminar_ad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_eliminar_ad.UseVisualStyleBackColor = true;
            // 
            // btn_modificar_ad
            // 
            this.btn_modificar_ad.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar_ad.Image = ((System.Drawing.Image)(resources.GetObject("btn_modificar_ad.Image")));
            this.btn_modificar_ad.Location = new System.Drawing.Point(95, 4);
            this.btn_modificar_ad.Name = "btn_modificar_ad";
            this.btn_modificar_ad.Size = new System.Drawing.Size(90, 27);
            this.btn_modificar_ad.TabIndex = 2;
            this.btn_modificar_ad.Text = "Modificar";
            this.btn_modificar_ad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_modificar_ad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_modificar_ad.UseVisualStyleBackColor = true;
            // 
            // btn_nuevo_ad
            // 
            this.btn_nuevo_ad.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo_ad.Image = ((System.Drawing.Image)(resources.GetObject("btn_nuevo_ad.Image")));
            this.btn_nuevo_ad.Location = new System.Drawing.Point(5, 4);
            this.btn_nuevo_ad.Name = "btn_nuevo_ad";
            this.btn_nuevo_ad.Size = new System.Drawing.Size(84, 27);
            this.btn_nuevo_ad.TabIndex = 1;
            this.btn_nuevo_ad.Text = "Nuevo";
            this.btn_nuevo_ad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_nuevo_ad.UseVisualStyleBackColor = true;
            // 
            // grid_lista_usuarios
            // 
            this.grid_lista_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_lista_usuarios.Location = new System.Drawing.Point(3, 40);
            this.grid_lista_usuarios.Name = "grid_lista_usuarios";
            this.grid_lista_usuarios.Size = new System.Drawing.Size(786, 355);
            this.grid_lista_usuarios.TabIndex = 4;
            // 
            // cbRol
            // 
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Location = new System.Drawing.Point(637, 122);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(128, 21);
            this.cbRol.TabIndex = 35;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(26, 123);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(160, 20);
            this.txtApellido.TabIndex = 31;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(321, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(201, 20);
            this.txtNombre.TabIndex = 30;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(169, 48);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 29;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(26, 48);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 28;
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(26, 179);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(99, 13);
            this.lblestado.TabIndex = 27;
            this.lblestado.Text = "Estado del Usuario:";
            // 
            // lblrol
            // 
            this.lblrol.AutoSize = true;
            this.lblrol.Location = new System.Drawing.Point(634, 101);
            this.lblrol.Name = "lblrol";
            this.lblrol.Size = new System.Drawing.Size(82, 13);
            this.lblrol.TabIndex = 26;
            this.lblrol.Text = "Rol del Usuario:";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(431, 101);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(35, 13);
            this.lblemail.TabIndex = 25;
            this.lblemail.Text = "Email:";
            // 
            // lblcontraseña
            // 
            this.lblcontraseña.AutoSize = true;
            this.lblcontraseña.Location = new System.Drawing.Point(232, 101);
            this.lblcontraseña.Name = "lblcontraseña";
            this.lblcontraseña.Size = new System.Drawing.Size(64, 13);
            this.lblcontraseña.TabIndex = 24;
            this.lblcontraseña.Text = "Contraseña:";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(26, 101);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(75, 13);
            this.lblusuario.TabIndex = 23;
            this.lblusuario.Text = "Usuario Login:";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(561, 25);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(108, 13);
            this.lblApellidos.TabIndex = 22;
            this.lblApellidos.Text = "Apellidos del Usuario:";
            // 
            // txtNombres
            // 
            this.txtNombres.AutoSize = true;
            this.txtNombres.Location = new System.Drawing.Point(318, 25);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(108, 13);
            this.txtNombres.TabIndex = 21;
            this.txtNombres.Text = "Nombres del Usuario:";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.AutoSize = true;
            this.txtIdUsuario.Location = new System.Drawing.Point(166, 25);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(60, 13);
            this.txtIdUsuario.TabIndex = 20;
            this.txtIdUsuario.Text = "ID Usuario:";
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.AutoSize = true;
            this.dtpFechaRegistro.Location = new System.Drawing.Point(26, 25);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(97, 13);
            this.dtpFechaRegistro.TabIndex = 19;
            this.dtpFechaRegistro.Text = "Fecha de Registro:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(564, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 20);
            this.textBox1.TabIndex = 37;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(232, 123);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 20);
            this.textBox2.TabIndex = 38;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(434, 123);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(160, 20);
            this.textBox3.TabIndex = 39;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(29, 206);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 21);
            this.comboBox1.TabIndex = 40;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.AutoSize = true;
            this.btn_cancelar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.Image")));
            this.btn_cancelar.Location = new System.Drawing.Point(302, 203);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(87, 27);
            this.btn_cancelar.TabIndex = 42;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(82)))), ((int)(((byte)(179)))));
            this.btn_guardar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.Location = new System.Drawing.Point(204, 200);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(92, 30);
            this.btn_guardar.TabIndex = 41;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_guardar.UseVisualStyleBackColor = false;
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.tab_listado_usuarios);
            this.Controls.Add(this.panel_top);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.tab_listado_usuarios.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel_botones_AD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_lista_usuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.TabControl tab_listado_usuarios;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView grid_lista_usuarios;
        private System.Windows.Forms.Panel panel_botones_AD;
        private System.Windows.Forms.Button btn_eliminar_ad;
        private System.Windows.Forms.Button btn_modificar_ad;
        private System.Windows.Forms.Button btn_nuevo_ad;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.Label lblrol;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblcontraseña;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label txtNombres;
        private System.Windows.Forms.Label txtIdUsuario;
        private System.Windows.Forms.Label dtpFechaRegistro;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
    }
}