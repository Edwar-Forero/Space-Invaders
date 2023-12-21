using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvader_1._2
{
    internal class Movimientos
    {
        public int tituloX = 0;
        public int tituloY = 0;

        public void moviemintoder()
        {
            tituloX += 10;
            tituloY = tituloY;
        }

        public void movimientoizq()
        {
            tituloX -= 10;
            tituloY = tituloY;
        }
    }
}
