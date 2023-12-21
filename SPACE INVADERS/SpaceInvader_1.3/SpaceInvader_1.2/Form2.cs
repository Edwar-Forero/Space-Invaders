using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using static System.Windows.Forms.DataFormats;


namespace SpaceInvader_1._2
{
    public partial class Form2 : Form
    {
        PictureBox[] invaderArray;
        PictureBox[] invaderArray2;
        PictureBox[] invaderArray3;

        public Form2(Form1.Velocidades velocidades)
        {
            InitializeComponent();
            
            //SE CREAN LAS MATRICES DE LOS INVADERS
            invaderArray = new PictureBox[7];
            invaderArray2 = new PictureBox[7];
            invaderArray3 = new PictureBox[7];

            
            //SE LLAMA AL METODO PARA CREAR LOS INVADERS
            crearInvader();

            timer1.Start();
            timer3.Start();

            //TOMA LAS VELOCIDADES QUE ENVIO EL FORM1 Y LO ENLASA A LAS CLASES 
            level.invaderSpeed += velocidades.velocidadEnemigo;
            tiempoBalaEne += velocidades.velocidadBala;

            level.niveles = velocidades.Nivel;
            player.naveSpeed += velocidades.velocidadNave;
            label4.Text = level.niveles.ToString();

            




        }
        public struct PUNTAJE
        {
            public int score;
        }

        public void wineer() /*PERMITE QUE EL FORM4 APARESCA CUANDO SE ELIMINA A TODOS LOS INVADERS*/
        {
            PUNTAJE puntaje = new PUNTAJE();
            puntaje.score += level.score;

            Form4 form4 = new Form4(puntaje);
            form4.Visible = true;
            this.Dispose();
            timer3.Enabled = false;
        }



        public int tiempoBalaEne;
        Form1 form1 = new Form1();
        PLAYER player = new PLAYER();
        INVADER invader = new INVADER();
        LEVEL level = new LEVEL();
        PictureBox bala = new PictureBox();
        public int a;
        public int b;







