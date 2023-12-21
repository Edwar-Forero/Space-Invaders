using static SpaceInvader_1._2.Form1;
using static System.Formats.Asn1.AsnWriter;

namespace SpaceInvader_1._2
{
    public partial class Form1 : Form
    { 
        
        
        public Form1()
        {
            InitializeComponent();
            movimientoTitulo.Start();

          
        }
        //SE LLAMA LAS CLASES
        Movimientos movimiento = new Movimientos();
        LEVEL level = new LEVEL();
        PLAYER player = new PLAYER();
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
         
        }

        private void movimientoTitulo_Tick(object sender, EventArgs e) /*PERMITE QUE EL TITULO SE MUEVA HACIA LA IZQUIERDA */
        {

            movimiento.tituloX = titulo.Location.X;
            movimiento.tituloY = titulo.Location.Y;


            if (movimiento.tituloX > 12)
            {
                movimiento.movimientoizq();

            }
            else
            {
                
                movimientoTituloder.Start();
                movimientoTitulo.Stop();
            }
            Point posicion = new Point(movimiento.tituloX, movimiento.tituloY);
            titulo.Location = posicion;


        }

        private void movimientoTituloder_Tick(object sender, EventArgs e) /*PERMITE QUE EL TITULO SE MUEVA HACIA LA DERECHA*/
        {
            if (movimiento.tituloX < 446)
            {
                movimiento.moviemintoder();
            }
            else
            {
                movimientoTitulo.Start();
                movimientoTituloder.Stop();
            }

            Point posicion = new Point(movimiento.tituloX, movimiento.tituloY);
            titulo.Location = posicion;
        }

        public struct Velocidades /*SE CREAN VARIABLES PARA ENVIAR AL FORM2  */
        {
            public int velocidadNave;
            public int velocidadEnemigo;
            public int velocidadBala;
            public int Nivel;

        }

        private void button1_Click(object sender, EventArgs e) /*PERMITE ELEGIR EL NIVEL___ ASEGUN EL RADIOBUTON LAS VARIABLES ENVIADAS AL FORM2 LAS VELOCIDADES DE CADA NIVEL */
        {
            

            if (radioButton1.Checked)
            {
                Velocidades velocidades = new Velocidades();
                velocidades.velocidadEnemigo += 10;
                velocidades.velocidadBala += 15;
                velocidades.velocidadNave += 15;
                velocidades.Nivel += 1;
                Form2 form2 = new Form2(velocidades) ;
                form2.Visible = true;
                Visible = false;              
                
            }
            if (radioButton2.Checked)
            {
                Velocidades velocidades = new Velocidades();
                velocidades.velocidadEnemigo += 15;
                velocidades.velocidadBala += 20;
                velocidades.velocidadNave += 20;
                velocidades.Nivel = 2;

                Form2 form2 = new Form2(velocidades);
                form2.Visible = true;
                Visible = false;
  
            }
            if (radioButton3.Checked)
            {
                Velocidades velocidades = new Velocidades();
                velocidades.velocidadEnemigo += 20;
                velocidades.velocidadBala += 30;
                velocidades.velocidadNave += 30;
                velocidades.Nivel += 3;

                Form2 form2 = new Form2(velocidades);
                form2.Visible = true;
                Visible = false;
                

            }
            
        }

        private void button2_Click(object sender, EventArgs e) /*PERMITE CERRAR LA VENTANA*/
        {
            this.Dispose();
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
  
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
            button1.Enabled = true;
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Visible = true;
            Visible = false;
        }
    }
}