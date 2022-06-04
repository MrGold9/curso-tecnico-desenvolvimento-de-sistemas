using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldHeranca.Model
{
    class ModeloHeranca: Modelo
    {
        //atributos
        private  string Mensagem ;

        public string getMensagem ()
        {
            return Mensagem;
        }
        public void setMensagem (string mensagem)
        {
            Mensagem = mensagem;
        }

        //construtores
        public ModeloHeranca(): base()
        {
            Mensagem = "Hello World!";
        }
        public ModeloHeranca(string nome): base (nome) {
            Mensagem = "Hello World!";
        }
        public ModeloHeranca (string nome, string mensagem): base(nome)
        {
            Mensagem = mensagem;
        }

        //métodos
        public override string exibir()
        {
            return Mensagem + " " + getNome();
        }
    }
}
