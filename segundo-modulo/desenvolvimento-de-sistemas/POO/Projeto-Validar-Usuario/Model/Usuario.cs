using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidarUsuario.Model
{
    abstract class Usuario
    {
        private string nome;
        private string login;
        private string senha;
        private bool ativo;

        public string getNome()
        {
            return nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getLogin()
        {
            return login;
        }
        public void setLogin(string login)
        {
            this.login = login;
        }

        public string getSenha()
        {
            return senha;
        }
        public void setSenha(string senha)
        {
            this.senha = senha;
        }

        public bool getAtivo()
        {
            return ativo;
        }
        public void setAtivo(bool ativo)
        {
            this.ativo = ativo;
        }
    }
}
