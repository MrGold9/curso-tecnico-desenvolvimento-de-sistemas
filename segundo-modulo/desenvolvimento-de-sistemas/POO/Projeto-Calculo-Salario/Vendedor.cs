using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCalculoSalario.Model
{
    class Vendedor : Funcionario
    {

        private double valorComissao;

        public double ValorComissao
        {
            get { return valorComissao; }
            set { valorComissao = value; }
        }

        public Vendedor()
        {
            Nome = "";
            CPF = "";
            SalarioBase = 0;
            ValorBonificacao = 0;
            SalarioFinal = 0;
            ValorComissao = 0;
        }

        public void CadastrarFuncionario(string nome, string cpf, double salarioBase, double valorComissao)
        {
            Nome = nome;
            CPF = cpf;
            SalarioBase = salarioBase;
            ValorComissao = valorComissao;
        }

        public override string ApresentarSalario()
        {
            return "Nome = " + Nome +
              "\nSalário Base = " + SalarioBase +
              "\nValor Bonificação = " + ValorBonificacao +
              "\nValor Comissão = " + ValorComissao +
              "\nSalário Final = " + SalarioFinal;
        }

        public override double CalcularSalarioFinal()
        {
            SalarioFinal = SalarioBase + ValorBonificacao + ValorComissao;
            return SalarioFinal;
        }

        public override string ListarFuncionario()
        {
            return base.ListarFuncionario() + "\nValor Comissão = " + ValorComissao;
        }
    }
}
