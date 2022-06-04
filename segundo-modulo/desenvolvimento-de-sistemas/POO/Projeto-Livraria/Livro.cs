using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaHeranca.Model
{
    class Livro: Produto
    {
        private string autor;
        private string editora;
        private string edicao;

        public void setAutor (string Autor)
        {
            autor = Autor;
        }
        public string getAutor()
        {
            return autor;
        }

        public void setEditora (string Editora)
        {
            editora = Editora;
        }
        public string getEditora()
        {
            return editora;
        }
        public void setEdicao (string Edicao)
        {
            edicao = Edicao;
        }

        public Livro(): base()
        {
            autor = "";
            editora = "";
            edicao = "";
        }

        public Livro(string Descricao, string Genero,
            int EstoqueDisponivel, double PrecoCusto,
            double PrecoVenda, string Autor, string Editora, 
            string Edicao): base (Descricao,  Genero,
             EstoqueDisponivel,  PrecoCusto,
             PrecoVenda) {
            autor = Autor;
            editora = Editora;
            edicao = Edicao;
        }

        public override string ListarProduto()
        {
            return base.ListarProduto() +
                "\nAutor: " + autor +
                "\nEditora: " + editora +
                "\nEdicao: " + edicao;
        }
    }
}
