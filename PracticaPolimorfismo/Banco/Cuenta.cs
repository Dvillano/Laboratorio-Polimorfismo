using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPolimorfismo.Banco
{
    public  abstract class Cuenta
    {
        public Cuenta(int idCuenta)
        {
            this.IdCuenta = idCuenta;
        }

        public int IdCuenta { get; set; }

        public virtual string CalcularInteres()
        {
            return "Calculando el interes de: ";
        }
    }


}
