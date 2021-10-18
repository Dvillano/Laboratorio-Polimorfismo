using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPolimorfismo.Animales
{
    public abstract class Animal
    {
        public Animal(string edad, string altura, string peso)
        {
            Edad = edad;
            Altura = altura;
            Peso = peso;
        }

        public string Edad { get ;   }
        public string Altura { get; }
        public string Peso { get;  }

        public virtual string imprimir ()
        {
            return "Edad: " + Edad + "\nAltura: " + Altura + "\nPeso: " + Peso; 
        }


        public abstract string imprimirComida();
    }
}
