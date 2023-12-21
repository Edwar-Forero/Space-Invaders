using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SpaceInvader_1._2.Form1;

namespace SpaceInvader_1._2
{
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }


        
        private void button1_Click(object sender, EventArgs e)
        {

           
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            
        }

        

        private void button2_Click(object sender, EventArgs e) /*BOTON QUE PERMITE CERRAR EL PROGRMA*/
        {
            
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e) /*BOTON QUE PERMITE ENVIAR AL JUGADOR AL FORM1*/
        {
            this.Dispose();
            Form1 form1 = new Form1();
            form1.Visible = true;

        }
    }
}
