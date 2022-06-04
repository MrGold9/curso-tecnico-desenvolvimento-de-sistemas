using System;
using System.Collections.Generic;
using System.Text;

namespace Despesas
{
    class Diaria : Despesa
    {
        public double qtdeDiaria { get; set; }

        public Diaria()
        {
            qtdeDiaria = 0;
        }

        public Diaria(double QtdeDiaria)
        {
            qtdeDiaria = QtdeDiaria;
        }

        public void calcularDespesa(double QtdeDiaria)
        {
            qtdeDiaria = QtdeDiaria;

            valorTotal = qtdeDiaria * 50;
        }

        public override String listarDespesa()
        {
            return "Descrição: " + descricao + "Quantidade Diária: " + qtdeDiaria + "\nValor Total: " + valorTotal;
        }
    }
}
