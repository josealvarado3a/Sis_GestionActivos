using System.Drawing;

namespace Sis_GestionActivos
{
    partial class Componentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Componentes));
            this.btnMoradoDefault = new System.Windows.Forms.Button();
            this.btnGuardarMorado = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnDefault35 = new System.Windows.Forms.Button();
            this.toolTipBtnDefault35 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_buscar_35 = new System.Windows.Forms.Button();
            this.btn_rehacer_35 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMoradoDefault
            // 
            this.btnMoradoDefault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(82)))), ((int)(((byte)(179)))));
            this.btnMoradoDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoradoDefault.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMoradoDefault.Image = ((System.Drawing.Image)(resources.GetObject("btnMoradoDefault.Image")));
            this.btnMoradoDefault.Location = new System.Drawing.Point(12, 12);
            this.btnMoradoDefault.Name = "btnMoradoDefault";
            this.btnMoradoDefault.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMoradoDefault.Size = new System.Drawing.Size(100, 35);
            this.btnMoradoDefault.TabIndex = 0;
            this.btnMoradoDefault.Text = "Default";
            this.btnMoradoDefault.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMoradoDefault.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMoradoDefault.UseVisualStyleBackColor = false;
            // 
            // btnGuardarMorado
            // 
            this.btnGuardarMorado.BackColor = this.btnMoradoDefault.BackColor;
            this.btnGuardarMorado.Font = this.btnMoradoDefault.Font;
            this.btnGuardarMorado.ForeColor = this.btnMoradoDefault.ForeColor;
            this.btnGuardarMorado.Image = this.btnMoradoDefault.Image;
            this.btnGuardarMorado.Location = new System.Drawing.Point(12, 53);
            this.btnGuardarMorado.Name = "btnGuardarMorado";
            this.btnGuardarMorado.RightToLeft = this.btnMoradoDefault.RightToLeft;
            this.btnGuardarMorado.Size = this.btnMoradoDefault.Size;
            this.btnGuardarMorado.TabIndex = 1;
            this.btnGuardarMorado.Text = "Guardar";
            this.btnGuardarMorado.TextAlign = this.btnMoradoDefault.TextAlign;
            this.btnGuardarMorado.TextImageRelation = this.btnMoradoDefault.TextImageRelation;
            this.btnGuardarMorado.UseVisualStyleBackColor = false;
            this.btnGuardarMorado.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDefault
            // 
            this.btnDefault.BackColor = System.Drawing.SystemColors.Control;
            this.btnDefault.Font = this.btnMoradoDefault.Font;
            this.btnDefault.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnDefault.Image = ((System.Drawing.Image)(resources.GetObject("btnDefault.Image")));
            this.btnDefault.Location = new System.Drawing.Point(118, 53);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.RightToLeft = this.btnMoradoDefault.RightToLeft;
            this.btnDefault.Size = this.btnMoradoDefault.Size;
            this.btnDefault.TabIndex = 2;
            this.btnDefault.Text = "Default";
            this.btnDefault.TextAlign = this.btnMoradoDefault.TextAlign;
            this.btnDefault.TextImageRelation = this.btnMoradoDefault.TextImageRelation;
            this.btnDefault.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.Control;
            this.btnModificar.Font = this.btnMoradoDefault.Font;
            this.btnModificar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Location = new System.Drawing.Point(118, 117);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.RightToLeft = this.btnMoradoDefault.RightToLeft;
            this.btnModificar.Size = this.btnMoradoDefault.Size;
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = this.btnMoradoDefault.TextAlign;
            this.btnModificar.TextImageRelation = this.btnMoradoDefault.TextImageRelation;
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Font = this.btnMoradoDefault.Font;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(118, 158);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.RightToLeft = this.btnMoradoDefault.RightToLeft;
            this.btnEliminar.Size = this.btnMoradoDefault.Size;
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = this.btnMoradoDefault.TextAlign;
            this.btnEliminar.TextImageRelation = this.btnMoradoDefault.TextImageRelation;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = this.btnMoradoDefault.Font;
            this.button1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(118, 199);
            this.button1.Name = "button1";
            this.button1.RightToLeft = this.btnMoradoDefault.RightToLeft;
            this.button1.Size = this.btnMoradoDefault.Size;
            this.button1.TabIndex = 5;
            this.button1.Text = "Nuevo";
            this.button1.TextAlign = this.btnMoradoDefault.TextAlign;
            this.button1.TextImageRelation = this.btnMoradoDefault.TextImageRelation;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = this.btnMoradoDefault.Font;
            this.button2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(118, 240);
            this.button2.Name = "button2";
            this.button2.RightToLeft = this.btnMoradoDefault.RightToLeft;
            this.button2.Size = this.btnMoradoDefault.Size;
            this.button2.TabIndex = 6;
            this.button2.Text = "Agregar";
            this.button2.TextAlign = this.btnMoradoDefault.TextAlign;
            this.button2.TextImageRelation = this.btnMoradoDefault.TextImageRelation;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Font = this.btnMoradoDefault.Font;
            this.button3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(118, 281);
            this.button3.Name = "button3";
            this.button3.RightToLeft = this.btnMoradoDefault.RightToLeft;
            this.button3.Size = this.btnMoradoDefault.Size;
            this.button3.TabIndex = 7;
            this.button3.Text = "Cancelar";
            this.button3.TextAlign = this.btnMoradoDefault.TextAlign;
            this.button3.TextImageRelation = this.btnMoradoDefault.TextImageRelation;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.Font = this.btnMoradoDefault.Font;
            this.button4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(118, 322);
            this.button4.Name = "button4";
            this.button4.RightToLeft = this.btnMoradoDefault.RightToLeft;
            this.button4.Size = this.btnMoradoDefault.Size;
            this.button4.TabIndex = 8;
            this.button4.Text = "Limpiar";
            this.button4.TextAlign = this.btnMoradoDefault.TextAlign;
            this.button4.TextImageRelation = this.btnMoradoDefault.TextImageRelation;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnDefault35
            // 
            this.btnDefault35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(82)))), ((int)(((byte)(179)))));
            this.btnDefault35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefault35.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDefault35.Image = ((System.Drawing.Image)(resources.GetObject("btnDefault35.Image")));
            this.btnDefault35.Location = new System.Drawing.Point(118, 12);
            this.btnDefault35.Name = "btnDefault35";
            this.btnDefault35.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDefault35.Size = new System.Drawing.Size(35, 35);
            this.btnDefault35.TabIndex = 9;
            this.btnDefault35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDefault35.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipBtnDefault35.SetToolTip(this.btnDefault35, "Click para");
            this.btnDefault35.UseVisualStyleBackColor = false;
            // 
            // toolTipBtnDefault35
            // 
            this.toolTipBtnDefault35.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // btn_buscar_35
            // 
            this.btn_buscar_35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(82)))), ((int)(((byte)(179)))));
            this.btn_buscar_35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar_35.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_buscar_35.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar_35.Image")));
            this.btn_buscar_35.Location = new System.Drawing.Point(159, 12);
            this.btn_buscar_35.Name = "btn_buscar_35";
            this.btn_buscar_35.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_buscar_35.Size = new System.Drawing.Size(35, 35);
            this.btn_buscar_35.TabIndex = 10;
            this.btn_buscar_35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_buscar_35.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipBtnDefault35.SetToolTip(this.btn_buscar_35, "Click para buscar");
            this.btn_buscar_35.UseVisualStyleBackColor = false;
            // 
            // btn_rehacer_35
            // 
            this.btn_rehacer_35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(82)))), ((int)(((byte)(179)))));
            this.btn_rehacer_35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rehacer_35.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_rehacer_35.Image = ((System.Drawing.Image)(resources.GetObject("btn_rehacer_35.Image")));
            this.btn_rehacer_35.Location = new System.Drawing.Point(200, 12);
            this.btn_rehacer_35.Name = "btn_rehacer_35";
            this.btn_rehacer_35.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_rehacer_35.Size = new System.Drawing.Size(35, 35);
            this.btn_rehacer_35.TabIndex = 11;
            this.btn_rehacer_35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_rehacer_35.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipBtnDefault35.SetToolTip(this.btn_rehacer_35, "Click para rehacer");
            this.btn_rehacer_35.UseVisualStyleBackColor = false;
            // 
            // Componentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_rehacer_35);
            this.Controls.Add(this.btn_buscar_35);
            this.Controls.Add(this.btnDefault35);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.btnGuardarMorado);
            this.Controls.Add(this.btnMoradoDefault);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Componentes";
            this.Text = "Componentes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMoradoDefault;
        private System.Windows.Forms.Button btnGuardarMorado;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnDefault35;
        private System.Windows.Forms.ToolTip toolTipBtnDefault35;
        private System.Windows.Forms.Button btn_buscar_35;
        private System.Windows.Forms.Button btn_rehacer_35;
    }
}