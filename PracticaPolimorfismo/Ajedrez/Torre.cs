using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPolimorfismo.Ajedrez
{
    public class Torre : PiezaAjedrez
    {
        public override string Mover()
        {
            return "Esta pieza solo se mueve en linea recta"; 
        }
    }
}
