using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaHeranca.Model
{
    class Produto
    {
        private string descricao;
        private string genero;
        private int estoqueDisponivel;
        private double precoCusto;
        private double precoVenda;

        public string getDescricao()
        {
            return descricao;
        }
        public void setDescricao(string Descricao)
        {
            descricao = Descricao;
        }

        public string getGenero()
        {
            return genero;
        }
         public void setGenero (string Genero)
        {
            genero = Genero;
        }

        public int getEstoqueDisponivel()
        {
            return estoqueDisponivel;
        }
        public void setEstoqueDisponivel(int EstoqueDisponivel)
        {
            estoqueDisponivel = EstoqueDisponivel;
        }

        public double getPrecoCusto()
        {
            return precoCusto;
        }
        public void setPrecoCusto(double PrecoCusto)
        {
            precoCusto = PrecoCusto;
        }

        public double getPrecoVenda()
        {
            return precoVenda;
        }
        public void setPrecoVenda(double PrecoVenda)
        {
            precoVenda = PrecoVenda;
        }

        public Produto()
        {
            
            descricao = "";
            genero = "";
            estoqueDisponivel = 0;
            precoCusto = 0;
            precoVenda = 0;
        }

        public Produto (string Descricao, string Genero, 
            int EstoqueDisponivel, double PrecoCusto, 
            double PrecoVenda)
        {
            descricao = Descricao;
            genero = Genero;
            estoqueDisponivel = EstoqueDisponivel;
            precoCusto = PrecoCusto;
            precoVenda = PrecoVenda;
        }

        public void Comprar(int qtde) {
            estoqueDisponivel += qtde;
        }
        public void Vender(int qtde)
        {
            estoqueDisponivel -= qtde;
        }
        public virtual void CalcularPrecoVenda()
        {
            precoVenda = precoCusto * 1.1;
        }

        public virtual string ListarProduto()
        {
            return "Descrição: " + descricao +
                "\nGênero: " + genero +
                "\nEstoque Disponível: " + estoqueDisponivel +
                "\nPreço de Custo: " + precoCusto +
                "\nPreço de Venda: " + precoVenda;
        }

    }
}
