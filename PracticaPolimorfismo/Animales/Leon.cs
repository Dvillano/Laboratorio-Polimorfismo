using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPolimorfismo.Animales
{
    public class Leon : Animal
    {
        public Leon(string edad, string altura, string peso, string colordepelo, string comida) : base(edad, altura, peso)
        {
            ColorDePelo = colordepelo;
            Comida = comida;
        }

        public string ColorDePelo { get; set; }
        public string Comida { get; set; }


        public override string imprimirComida()
        {
            return "El leon come: " + Comida;
        }
    }
}
