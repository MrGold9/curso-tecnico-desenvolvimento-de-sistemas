using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldHeranca.Model
{
    class Modelo
    {
        //atributos
        private string Nome;

            public void setNome (string nome)
        {
            Nome = nome;
        }

        public string getNome()
        {
            return Nome;
        }

        //construtores
        public Modelo() 
        {
            Nome = "";
        }
        public Modelo (string nome)
        {
            Nome = nome;
        }

        //métodos
        public virtual string exibir()
        {
            return Nome;
        }

    }
}
