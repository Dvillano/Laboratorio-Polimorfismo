using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPolimorfismo.Ajedrez
{
    public class Peon : PiezaAjedrez
    {
        public override string Mover()
        {
            return "Esta pieza solo avanza hacia adelante";
        }
    }
}
