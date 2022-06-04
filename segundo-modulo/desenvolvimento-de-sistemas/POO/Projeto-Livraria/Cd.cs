using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaHeranca.Model
{
    class Cd: Produto
    {
        private string artista;
        private string gravadora;
        private string paisOrigem;

        public void setArtista(string Artista)
        {
            artista = Artista;
        }
        public string getArtista()
        {
            return artista;
        }
        public void setGravadora(string Gravadora)
        {
            gravadora = Gravadora;
        }
        public string getGravadora()
        {
            return gravadora;
        }
        public void setPaisOrigem(string PaisOrigem)
        {
            paisOrigem = PaisOrigem;
        }
        public string PaisOrigem()
        {
            return paisOrigem;
        }

        public Cd() : base (){
            artista = "";
            gravadora = "";
            paisOrigem = "";
        }

        public Cd(string Descricao, string Genero,
            int EstoqueDisponivel, double PrecoCusto,
            double PrecoVenda, string Artista, string Gravadora,
            string PaisOrigem) : base(Descricao, Genero,
             EstoqueDisponivel, PrecoCusto,
             PrecoVenda)
        {
            artista = Artista;
            gravadora = Gravadora;
            paisOrigem = PaisOrigem;
        }

        public override string ListarProduto()
        {
            return base.ListarProduto() +
                "\nArtista: " + artista +
                "\nGravadora: " + gravadora +
                "\nPaís de Origem: " + paisOrigem;
        }

        public override void CalcularPrecoVenda()
        {
            setPrecoVenda(getPrecoCusto() * 1.15);
        }
    }
}
