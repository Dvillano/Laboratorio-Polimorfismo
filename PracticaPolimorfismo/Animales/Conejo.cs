using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPolimorfismo.Animales
{
    public class Conejo : Animal
    {
        public Conejo(string edad, string altura, string peso, string raza, string comida) : base(edad, altura, peso)
        {
            Raza = raza;
            Comida = comida;
        }

        public string Raza { get; set; }
        public string Comida { get; set; }


        public override string imprimirComida()
        {
            return "El conejo come: " + Comida;
        }
    }
}
