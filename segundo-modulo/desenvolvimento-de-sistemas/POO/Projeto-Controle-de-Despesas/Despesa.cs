using System;
using System.Collections.Generic;
using System.Text;

namespace Despesas
{
    abstract class Despesa
    {

        public String descricao { get; set; }
        public double valorTotal { get; set; }

        public void cadastrarDespesa(String Descricao)
        {
            descricao = Descricao;
            valorTotal = 0;
        }

        public abstract String listarDespesa();
    }
}
