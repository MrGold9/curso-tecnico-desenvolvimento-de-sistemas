using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancario.Model
{
    class ContaPoupanca: Conta 
    {
        private double reajusteMensal;

        public void SetReajusteMensal (double reajuste)
        {
            reajusteMensal = reajuste;
        }
        public double GetReajusteMensal()
        {
            return reajusteMensal;
        }

        public ContaPoupanca(): base ()
        {
            reajusteMensal = 0;
        }
        public ContaPoupanca(double Saldo, int Numero, double Reajuste): base (Saldo, Numero)
        {
            reajusteMensal = Reajuste;
        }

        public void CalcularRendimento (double taxa)
        {
            if (GetSaldo() > 0)
            {
                reajusteMensal = (GetSaldo() * taxa) / 100;
                AtualizarSaldo();
            }
            
        }
        private void AtualizarSaldo()
        {
            SetSaldo(GetSaldo() + reajusteMensal);
        }
    }
}
