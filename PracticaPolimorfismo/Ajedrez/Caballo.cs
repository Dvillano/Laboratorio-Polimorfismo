using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPolimorfismo.Ajedrez
{
    public class Caballo : PiezaAjedrez
    {
        public override string Mover()
        {
            return "Esta pieza solo avanza en forma de L";
        }
    }
}
