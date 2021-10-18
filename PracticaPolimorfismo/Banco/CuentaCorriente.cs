using PracticaPolimorfismo.Banco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPolimorfismo
{
    public class CuentaCorriente : Cuenta
    {
        public CuentaCorriente(int idcuenta) : base(idcuenta) { }

        public override string CalcularInteres()
        {
            return base.CalcularInteres() +  "Cuenta Corriente";
        }

    }
}
