using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ValidarUsuario.Model
{
    class Operador: Funcionario
    {
        private string cargo;
        private double comissao;

        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

        public double Comissao
        {
            get { return comissao; }
            set { comissao = value; }
        }

        public Operador()
        {
            setNome("");
            setLogin("");
            setSenha("");
            setAtivo(false);
            setSalarioBase(0);
            Cargo = "";
            Comissao = 0;
        }

        public Operador(string nome, string login, string senha, bool ativo,
            double salarioBase, string cargo, double comissao)
        {
            setNome(nome);
            setLogin(login);
            setSenha(senha);
            setAtivo(ativo);
            setSalarioBase(salarioBase);
            Cargo = cargo;
            Comissao = comissao;
        }
        public void CadastrarOperador(string nome, string login, string senha, 
            double salarioBase, string cargo, double comissao)
        {
            setNome(nome);
            setLogin(login);
            setSenha(senha);
            setAtivo(false);
            setSalarioBase(salarioBase);
            Cargo = cargo;
            Comissao = comissao;
        }

        public string ApresentarOperador()
        {
            return "Nome=" + getNome() +
                "\nLogin=" + getLogin() +
                "\nSenha=" + getSenha() +
                "\nAtivo=" + getAtivo() +
                "\nSalario Base =" + getSalarioBase() +
                "\nCargo=" + Cargo +
                "\nComissão=" + Comissao;
        }

        public string CalcularSalario()
        {
            return "Nome=" + getNome()+
                "\nSalario Final=" + (getSalarioBase()+Comissao); 
        }
    }
}
