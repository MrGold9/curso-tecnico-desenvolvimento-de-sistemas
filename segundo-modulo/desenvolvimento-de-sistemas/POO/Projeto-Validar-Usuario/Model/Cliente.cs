using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ValidarUsuario.Model
{
    class Cliente : Usuario
    {
        private string cpf;
        private double rendaMensal;
        private double limiteCredito;

        public string CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public double RendaMensal
        {
            get { return rendaMensal; }
            set { rendaMensal = value; }
        }

        public double LimiteCredito
        {
            get { return limiteCredito; }
            set { limiteCredito = value; }
        }

        public Cliente()
        {
            setNome("");
            setLogin("");
            setSenha("");
            setAtivo(false);
            cpf = "";
            rendaMensal = 0;
            limiteCredito = 0;
        }
        public Cliente(string nome, string login, string senha, bool ativo,
            string cpf, double rendaMensal, double limiteCredito)
        {
            this.setNome(nome);
            this.setLogin(login);
            this.setSenha(senha);
            this.setAtivo(ativo);
            this.cpf = cpf;
            this.rendaMensal = rendaMensal;
            this.limiteCredito = limiteCredito;
        }

        public void CadastrarCliente(string nome, string login, string senha, 
            string cpf, double rendaMensal)
        {
            setNome(nome);
            setLogin(login);
            setSenha(senha);
            setAtivo(false);
            CPF = cpf;
            RendaMensal = rendaMensal;
            LimiteCredito = 0;
        }

        public string ApresentarCliente()
        {
            return "Nome=" + getNome() +
                "\nLogin=" + getLogin() +
                "\nSenha=" + getSenha() +
                "\nAtivo=" + getAtivo() +
                "\nCPF=" + CPF +
                "\nRenda Mensal=" + RendaMensal +
                "\nLimite de Crédito =" + LimiteCredito;
        }


    }
}
