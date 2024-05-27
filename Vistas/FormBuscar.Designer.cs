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
            this.fb_data_grid_view = new System.Windows.Forms.DataGridView();
            this.txt_buscar = new System.Windows.Forms.TextBox();
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
            // fb_data_grid_view
            // 
            this.fb_data_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fb_data_grid_view.Location = new System.Drawing.Point(0, 38);
            this.fb_data_grid_view.Name = "fb_data_grid_view";
            this.fb_data_grid_view.Size = new System.Drawing.Size(534, 273);
            this.fb_data_grid_view.TabIndex = 1;
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
            // 
            // FormBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 311);
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
    }
}