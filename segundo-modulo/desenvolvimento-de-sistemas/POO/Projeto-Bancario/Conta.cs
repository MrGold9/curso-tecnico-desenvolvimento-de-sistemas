using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancario
{
    class Conta
    {
        private double saldo { get; set; }
        private int numero;

        public int GetNumero()
        {
            return numero;
        }
        public void SetNumero(int Numero)
        {
            numero = Numero;
        }

        public Conta()
        {
            saldo = 0;
            numero = 0;
        }

        public Conta (double Saldo, int Numero)
        {
            saldo = Saldo;
            numero = Numero;
        }

        public Conta (int Numero)
        {
            saldo = 0;
            numero = Numero;
        }

        public void Depositar(double valor)
        {
            saldo = saldo + valor;
        }

        public Boolean Sacar (double valor)
        {
            if (valor <=saldo)
            {
                saldo -= valor;
                return true;
            }
            return false;
        }
        public bool Transferir (double valor, Conta destino)
        {
            if (Sacar(valor))
            {
                destino.Depositar(valor);
                return true;
            }
            return false;
        }
        public string ConsultarSaldo()
        {
            return "Saldo atual = " + saldo;
        }
    }
}
