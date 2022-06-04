using ProjetoBancarioPolimorfismo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancarioPolimorfismo.Control
{
    class GerenciadorContas
    {
        private double SaldoTotal;

        public double getSaldoTotal()
        {
            return SaldoTotal;
        }
        public void setSaldoTotal(double saldoTotal)
        {
            SaldoTotal = saldoTotal;
        }

        public GerenciadorContas()
        {
            SaldoTotal = 0;
        }
        public GerenciadorContas(double saldoTotal)
        {
            SaldoTotal = saldoTotal;
        }

        public void totalizarSaldo(Conta conta)
        {
            SaldoTotal += conta.getSaldo();
        }
    }
}
