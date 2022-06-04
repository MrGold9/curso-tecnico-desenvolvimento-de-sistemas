using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCalculoSalario.Model
{
    class Gerente : Funcionario
    {
        private double gratificacao;

        public double Gratificacao
        {
            get { return gratificacao; }
            set { gratificacao = value; }
        }

        public Gerente()
        {
            this.Nome = "";
            this.CPF = "";
            this.SalarioBase = 0;
            this.ValorBonificacao = 0;
            this.SalarioFinal = 0;
            this.Gratificacao = 0;
        }

        public override string ListarFuncionario()
        {
            return base.ListarFuncionario() + "\nGratificação = " + gratificacao;
        }
        public override string ApresentarSalario()
        {
            return "Nome = " + Nome +
               "\nSalário Base = " + SalarioBase +
               "\nValor Bonificação = " + ValorBonificacao +
               "\nValor Gratificação = " + Gratificacao +
               "\nSalário Final = " + SalarioFinal;
        }

        public void CadastrarFuncionario(string nome, string cpf, double salarioBase,  double gratificacao)
        {
            Nome = nome;
            CPF = cpf;
            SalarioBase = salarioBase;
            Gratificacao = gratificacao;
        }

        public override double CalcularSalarioFinal()
        {
            SalarioFinal = SalarioBase + ValorBonificacao + Gratificacao;
            return SalarioFinal;
        }
    }
}
