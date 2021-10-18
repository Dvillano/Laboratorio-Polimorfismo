using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPolimorfismo.Animales
{
    public class Loro : Animal
    {
        public Loro(string edad, string altura, string peso, string paisdeorigen, string comida) : base(edad, altura, peso)
        {
            PaisDeOrigen = paisdeorigen;
            Comida = comida;
        }

        public string PaisDeOrigen { get; set; }
        public string Comida { get; set; }


        public override string imprimirComida()
        {
            return "El Loro come: " + Comida;
        }
    }
}
