using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancario.Model
{
    class ContaCorrente: Conta
    {
        private double limite;
        private double jurosChequeEspecial;

        public double getLimite()
        {
            return limite;
        }
        public void setLimite(double Limite)
        {
            if (Limite > 0)
            {
                limite = Limite;
            }
        }

        public double getJurosChequeEspecial()
        {
            return jurosChequeEspecial;
        }
        public void setJurosChequeEspecial(double Juros)
        {
            jurosChequeEspecial = Juros;
        }

        public ContaCorrente(): base ()
        {
            limite = 0;
            jurosChequeEspecial = 0;
        }

        public ContaCorrente (int Numero, double Saldo, double Limite, double Juros): base (Saldo, Numero)
        {
            limite = Limite;
            jurosChequeEspecial = Juros;
        }

        public override bool Sacar(double valor)
        {
            if (valor <=GetSaldo()+limite)
            {
                SetSaldo(GetSaldo()-valor);
                return true;
            }
            return false;
        }
        public void calcularJuros(double taxa)
        {
            if (GetSaldo() < 0)
            {
                jurosChequeEspecial = (GetSaldo() * taxa)/100;
            }
        }

        public override string ConsultarSaldo()
        {
            return base.ConsultarSaldo() + "\nLimite = " + limite + 
                "\nDisponível = " + (GetSaldo() + limite);
        }
    }
}
