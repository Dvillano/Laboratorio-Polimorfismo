using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPolimorfismo.Transportes
{
    public abstract class Transporte
    {
        protected Transporte(int maxFuel, int maxNroDePasajeros, int velocidad)
        {
            this.MaxFuel = maxFuel;
            this.MaxNroDePasajeros = maxNroDePasajeros;
            this.Velocidad = velocidad;
        }

        public int MaxFuel { get; set; }
        public int MaxNroDePasajeros { get; set; }
        public int Velocidad { get; set; }

        public abstract string Acelerar();
        public abstract string Desacelerar();

    }
}
