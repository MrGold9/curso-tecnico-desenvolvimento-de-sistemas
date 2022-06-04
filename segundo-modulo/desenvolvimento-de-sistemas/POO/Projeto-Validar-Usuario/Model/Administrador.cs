using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidarUsuario.Model
{
    class Administrador: Funcionario
    {
        private int codigoLiberacao;

        public int CodigoLiberacao
        {
            get { return codigoLiberacao; }
            set { codigoLiberacao = value; }
        }

        public Administrador()
        {
            setNome("");
            setLogin("");
            setSenha("");
            setAtivo(false);
            setSalarioBase(0);
            codigoLiberacao = 0;
        }

        public Administrador(string nome, string login, string senha, bool ativo,
            double salarioBase, int codigoLiberacao)
        {
            setNome(nome);
            setLogin(login);
            setSenha(senha);
            setAtivo(ativo);
            setSalarioBase(salarioBase);
            this.codigoLiberacao = codigoLiberacao;
        }

        public string autorizarUsuario(int cod, Usuario usu)
        {
            if (cod == codigoLiberacao )
            {
                usu.setAtivo(true);
                return usu.GetType().Name + " - Autorizado!";
            }
            return usu.GetType().Name+" - Não autorizado!";
        }

        public string calcularLimiteCredito(int cod, Cliente cli)
        {
            if (cod== codigoLiberacao)
            {
                cli.LimiteCredito = cli.RendaMensal * 0.4;
                return "Limite de Crédito = " + cli.LimiteCredito;
            }
            return "Usuário não tem permissão para esta operação!";
        }
    }
}
