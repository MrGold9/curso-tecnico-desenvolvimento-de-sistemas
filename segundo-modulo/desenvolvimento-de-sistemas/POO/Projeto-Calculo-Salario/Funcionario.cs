using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCalculoSalario.Model
{
    abstract class Funcionario
    {
        private string nome;
        private string cpf;
        private double salarioBase;
        private double salarioFinal;
        private double valorBonificacao;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string CPF
        {
            get { return cpf; }
            set { cpf = value;  }
        }
        public double SalarioBase
        {
            get { return salarioBase; }
            set { salarioBase = value; }
        }

        public double SalarioFinal
        {
            get { return salarioFinal; }
            set { salarioFinal = value; }
        }

        public double ValorBonificacao
        {
            get { return valorBonificacao; }
            set { valorBonificacao = value; }
        }

        public void CalcularBonificacao()
        {
            ValorBonificacao=salarioBase * 0.05;
        }

        public void CadastrarFuncionario(string nome, string cpf, double salarioBase)
        {
            Nome = nome;
            CPF = cpf;
            SalarioBase = salarioBase;
            SalarioFinal = 0;
            ValorBonificacao = 0;
        }
        
        public virtual string ListarFuncionario()
        {
            return "Nome = " + Nome +
                "\nCPF= " + CPF +
                "\nSalário Base = " + SalarioBase +
                "\nValor Bonificação = " + ValorBonificacao +
                "\nSalário Final = " + SalarioFinal;
        }

        public abstract  double CalcularSalarioFinal();

        public abstract  string ApresentarSalario(); 
        
    }

}
