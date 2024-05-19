using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sol_Componentes
{
    public class CustomButton : Button
    {
        public CustomButton() 
        {
            if (this.DesignMode) return;

            this.BackColor = Color.Green;
            //this.BackColor = Color.FromArgb(121, 82, 179);
            this.ForeColor = Color.White;
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.TabIndex = 1;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 1;
            this.Size = new System.Drawing.Size(100, 35);
            this.UseVisualStyleBackColor = true;
            this.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        }

        public void ChangeAppearance(Color backColor, Color foreColor, Font font)
        {
            this.BackColor = backColor;
            this.ForeColor = foreColor;
            this.Font = font;
        }
    }
}
