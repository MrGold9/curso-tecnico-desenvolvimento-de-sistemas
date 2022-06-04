using System;
using System.Collections.Generic;
using System.Text;

namespace Despesas
{
    class Alimentacao : Despesa
    {
        public String nomeRestaurante { get; set; }

        public Alimentacao()
        {
            nomeRestaurante = "";
        }
        public Alimentacao (String NomeRestaurante)
        {
            nomeRestaurante = NomeRestaurante;
        }

        public void calcularDespesa(int quantRefeicoes)
        {
            valorTotal = quantRefeicoes * 18;
        }

        public void cadastrarDespesa(String Descricao, String NomeRestaurante)
        {
            descricao = Descricao;
            nomeRestaurante = NomeRestaurante;
            valorTotal = 0;
        }

        public override String listarDespesa()
        {
            return "Nome do Restaurante: " + nomeRestaurante + "\nDescrição: " + descricao + "\nValor Total: " + valorTotal;
        }
    }
}
