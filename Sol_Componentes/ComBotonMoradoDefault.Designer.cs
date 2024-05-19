namespace Sol_Componentes
{
    partial class ComBotonMoradoDefault
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMoradoDefault = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMoradoDefault
            // 
            this.btnMoradoDefault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(82)))), ((int)(((byte)(179)))));
            this.btnMoradoDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoradoDefault.ForeColor = System.Drawing.Color.White;
            this.btnMoradoDefault.Location = new System.Drawing.Point(0, 0);
            this.btnMoradoDefault.Name = "btnMoradoDefault";
            this.btnMoradoDefault.Size = new System.Drawing.Size(100, 30);
            this.btnMoradoDefault.TabIndex = 0;
            this.btnMoradoDefault.Text = "button1";
            this.btnMoradoDefault.UseVisualStyleBackColor = false;
            // 
            // ComBotonMoradoDefault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnMoradoDefault);
            this.Name = "ComBotonMoradoDefault";
            this.Size = new System.Drawing.Size(100, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMoradoDefault;
    }
}
