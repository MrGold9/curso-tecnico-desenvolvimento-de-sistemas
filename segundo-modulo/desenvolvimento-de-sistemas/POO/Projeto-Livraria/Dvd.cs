using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaHeranca.Model
{
    class Dvd: Produto
    {
        private string diretor;
        private string duracao;
        private string censura;

        public void setDiretor(string Diretor)
        {
            diretor = Diretor;
        }
        public string getDiretor()
        {
            return diretor;
        }
        public void setDuracao(string Duracao)
        {
            duracao = Duracao;
        }
        public string getDuracao()
        {
            return duracao;
        }
        public void setCensura(string Censura)
        {
            censura = Censura;
        }
        public string Censura()
        {
            return censura;
        }
        public Dvd() : base()
        {
            diretor = "";
            duracao = "";
            censura = "";
        }

        public Dvd(string Descricao, string Genero,
            int EstoqueDisponivel, double PrecoCusto,
            double PrecoVenda, string Diretor, string Duracao,
            string Censura) : base(Descricao, Genero,
             EstoqueDisponivel, PrecoCusto,
             PrecoVenda)
        {
            diretor = Diretor;
            duracao = Duracao;
            censura = Censura;
        }

        public override string ListarProduto()
        {
            return base.ListarProduto() +
                "\nDiretor: " + diretor +
                "\nDuração: " + duracao +
                "\nCensura: " + censura;
        }

        public void CalcularPrecoVenda(double cotacaoDolar)
        {
            setPrecoVenda(getPrecoCusto() * cotacaoDolar);
        }
    }
}
