using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancarioPolimorfismo.Model
{
    class ContaCorrente : Conta
    {
        private double LimiteEspecial;

        public double getLimiteEspecial()
        {
            return LimiteEspecial;
        }
        public void setLimiteEspecial(double limiteEspecial)
        {
            LimiteEspecial = limiteEspecial;
        }

        public ContaCorrente() 
        {
            setSaldo(0);
            LimiteEspecial = 0;
        }

        public ContaCorrente(double saldo, double limiteEspecial) 
        {
            setSaldo(saldo);
            LimiteEspecial = limiteEspecial;
        }

        public override bool debitar(double valor)
        {
            if ((getSaldo()+LimiteEspecial) >= valor)
            {
                setSaldo(getSaldo()- valor);
                return true;
            }
            return false;
        }

        public override void transferir(double valor, Conta destino)
        {
            if (debitar(valor))
            {
                destino.creditar(valor);
            }
        }

        public override void atualizarSaldo()
        {
            if (getSaldo() < 0)
            {
               setSaldo(getSaldo() + getSaldo() * 0.08);
            }
           
        }

        public string ConsultarSaldo()
        {
            return "Saldo = " + getSaldo() +
                "\nLimite = " + LimiteEspecial +
                "\nDisponível = " + (getSaldo() + LimiteEspecial);
        }
    }
}