        private void closeForm2(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            player.naveX = nave.Location.X;
            player.naveY = nave.Location.Y;

            if (player.naveX > 12) /*MOVENCION HACIA LA IZQUIERDA DE LA NAVE*/
            {
                if (e.KeyCode == Keys.A)
                {
                    player.naveMoviminetoizq();
                    player.goLeft = true;

                }

            }
            if (player.naveX < 1189) /*MOVENCION HACIA LA DERECHA DE LA NAVE*/
            {
                if (e.KeyCode == Keys.D)
                {
                    player.naveMovimientoder();
                    player.goRight = true;

                }
            }
            Point nuevo = new Point(player.naveX, player.naveY);
            nave.Location = nuevo;



        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {


        }

        public void crearInvader() //CREA LAS 3 FILAS DE INVADERS Y SUS CARACTERISTICAS CORRESPONDIENTES
        {
            
            int left1 = 0;
            for (int i = 0; i < invaderArray.Length; i++)
            {
                invaderArray[i] = new PictureBox();
                invaderArray[i].Size = new Size(70, 50);
                invaderArray[i].Image = Properties.Resources.extraterrestre;
                invaderArray[i].Top = 0;
                invaderArray[i].Tag = "arrayInvader";
                invaderArray[i].Left = left1;
                invaderArray[i].SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(invaderArray[i]);
                left1 += 100;
            }

            int left2 = 0;
            for (int i = 0; i < invaderArray2.Length; i++)
            {
                invaderArray2[i] = new PictureBox();
                invaderArray2[i].Size = new Size(70, 50);
                invaderArray2[i].Image = Properties.Resources.extraterrestre;
                invaderArray2[i].Top += 100;
                invaderArray2[i].Tag = "arrayInvader2";
                invaderArray2[i].Left = left2;
                invaderArray2[i].SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(invaderArray2[i]);
                left2 += 100;
            }

            int left3 = 0;
            for (int i = 0; i < invaderArray3.Length; i++)
            {
                invaderArray3[i] = new PictureBox();
                invaderArray3[i].Size = new Size(70, 50);
                invaderArray3[i].Image = Properties.Resources.extraterrestre;
                invaderArray3[i].Top += 200;
                invaderArray3[i].Tag = "arrayInvader3";
                invaderArray3[i].Left = left3;
                invaderArray3[i].SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(invaderArray3[i]);
                left3 += 100;
            }


            
        }
        public void disBalaNave(string balaTag) //SE CREA LA BALA DE LA NAVE
        {
            int X = nave.Location.X;
            int Y = nave.Location.Y;
            bala = new PictureBox();
            bala.Image = Properties.Resources.bullet;
            bala.Size = new Size(5, 20);
            bala.SizeMode = PictureBoxSizeMode.StretchImage;
            bala.Tag = "bala";
            bala.Location = new Point(X + 77, Y);
            this.Controls.Add(bala);
            bala.BringToFront();

        }

        public void disBalainvader(string balaInvaderTag) //SE CREA LA BALA ENEMIGA
        {
            int X = nave.Location.X;
            int Y = 12;
            PictureBox balaInvader = new PictureBox();
            balaInvader.Image = Properties.Resources.Missile;
            balaInvader.Size = new Size(5, 20);
            balaInvader.SizeMode = PictureBoxSizeMode.StretchImage;
            balaInvader.Tag = "balainvader";
            balaInvader.Location = new Point(X + 77, Y);
            this.Controls.Add(balaInvader);
            balaInvader.BringToFront();
        }
        



        private void timer1_Tick(object sender, EventArgs e) //CREA MOVIENTO DE LOS INVADERS
        {
            
            
            foreach (Control x in this.Controls) 
            {                

                if (x is PictureBox && (string)x.Tag == "arrayInvader" || x is PictureBox && (string)x.Tag == "arrayInvader2" || x is PictureBox && (string)x.Tag == "arrayInvader3")
                {

                    x.Left += level.invaderSpeed;


                    if (x.Right < 1275) /*PERMITE QUE LOS INVADERS SE MUEVAN HACIA LA DERECHA*/
                    {
                        
                        x.Left += level.invaderSpeed;

                    }
                    else /*AL LLEGAR AL LIMITE DE LA MARGEN DEL FORM DEJA DE MOVERSE HACIA LA DERECHA*/
                    {


                        x.Left += level.invaderSpeed;
                        timer1.Stop();
                        timer4.Start();
                        


                    }

                    

                    if (x.Right > 1275)/* AL LLEGAR AL LIMITE DE LA MARGEN DERECHA LAS FILAS BAJAN 15 PIXELES*/
                    {

                        //LOS FOR RECORREN CADA UNO DE LOS INVADERS PARA QUE AL TOCAR LA MARGEN DERECHA BAJE A LA MISMA VEZ
                        for (int i = 0; i <= invaderArray.GetUpperBound(0); i++)
                        {
                            
                            invaderArray[i].Top += 15;

                            if (x.Bounds.IntersectsWith(x.Bounds))
                            {
                                invaderArray[i].Left -= 10;
                            }

                        }

                        for (int i = 0; i <= invaderArray2.GetUpperBound(0); i++)
                        {
                            invaderArray2[i].Top += 15;
                            if (x.Bounds.IntersectsWith(x.Bounds))
                            {
                                invaderArray2[i].Left -= 10;
                            }
                        }

                        for (int i = 0; i <= invaderArray3.GetUpperBound(0); i++)
                        {
                            invaderArray3[i].Top += 15;
                            if (x.Bounds.IntersectsWith(x.Bounds))
                            {
                                invaderArray3[i].Left -= 10;
                            }
                        }


                    }
                    
                    
                    if (x.Bounds.IntersectsWith(nave.Bounds)) /*COMPRUEBA SI ALGUN INVADER TOCA LA NAVE Y SI ES ASI SE EJECUTARA EL METODO DEL GAME OVER*/
                    {
                        gameOver();
                    }
                   
                }



            }
            foreach (Control x in this.Controls) /*COMPRUEBA CUANDO LA BALA DE LA NAVE GOLPEA A UN INVADER Y SI ES ASI LO DESAPARECE, COMO TAMBIEN AUMNETA EL PUNTAJE*/
            {
                if (x is PictureBox && (string)x.Tag == "arrayInvader" || x is PictureBox && (string)x.Tag == "arrayInvader2" || x is PictureBox && (string)x.Tag == "arrayInvader3")
                {
                    foreach (Control y in this.Controls) //elimina los enemigos
                    {
                        if (y is PictureBox && (string)y.Tag == "bala")
                        {
                            if (y.Bounds.IntersectsWith(x.Bounds))
                            {
                                this.Controls.Remove(x);
                                this.Controls.Remove(y);
                                level.score += 10;
                                int s = (int.Parse(level.score.ToString()));
                                label3.Text = s.ToString();


                            }

                        }
                    }

                    
                }
            }

        }

        

        private void nave_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e) // CREA EL MOVIMIENTO DE LA BALA DE LA NAVE
        {

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "bala")
                {
                    x.Top -= 20;

                    if (x.Top <= 12)
                    {
                        this.Controls.Remove(x);
                       
                    }

                }
            }

        }

        private void timer3_Tick(object sender, EventArgs e) // CREA EL MOVIMIENTO DE LA BALA ENEMIGA
        {
            level.timeBala -= tiempoBalaEne;

            if (level.timeBala < 12)
            {
                level.timeBala = 300;
                disBalainvader("balainvader");
                
            }
            if (level.score >= 210)
            {
                wineer();
            }


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "balainvader") /* CREA Y COMPRUBA SI LA BALA ENEMIGA TOCA LA NAVE Y SI ES ASI RESTA 1 VIDA, LA CUAL AL LLEGAR A 0 EJECUTA EL METODO GAME OVER*/
                {
                    x.Top += 20;
                    if (x.Top < 0)
                    {
                        this.Controls.Remove(x);

                    }

                    if (x.Bounds.IntersectsWith(nave.Bounds))
                    {
                        player.vida -= 1;
                                            
                        if (player.vida == 2)
                        {
                            this.Controls.Remove(vida1);
                            
                        }
                        else if (player.vida == 1)
                        {
                            this.Controls.Remove(vida2);
                        }
                        else if (player.vida == 0)
                        {
                            this.Controls.Remove(vida3);
                            gameOver();
                        }
                        this.Controls.Remove(x);
                    }
                }
            }
        }

        private void Form2_KeyUp_1(object sender, KeyEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls) /*PERMITE QUE LOS INVADER SE MUEVA DE DERECHA A IZQUIERDA*/
            {
                if (x is PictureBox && (string)x.Tag == "arrayInvader" || x is PictureBox && (string)x.Tag == "arrayInvader2" || x is PictureBox && (string)x.Tag == "arrayInvader3")
                {
                    x.Left -= level.invaderSpeed;

                    

                    if (x.Left > 0)
                    {
                        x.Left -= level.invaderSpeed;
    
                    }
                    else
                    {
                        x.Left -= level.invaderSpeed;
                        timer4.Stop();
                        timer1.Start();


                    }
                    
                    if (x.Bounds.IntersectsWith(nave.Bounds))
                    {
                        gameOver();
                    }

                    foreach (Control y in this.Controls) // CUANDO LA BALA DE LA NAVE TOCA UN INVADER LO ELIMINA
                    {
                        if (y is PictureBox && (string)y.Tag == "bala")
                        {
                            if (y.Bounds.IntersectsWith(x.Bounds))
                            {
                                this.Controls.Remove(x);
                                this.Controls.Remove(y);
                                player.disparo = false;
                                level.score += 10;
                                int s = (int.Parse(level.score.ToString()));
                                label3.Text = s.ToString();
      
                            }
   
                        }
                        
                    }

                }
   
            }

        }

        private void Form2_MouseClick(object sender, MouseEventArgs e) /*CADA QUE SE HACE CLICK EN EL MAUS SE DISPARA UNA BALA DESDE LA NAVE*/
        {
            disBalaNave("bala");
            timer2.Start();
            

        }

        public void gameOver() /*ES EL METOODO CUANDO PIERDE EL JUGADOR. CREA LA VENTA DE GAME OVER*/
        {
            Form3 form3 = new Form3();
            form3.Visible = true;
            this.Dispose();
                
        }

    }
}
