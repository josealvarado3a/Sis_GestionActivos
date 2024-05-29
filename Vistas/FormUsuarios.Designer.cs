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
            this.grid_lista_usuarios = new System.Windows.Forms.DataGridView();
            this.panel_botones_AD = new System.Windows.Forms.Panel();
            this.btn_modificar_ad = new System.Windows.Forms.Button();
            this.btn_nuevo_ad = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_contrasenia = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.txtUsuarioLogin = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_top.SuspendLayout();
            this.tab_listado_usuarios.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_lista_usuarios)).BeginInit();
            this.panel_botones_AD.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 49);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(76, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
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
            this.panel_top.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1067, 62);
            this.panel_top.TabIndex = 1;
            // 
            // tab_listado_usuarios
            // 
            this.tab_listado_usuarios.Controls.Add(this.tabPage1);
            this.tab_listado_usuarios.Controls.Add(this.tabPage2);
            this.tab_listado_usuarios.Location = new System.Drawing.Point(0, 63);
            this.tab_listado_usuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab_listado_usuarios.Name = "tab_listado_usuarios";
            this.tab_listado_usuarios.SelectedIndex = 0;
            this.tab_listado_usuarios.Size = new System.Drawing.Size(1067, 522);
            this.tab_listado_usuarios.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grid_lista_usuarios);
            this.tabPage1.Controls.Add(this.panel_botones_AD);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1059, 493);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // grid_lista_usuarios
            // 
            this.grid_lista_usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_lista_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_lista_usuarios.Location = new System.Drawing.Point(4, 49);
            this.grid_lista_usuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grid_lista_usuarios.Name = "grid_lista_usuarios";
            this.grid_lista_usuarios.RowHeadersWidth = 51;
            this.grid_lista_usuarios.Size = new System.Drawing.Size(1048, 437);
            this.grid_lista_usuarios.TabIndex = 4;
            this.grid_lista_usuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_lista_usuarios_CellContentClick);
            // 
            // panel_botones_AD
            // 
            this.panel_botones_AD.Controls.Add(this.btn_modificar_ad);
            this.panel_botones_AD.Controls.Add(this.btn_nuevo_ad);
            this.panel_botones_AD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_botones_AD.Location = new System.Drawing.Point(4, 4);
            this.panel_botones_AD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_botones_AD.Name = "panel_botones_AD";
            this.panel_botones_AD.Size = new System.Drawing.Size(1051, 43);
            this.panel_botones_AD.TabIndex = 3;
            // 
            // btn_modificar_ad
            // 
            this.btn_modificar_ad.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar_ad.Image = ((System.Drawing.Image)(resources.GetObject("btn_modificar_ad.Image")));
            this.btn_modificar_ad.Location = new System.Drawing.Point(127, 5);
            this.btn_modificar_ad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_modificar_ad.Name = "btn_modificar_ad";
            this.btn_modificar_ad.Size = new System.Drawing.Size(120, 33);
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
            this.btn_nuevo_ad.Location = new System.Drawing.Point(7, 5);
            this.btn_nuevo_ad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_nuevo_ad.Name = "btn_nuevo_ad";
            this.btn_nuevo_ad.Size = new System.Drawing.Size(112, 33);
            this.btn_nuevo_ad.TabIndex = 1;
            this.btn_nuevo_ad.Text = "Nuevo";
            this.btn_nuevo_ad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_nuevo_ad.UseVisualStyleBackColor = true;
            this.btn_nuevo_ad.Click += new System.EventHandler(this.btn_nuevo_ad_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_cancelar);
            this.tabPage2.Controls.Add(this.btn_guardar);
            this.tabPage2.Controls.Add(this.cb_estado);
            this.tabPage2.Controls.Add(this.txt_email);
            this.tabPage2.Controls.Add(this.txt_contrasenia);
            this.tabPage2.Controls.Add(this.txtApellidos);
            this.tabPage2.Controls.Add(this.cbRol);
            this.tabPage2.Controls.Add(this.txtUsuarioLogin);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1059, 493);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registro";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.AutoSize = true;
            this.btn_cancelar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.Image")));
            this.btn_cancelar.Location = new System.Drawing.Point(403, 250);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(129, 33);
            this.btn_cancelar.TabIndex = 42;
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
            this.btn_guardar.Location = new System.Drawing.Point(272, 246);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(123, 37);
            this.btn_guardar.TabIndex = 41;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // cb_estado
            // 
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Location = new System.Drawing.Point(39, 254);
            this.cb_estado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(169, 24);
            this.cb_estado.TabIndex = 40;
            this.cb_estado.SelectedIndexChanged += new System.EventHandler(this.cb_estado_SelectedIndexChanged);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(579, 151);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(212, 22);
            this.txt_email.TabIndex = 39;
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            // 
            // txt_contrasenia
            // 
            this.txt_contrasenia.Location = new System.Drawing.Point(309, 151);
            this.txt_contrasenia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_contrasenia.Name = "txt_contrasenia";
            this.txt_contrasenia.Size = new System.Drawing.Size(212, 22);
            this.txt_contrasenia.TabIndex = 38;
            this.txt_contrasenia.TextChanged += new System.EventHandler(this.txt_contrasenia_TextChanged);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(752, 59);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(267, 22);
            this.txtApellidos.TabIndex = 37;
            this.txtApellidos.TextChanged += new System.EventHandler(this.txtApellidos_TextChanged);
            // 
            // cbRol
            // 
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Location = new System.Drawing.Point(849, 150);
            this.cbRol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(169, 24);
            this.cbRol.TabIndex = 35;
            this.cbRol.SelectedIndexChanged += new System.EventHandler(this.cbRol_SelectedIndexChanged);
            // 
            // txtUsuarioLogin
            // 
            this.txtUsuarioLogin.Location = new System.Drawing.Point(35, 151);
            this.txtUsuarioLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuarioLogin.Name = "txtUsuarioLogin";
            this.txtUsuarioLogin.Size = new System.Drawing.Size(212, 22);
            this.txtUsuarioLogin.TabIndex = 31;
            this.txtUsuarioLogin.TextChanged += new System.EventHandler(this.txtUsuarioLogin_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(428, 59);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(267, 22);
            this.txtNombre.TabIndex = 30;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(225, 59);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(132, 22);
            this.txtId.TabIndex = 29;
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(35, 59);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(132, 22);
            this.txtFecha.TabIndex = 28;
            this.txtFecha.TextChanged += new System.EventHandler(this.txtFecha_TextChanged);
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(35, 220);
            this.lblestado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(125, 16);
            this.lblestado.TabIndex = 27;
            this.lblestado.Text = "Estado del Usuario:";
            // 
            // lblrol
            // 
            this.lblrol.AutoSize = true;
            this.lblrol.Location = new System.Drawing.Point(845, 124);
            this.lblrol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblrol.Name = "lblrol";
            this.lblrol.Size = new System.Drawing.Size(103, 16);
            this.lblrol.TabIndex = 26;
            this.lblrol.Text = "Rol del Usuario:";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(575, 124);
            this.lblemail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(44, 16);
            this.lblemail.TabIndex = 25;
            this.lblemail.Text = "Email:";
            // 
            // lblcontraseña
            // 
            this.lblcontraseña.AutoSize = true;
            this.lblcontraseña.Location = new System.Drawing.Point(309, 124);
            this.lblcontraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcontraseña.Name = "lblcontraseña";
            this.lblcontraseña.Size = new System.Drawing.Size(79, 16);
            this.lblcontraseña.TabIndex = 24;
            this.lblcontraseña.Text = "Contraseña:";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(35, 124);
            this.lblusuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(93, 16);
            this.lblusuario.TabIndex = 23;
            this.lblusuario.Text = "Usuario Login:";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(748, 31);
            this.lblApellidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(139, 16);
            this.lblApellidos.TabIndex = 22;
            this.lblApellidos.Text = "Apellidos del Usuario:";
            // 
            // txtNombres
            // 
            this.txtNombres.AutoSize = true;
            this.txtNombres.Location = new System.Drawing.Point(424, 31);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(138, 16);
            this.txtNombres.TabIndex = 21;
            this.txtNombres.Text = "Nombres del Usuario:";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.AutoSize = true;
            this.txtIdUsuario.Location = new System.Drawing.Point(221, 31);
            this.txtIdUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(73, 16);
            this.txtIdUsuario.TabIndex = 20;
            this.txtIdUsuario.Text = "ID Usuario:";
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.AutoSize = true;
            this.dtpFechaRegistro.Location = new System.Drawing.Point(35, 31);
            this.dtpFechaRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(121, 16);
            this.dtpFechaRegistro.TabIndex = 19;
            this.dtpFechaRegistro.Text = "Fecha de Registro:";
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 586);
            this.Controls.Add(this.tab_listado_usuarios);
            this.Controls.Add(this.panel_top);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.tab_listado_usuarios.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_lista_usuarios)).EndInit();
            this.panel_botones_AD.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.Button btn_modificar_ad;
        private System.Windows.Forms.Button btn_nuevo_ad;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.TextBox txtUsuarioLogin;
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
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_contrasenia;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
    }
}