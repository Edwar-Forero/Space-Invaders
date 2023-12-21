using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvader_1._2
{
    internal class PLAYER
    {
        //SE CREAN LAS VARIABLES NESESARIAS PARA TODAS LAS FUNCIONES DE LA NAVE
        public int naveX; //GUARDA LA POSICION EN X DE LA NAVE
        public int naveY; //GUARDA LA POSICION EN Y DE LA NAVE
        public int naveSpeed; // DETERMINA LA VELOCIDAD DE LA NAVE
        public int balax; //GUARDA LA POSICION EN X DE LA BALA
        public int balay; //GUARDA LA POSICION EN Y DE LA BALA
        public bool goRight = true, goLeft = true; /*DETERMINA SI EL METODO DE IZQUIERDA O DERECHA ESTA ACTIVA*/
        public bool disparo = false; 
        public bool isGameOver; 
        public int vida = 3; // LA CANTIDAD DE VIDAS
        

        public void naveMoviminetoizq() /*METODO QUE PERMITE EL MOVIMIENTO DE LA NAVE HACIA LA IZQUIERDA*/
        {
            if (goLeft == true)
            {
                naveX -= naveSpeed;
                naveY = naveY;
            }

        }
        public void naveMovimientoder()/*METODO QUE PERMITE EL MOVIMIENTO DE LA NAVE HACIA LA DERECHA*/
        {
            if (goRight == true)
            {
                naveX += naveSpeed;
                naveY = naveY;
            }

        }
    }
}
