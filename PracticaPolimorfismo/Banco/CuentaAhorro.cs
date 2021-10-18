using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPolimorfismo.Banco
{
    public class CuentaAhorro : Cuenta
    {
        public CuentaAhorro(int idcuenta) : base(idcuenta) { }

        public override string CalcularInteres()
        {
            return base.CalcularInteres() + "Cuenta Ahorro";
        }
    }
}
