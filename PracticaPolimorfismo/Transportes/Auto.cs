using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPolimorfismo.Transportes
{
    public class Auto : Transporte
    {
        public Auto(int maxFuel, int maxNroDePasajeros, string modelo, int velocidad) : base (maxFuel, maxNroDePasajeros, velocidad)
        {
            Modelo = modelo;
        }

        public string Modelo { get; set; }

        public override string Acelerar()
        {
            return "Esta funcion acelera el vehiculo: Auto" ;
        }

        public override string Desacelerar()
        {
            return "Esta funcion desacelera el vehiculo: Auto";
        }

        public string DoblarAIzq()
        {
            return "Doblando a la izquierda";
        }

        public string DoblarADer()
        {
            return "Doblando a la derecha";
        }
    }
}
