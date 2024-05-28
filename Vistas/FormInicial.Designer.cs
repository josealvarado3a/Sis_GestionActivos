namespace Sis_GestionActivos.Vistas
{
    partial class FormInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicial));
            this.panel_encabezado = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_nombre_sistema = new System.Windows.Forms.Label();
            this.picture_logo = new System.Windows.Forms.PictureBox();
            this.panel_footer = new System.Windows.Forms.Panel();
            this.panel_fecha = new System.Windows.Forms.Panel();
            this.btn_cerrar_sesion = new System.Windows.Forms.Button();
            this.lb_fecha = new System.Windows.Forms.Label();
            this.lb_hora = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_sesion_inicada = new System.Windows.Forms.Panel();
            this.lb_rol = new System.Windows.Forms.Label();
            this.lb_nombre_usuario = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_sesion = new System.Windows.Forms.Label();
            this.group_btn_acesos = new System.Windows.Forms.GroupBox();
            this.btn_empresa = new System.Windows.Forms.Button();
            this.btn_usuarios = new System.Windows.Forms.Button();
            this.btn_operarios = new System.Windows.Forms.Button();
            this.btn_depreciacion_activos = new System.Windows.Forms.Button();
            this.btn_ubicaciones = new System.Windows.Forms.Button();
            this.btn_clasificacion_activos = new System.Windows.Forms.Button();
            this.btn_activos = new System.Windows.Forms.Button();
            this.panel_encabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_logo)).BeginInit();
            this.panel_footer.SuspendLayout();
            this.panel_fecha.SuspendLayout();
            this.panel_sesion_inicada.SuspendLayout();
            this.group_btn_acesos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_encabezado
            // 
            this.panel_encabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(82)))), ((int)(((byte)(179)))));
            this.panel_encabezado.Controls.Add(this.label2);
            this.panel_encabezado.Controls.Add(this.lb_nombre_sistema);
            this.panel_encabezado.Controls.Add(this.picture_logo);
            this.panel_encabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_encabezado.Location = new System.Drawing.Point(0, 0);
            this.panel_encabezado.Name = "panel_encabezado";
            this.panel_encabezado.Size = new System.Drawing.Size(984, 110);
            this.panel_encabezado.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(132)))));
            this.label2.Location = new System.Drawing.Point(125, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "nombre_de_empresa";
            // 
            // lb_nombre_sistema
            // 
            this.lb_nombre_sistema.AutoSize = true;
            this.lb_nombre_sistema.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nombre_sistema.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_nombre_sistema.Location = new System.Drawing.Point(125, 30);
            this.lb_nombre_sistema.Name = "lb_nombre_sistema";
            this.lb_nombre_sistema.Size = new System.Drawing.Size(334, 22);
            this.lb_nombre_sistema.TabIndex = 2;
            this.lb_nombre_sistema.Text = "Sistema para gestión de Activo Fijo";
            // 
            // picture_logo
            // 
            this.picture_logo.Location = new System.Drawing.Point(12, 10);
            this.picture_logo.Name = "picture_logo";
            this.picture_logo.Size = new System.Drawing.Size(90, 90);
            this.picture_logo.TabIndex = 1;
            this.picture_logo.TabStop = false;
            // 
            // panel_footer
            // 
            this.panel_footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel_footer.Controls.Add(this.panel_fecha);
            this.panel_footer.Controls.Add(this.panel_sesion_inicada);
            this.panel_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_footer.Location = new System.Drawing.Point(0, 501);
            this.panel_footer.Name = "panel_footer";
            this.panel_footer.Size = new System.Drawing.Size(984, 110);
            this.panel_footer.TabIndex = 2;
            // 
            // panel_fecha
            // 
            this.panel_fecha.Controls.Add(this.btn_cerrar_sesion);
            this.panel_fecha.Controls.Add(this.lb_fecha);
            this.panel_fecha.Controls.Add(this.lb_hora);
            this.panel_fecha.Controls.Add(this.label5);
            this.panel_fecha.Location = new System.Drawing.Point(591, 7);
            this.panel_fecha.Name = "panel_fecha";
            this.panel_fecha.Size = new System.Drawing.Size(384, 100);
            this.panel_fecha.TabIndex = 9;
            // 
            // btn_cerrar_sesion
            // 
            this.btn_cerrar_sesion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar_sesion.ForeColor = System.Drawing.Color.Red;
            this.btn_cerrar_sesion.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar_sesion.Image")));
            this.btn_cerrar_sesion.Location = new System.Drawing.Point(257, 0);
            this.btn_cerrar_sesion.Name = "btn_cerrar_sesion";
            this.btn_cerrar_sesion.Size = new System.Drawing.Size(100, 100);
            this.btn_cerrar_sesion.TabIndex = 13;
            this.btn_cerrar_sesion.Text = "Cerrar Sessión";
            this.btn_cerrar_sesion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cerrar_sesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_cerrar_sesion.UseVisualStyleBackColor = true;
            // 
            // lb_fecha
            // 
            this.lb_fecha.AutoSize = true;
            this.lb_fecha.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fecha.Location = new System.Drawing.Point(31, 71);
            this.lb_fecha.Name = "lb_fecha";
            this.lb_fecha.Size = new System.Drawing.Size(202, 16);
            this.lb_fecha.TabIndex = 10;
            this.lb_fecha.Text = "Domingo 4 de Mayo de 2024";
            // 
            // lb_hora
            // 
            this.lb_hora.AutoSize = true;
            this.lb_hora.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hora.Location = new System.Drawing.Point(88, 42);
            this.lb_hora.Name = "lb_hora";
            this.lb_hora.Size = new System.Drawing.Size(90, 22);
            this.lb_hora.TabIndex = 9;
            this.lb_hora.Text = "14:36:05";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(82)))), ((int)(((byte)(179)))));
            this.label5.Location = new System.Drawing.Point(12, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha y hora:";
            // 
            // panel_sesion_inicada
            // 
            this.panel_sesion_inicada.Controls.Add(this.lb_rol);
            this.panel_sesion_inicada.Controls.Add(this.lb_nombre_usuario);
            this.panel_sesion_inicada.Controls.Add(this.label4);
            this.panel_sesion_inicada.Controls.Add(this.label1);
            this.panel_sesion_inicada.Controls.Add(this.lb_sesion);
            this.panel_sesion_inicada.Location = new System.Drawing.Point(3, 4);
            this.panel_sesion_inicada.Name = "panel_sesion_inicada";
            this.panel_sesion_inicada.Size = new System.Drawing.Size(203, 100);
            this.panel_sesion_inicada.TabIndex = 8;
            // 
            // lb_rol
            // 
            this.lb_rol.AutoSize = true;
            this.lb_rol.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rol.Location = new System.Drawing.Point(82, 62);
            this.lb_rol.Name = "lb_rol";
            this.lb_rol.Size = new System.Drawing.Size(21, 15);
            this.lb_rol.TabIndex = 13;
            this.lb_rol.Text = "rol";
            // 
            // lb_nombre_usuario
            // 
            this.lb_nombre_usuario.AutoSize = true;
            this.lb_nombre_usuario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nombre_usuario.Location = new System.Drawing.Point(82, 42);
            this.lb_nombre_usuario.Name = "lb_nombre_usuario";
            this.lb_nombre_usuario.Size = new System.Drawing.Size(99, 15);
            this.lb_nombre_usuario.TabIndex = 11;
            this.lb_nombre_usuario.Text = "nombre_usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Rol:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Usuario:";
            // 
            // lb_sesion
            // 
            this.lb_sesion.AutoSize = true;
            this.lb_sesion.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(82)))), ((int)(((byte)(179)))));
            this.lb_sesion.Location = new System.Drawing.Point(19, 15);
            this.lb_sesion.Name = "lb_sesion";
            this.lb_sesion.Size = new System.Drawing.Size(117, 16);
            this.lb_sesion.TabIndex = 7;
            this.lb_sesion.Text = "Sesión iniciada:";
            // 
            // group_btn_acesos
            // 
            this.group_btn_acesos.Controls.Add(this.btn_empresa);
            this.group_btn_acesos.Controls.Add(this.btn_usuarios);
            this.group_btn_acesos.Controls.Add(this.btn_operarios);
            this.group_btn_acesos.Controls.Add(this.btn_depreciacion_activos);
            this.group_btn_acesos.Controls.Add(this.btn_ubicaciones);
            this.group_btn_acesos.Controls.Add(this.btn_clasificacion_activos);
            this.group_btn_acesos.Controls.Add(this.btn_activos);
            this.group_btn_acesos.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_btn_acesos.Location = new System.Drawing.Point(167, 136);
            this.group_btn_acesos.Name = "group_btn_acesos";
            this.group_btn_acesos.Size = new System.Drawing.Size(650, 306);
            this.group_btn_acesos.TabIndex = 3;
            this.group_btn_acesos.TabStop = false;
            this.group_btn_acesos.Text = "¿Qué deseas realizar?";
            // 
            // btn_empresa
            // 
            this.btn_empresa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_empresa.Image = ((System.Drawing.Image)(resources.GetObject("btn_empresa.Image")));
            this.btn_empresa.Location = new System.Drawing.Point(405, 171);
            this.btn_empresa.Name = "btn_empresa";
            this.btn_empresa.Size = new System.Drawing.Size(100, 100);
            this.btn_empresa.TabIndex = 6;
            this.btn_empresa.Text = "Empresa";
            this.btn_empresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_empresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_empresa.UseVisualStyleBackColor = true;
            this.btn_empresa.Click += new System.EventHandler(this.btn_empresa_Click);
            // 
            // btn_usuarios
            // 
            this.btn_usuarios.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_usuarios.Image = ((System.Drawing.Image)(resources.GetObject("btn_usuarios.Image")));
            this.btn_usuarios.Location = new System.Drawing.Point(271, 171);
            this.btn_usuarios.Name = "btn_usuarios";
            this.btn_usuarios.Size = new System.Drawing.Size(100, 100);
            this.btn_usuarios.TabIndex = 5;
            this.btn_usuarios.Text = "Usuarios";
            this.btn_usuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_usuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_usuarios.UseVisualStyleBackColor = true;
            this.btn_usuarios.Click += new System.EventHandler(this.btn_usuarios_Click);
            // 
            // btn_operarios
            // 
            this.btn_operarios.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_operarios.Image = ((System.Drawing.Image)(resources.GetObject("btn_operarios.Image")));
            this.btn_operarios.Location = new System.Drawing.Point(134, 171);
            this.btn_operarios.Name = "btn_operarios";
            this.btn_operarios.Size = new System.Drawing.Size(100, 100);
            this.btn_operarios.TabIndex = 4;
            this.btn_operarios.Text = "Operarios";
            this.btn_operarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_operarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_operarios.UseVisualStyleBackColor = true;
            // 
            // btn_depreciacion_activos
            // 
            this.btn_depreciacion_activos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_depreciacion_activos.Image = ((System.Drawing.Image)(resources.GetObject("btn_depreciacion_activos.Image")));
            this.btn_depreciacion_activos.Location = new System.Drawing.Point(476, 44);
            this.btn_depreciacion_activos.Name = "btn_depreciacion_activos";
            this.btn_depreciacion_activos.Size = new System.Drawing.Size(100, 100);
            this.btn_depreciacion_activos.TabIndex = 3;
            this.btn_depreciacion_activos.Text = "Depreciación de activos";
            this.btn_depreciacion_activos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_depreciacion_activos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_depreciacion_activos.UseVisualStyleBackColor = true;
            this.btn_depreciacion_activos.Click += new System.EventHandler(this.btn_depreciacion_activos_Click);
            // 
            // btn_ubicaciones
            // 
            this.btn_ubicaciones.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ubicaciones.Image = ((System.Drawing.Image)(resources.GetObject("btn_ubicaciones.Image")));
            this.btn_ubicaciones.Location = new System.Drawing.Point(336, 44);
            this.btn_ubicaciones.Name = "btn_ubicaciones";
            this.btn_ubicaciones.Size = new System.Drawing.Size(100, 100);
            this.btn_ubicaciones.TabIndex = 2;
            this.btn_ubicaciones.Text = "Ubicaciones";
            this.btn_ubicaciones.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ubicaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ubicaciones.UseVisualStyleBackColor = true;
            // 
            // btn_clasificacion_activos
            // 
            this.btn_clasificacion_activos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clasificacion_activos.Image = ((System.Drawing.Image)(resources.GetObject("btn_clasificacion_activos.Image")));
            this.btn_clasificacion_activos.Location = new System.Drawing.Point(202, 44);
            this.btn_clasificacion_activos.Name = "btn_clasificacion_activos";
            this.btn_clasificacion_activos.Size = new System.Drawing.Size(100, 100);
            this.btn_clasificacion_activos.TabIndex = 1;
            this.btn_clasificacion_activos.Text = "Clasificación de Activos";
            this.btn_clasificacion_activos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_clasificacion_activos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_clasificacion_activos.UseVisualStyleBackColor = true;
            this.btn_clasificacion_activos.Click += new System.EventHandler(this.btn_clasificacion_activos_Click);
            // 
            // btn_activos
            // 
            this.btn_activos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_activos.Image = ((System.Drawing.Image)(resources.GetObject("btn_activos.Image")));
            this.btn_activos.Location = new System.Drawing.Point(65, 44);
            this.btn_activos.Name = "btn_activos";
            this.btn_activos.Size = new System.Drawing.Size(100, 100);
            this.btn_activos.TabIndex = 0;
            this.btn_activos.Text = "Activos";
            this.btn_activos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_activos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_activos.UseVisualStyleBackColor = true;
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.group_btn_acesos);
            this.Controls.Add(this.panel_footer);
            this.Controls.Add(this.panel_encabezado);
            this.Name = "FormInicial";
            this.Text = "FormInicial";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.FormInicial_Load);
            this.Resize += new System.EventHandler(this.FormInicial_Resize);
            this.panel_encabezado.ResumeLayout(false);
            this.panel_encabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_logo)).EndInit();
            this.panel_footer.ResumeLayout(false);
            this.panel_fecha.ResumeLayout(false);
            this.panel_fecha.PerformLayout();
            this.panel_sesion_inicada.ResumeLayout(false);
            this.panel_sesion_inicada.PerformLayout();
            this.group_btn_acesos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_encabezado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_nombre_sistema;
        private System.Windows.Forms.PictureBox picture_logo;
        private System.Windows.Forms.Panel panel_footer;
        private System.Windows.Forms.GroupBox group_btn_acesos;
        private System.Windows.Forms.Button btn_empresa;
        private System.Windows.Forms.Button btn_usuarios;
        private System.Windows.Forms.Button btn_operarios;
        private System.Windows.Forms.Button btn_depreciacion_activos;
        private System.Windows.Forms.Button btn_ubicaciones;
        private System.Windows.Forms.Button btn_clasificacion_activos;
        private System.Windows.Forms.Button btn_activos;
        private System.Windows.Forms.Panel panel_fecha;
        private System.Windows.Forms.Label lb_hora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel_sesion_inicada;
        private System.Windows.Forms.Label lb_rol;
        private System.Windows.Forms.Label lb_nombre_usuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_sesion;
        private System.Windows.Forms.Button btn_cerrar_sesion;
        private System.Windows.Forms.Label lb_fecha;
    }
}