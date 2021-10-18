using PracticaPolimorfismo.Ajedrez;
using PracticaPolimorfismo.Transportes;
using PracticaPolimorfismo.Animales;
using PracticaPolimorfismo.Banco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PracticaPolimorfismo;

namespace WindowsFormsAppPolimorfismo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearInstanciasAjedrez_Click(object sender, EventArgs e)
        {
            Peon peon = new Peon();
            Caballo caballo = new Caballo();
            Torre torre = new Torre();

            MessageBox.Show("Peon: " + peon.Mover() +
                            "\nCaballo: " + caballo.Mover() +
                            "\nTorre: " + torre.Mover());
        }

        private void btnCrearInstanciasTransporte_Click(object sender, EventArgs e)
        {
            Auto auto = new Auto(50, 20, "Audi ", 300);
            MessageBox.Show(auto.Acelerar() + auto.Desacelerar() + auto.DoblarAIzq() + auto.DoblarADer());

        }

        private void btnCrearInstanciasAnimales_Click(object sender, EventArgs e)
        {
            Leon leon = new Leon("10 años" , "1.50 metros" , "150 Kg", "Amarillo", "Carne");
            MessageBox.Show("Leon\n" + leon.imprimir() + 
                            "\nComida: " + leon.imprimirComida());

            Conejo conejo = new Conejo("3 años", "0.30 metros", "3 Kg", "Holland Lop", "Heno");
            MessageBox.Show("Conejo\n" + conejo.imprimir() +
                            "\nComida: " + conejo.imprimirComida());

            Loro loro = new Loro("1 años", "0.20 metros", "1 Kg", "Costa Rica", "Semillas");
            MessageBox.Show("Loro\n" + loro.imprimir() +
                            "\nComida: " + loro.imprimirComida());
        }

        private void btnCrearInstanciasBanco_Click(object sender, EventArgs e)
        {
            CuentaAhorro cuentaAhorro = new CuentaAhorro(1);
            MessageBox.Show("Cuenta de ahorro ID: " + cuentaAhorro.IdCuenta +
                            "\n" + cuentaAhorro.CalcularInteres());

            CuentaCorriente cuentaCorriente = new CuentaCorriente(1);
            MessageBox.Show("Cuenta corriente ID: " + cuentaCorriente.IdCuenta +
                            "\n" + cuentaCorriente.CalcularInteres());

        }
    }
}
