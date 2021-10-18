using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPolimorfismo.Transportes
{
    public class Avion : Transporte
    {
        public Avion(int maxAltitud, int maxFuel, int maxNroDePasajeros, string modelo, int velocidad, int nroDeMotores) : base (maxFuel, maxNroDePasajeros, velocidad)
        {
            MaxAltitud = maxAltitud;
            NroDeMotores = nroDeMotores;
        }

        public int MaxAltitud { get; set; }
        public int NroDeMotores { get; set; }

        public override string Acelerar()
        {
            return "Esta funcion acelera el vehiculo: Avion";
        }

        public override string Desacelerar()
        {
            return "ESta funcion desacelera el vehiculo: Avion";
        }

        public string Ascender()
        {
            return "Ascendiendo avion";
        }

        public string Descender()
        {
            return "Descendiendo avion";
        }
    }



}
