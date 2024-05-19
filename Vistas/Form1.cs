using Sol_Componentes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sis_GestionActivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Crear una instancia de CustomButton
            CustomButton myButton = new CustomButton();
            myButton.Text = "Click Me";
            myButton.Location = new Point(12, 12);

            // Agregar el botón al formulario
            this.Controls.Add(myButton);
        }

        private void comBotonMoradoDefault2_Load(object sender, EventArgs e)
        {

        }

        private void buttonControlPrueba1_Load(object sender, EventArgs e)
        {
        }

        private void btn_com_guardar_Load(object sender, EventArgs e)
        {
        }

        private void btn_com_guardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Boton heredado");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void customButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
