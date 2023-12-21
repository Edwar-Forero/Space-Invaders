using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvader_1._2
{
    public partial class Form4 : Form
    {
        LEVEL level = new LEVEL();
        public Form4(Form2.PUNTAJE puntaje)
        {
            InitializeComponent();

            label3.Text = Convert.ToString(puntaje.score);
        }

        private void button3_Click(object sender, EventArgs e)/*BOTON QUE PERMITE ENVIAR AL JUGADOR AL FORM1*/
        {
            this.Dispose();
            Form1 form1 = new Form1();
            form1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)/*BOTON QUE PERMITE CERRAR EL PROGRMA*/
        {
            this.Dispose();
        }
    }
}
