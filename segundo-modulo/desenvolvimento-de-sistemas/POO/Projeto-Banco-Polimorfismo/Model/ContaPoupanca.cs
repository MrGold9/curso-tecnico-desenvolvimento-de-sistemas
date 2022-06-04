using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancarioPolimorfismo.Model
{
    class ContaPoupanca : Conta
    {

        private double ReajusteMensal;

        public double getReajusteMensal()
        {
            return ReajusteMensal;
        }
        public void setReajusteMensal(double reajusteMensal)
        {
            ReajusteMensal = reajusteMensal;
        }

        public ContaPoupanca()
        {
            setSaldo(0);
            ReajusteMensal = 0;
        }

        public ContaPoupanca(double saldo, double reajusteMensal)  
        {
            setSaldo(saldo);
            ReajusteMensal = reajusteMensal;
        }



        public override void atualizarSaldo()
        {
            throw new NotImplementedException();
        }

        public void atualizarSaldo(double reajuste)
        {
            if (getSaldo() >0)
            {
                setSaldo(getSaldo() + (getSaldo() * reajuste));
            }
        }
    }
}
