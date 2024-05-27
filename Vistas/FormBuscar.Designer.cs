namespace Sis_GestionActivos.Vistas
{
    partial class FormBuscar
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
            this.panel_txt_buscar = new System.Windows.Forms.Panel();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.fb_data_grid_view = new System.Windows.Forms.DataGridView();
            this.btn_aceptar_buscar = new System.Windows.Forms.Button();
            this.btn_cancelar_aceptar = new System.Windows.Forms.Button();
            this.panel_txt_buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fb_data_grid_view)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_txt_buscar
            // 
            this.panel_txt_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(82)))), ((int)(((byte)(179)))));
            this.panel_txt_buscar.Controls.Add(this.txt_buscar);
            this.panel_txt_buscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_txt_buscar.Location = new System.Drawing.Point(0, 0);
            this.panel_txt_buscar.Name = "panel_txt_buscar";
            this.panel_txt_buscar.Size = new System.Drawing.Size(534, 38);
            this.panel_txt_buscar.TabIndex = 0;
            // 
            // txt_buscar
            // 
            this.txt_buscar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_buscar.Location = new System.Drawing.Point(3, 5);
            this.txt_buscar.Multiline = true;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(528, 29);
            this.txt_buscar.TabIndex = 4;
            this.txt_buscar.Text = "Utilice este campo para buscar";
            this.txt_buscar.Click += new System.EventHandler(this.txt_buscar_Click);
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            // 
            // fb_data_grid_view
            // 
            this.fb_data_grid_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fb_data_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fb_data_grid_view.Location = new System.Drawing.Point(0, 38);
            this.fb_data_grid_view.Name = "fb_data_grid_view";
            this.fb_data_grid_view.Size = new System.Drawing.Size(534, 253);
            this.fb_data_grid_view.TabIndex = 1;
            this.fb_data_grid_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fb_data_grid_view_CellClick);
            // 
            // btn_aceptar_buscar
            // 
            this.btn_aceptar_buscar.Location = new System.Drawing.Point(375, 294);
            this.btn_aceptar_buscar.Name = "btn_aceptar_buscar";
            this.btn_aceptar_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar_buscar.TabIndex = 2;
            this.btn_aceptar_buscar.Text = "Aceptar";
            this.btn_aceptar_buscar.UseVisualStyleBackColor = true;
            this.btn_aceptar_buscar.Click += new System.EventHandler(this.btn_aceptar_buscar_Click);
            // 
            // btn_cancelar_aceptar
            // 
            this.btn_cancelar_aceptar.Location = new System.Drawing.Point(456, 294);
            this.btn_cancelar_aceptar.Name = "btn_cancelar_aceptar";
            this.btn_cancelar_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar_aceptar.TabIndex = 3;
            this.btn_cancelar_aceptar.Text = "Cancelar";
            this.btn_cancelar_aceptar.UseVisualStyleBackColor = true;
            this.btn_cancelar_aceptar.Click += new System.EventHandler(this.btn_cancelar_aceptar_Click);
            // 
            // FormBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 320);
            this.Controls.Add(this.btn_cancelar_aceptar);
            this.Controls.Add(this.btn_aceptar_buscar);
            this.Controls.Add(this.fb_data_grid_view);
            this.Controls.Add(this.panel_txt_buscar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBuscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBuscar";
            this.Load += new System.EventHandler(this.FormBuscar_Load);
            this.panel_txt_buscar.ResumeLayout(false);
            this.panel_txt_buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fb_data_grid_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_txt_buscar;
        private System.Windows.Forms.DataGridView fb_data_grid_view;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_aceptar_buscar;
        private System.Windows.Forms.Button btn_cancelar_aceptar;
    }
}