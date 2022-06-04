using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancarioPolimorfismo.Model
{
    abstract class Conta
    {
        private double Saldo;

        public double getSaldo()
        {
            return Saldo;
        }
        public void setSaldo(double saldo)
        {
            Saldo = saldo;
        }

        public Conta()
        {
            Saldo = 0;
        }

        public Conta (double saldo)
        {
            Saldo = saldo;
        }
        
        public void creditar(double valor)
        {
            Saldo += valor;
        }

        public virtual bool debitar (double valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                return true;
            }
            return false;
        }

        public virtual void transferir (double valor, Conta destino)
        {
            if (debitar(valor))
            {
                destino.creditar(valor);
            }
        }

        public abstract void atualizarSaldo();

    }
}
