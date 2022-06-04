using ProjetoCalculoSalario.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCalculoSalario.Control
{
    class GerenciadorFuncionarios
    {

        private double totalSalarios;
        private double totalBonificacoes;

        public double TotalSalarios
        {
            get { return totalSalarios; }
            set { totalSalarios = value; }
        }
        public double TotalBonificacoes
        {
            get { return totalBonificacoes; }
            set { totalBonificacoes = value; }
        }

        public GerenciadorFuncionarios()
        {
            TotalSalarios = 0;
            TotalBonificacoes = 0;
        }

        public void Totalizador(Funcionario funcionario) 
        {
            TotalSalarios += funcionario.SalarioFinal;
            TotalBonificacoes += funcionario.ValorBonificacao;
        }
    }
}
