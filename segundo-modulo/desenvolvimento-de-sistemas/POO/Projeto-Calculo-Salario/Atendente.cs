using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCalculoSalario.Model
{
    class Atendente : Funcionario
    {

        private double adicionalNoturno;

        public double AdicionalNoturno
        {
            get { return adicionalNoturno; }
            set { adicionalNoturno = value; }
        }

        public Atendente()
        {
            Nome = "";
            CPF = "";
            SalarioBase = 0;
            ValorBonificacao = 0;
            SalarioFinal = 0;
            AdicionalNoturno = 0;
        }

        public void CadastrarFuncionario(string nome, string cpf, double salarioBase, double adicionalNoturno)
        {
            Nome = nome;
            CPF = cpf;
            SalarioBase = salarioBase;
            AdicionalNoturno = adicionalNoturno;
        }

        public override string ApresentarSalario()
        {
            return "Nome = " + Nome +
               "\nSalário Base = " + SalarioBase +
               "\nValor Bonificação = " + ValorBonificacao +
               "\nValor Adicional Noturno = " + AdicionalNoturno +
               "\nSalário Final = " + SalarioFinal;
        }

        public override double CalcularSalarioFinal()
        {
            SalarioFinal = SalarioBase + ValorBonificacao + AdicionalNoturno;
            return SalarioFinal;
        }
    }
}
