using System;
using System.Collections.Generic;
using System.Text;

namespace Despesas
{
    class Transporte : Despesa
    {
        public double kmPercorrida { get; set; }
        public double valorPedagio { get; set; }

        public Transporte()
        {
            kmPercorrida = 0;
            valorPedagio = 0;
        }

        public Transporte(double KmPercorrida, double ValorPedagio)
        {
            kmPercorrida = KmPercorrida;
            valorPedagio = ValorPedagio;
        }

        public void calcularDespesa(double KmPercorrida, double ValorPedagio)
        {
            kmPercorrida = KmPercorrida;
            valorPedagio = ValorPedagio;

            valorTotal = kmPercorrida * 3 + valorPedagio;
        }

        public override String listarDespesa()
        {
            return "Descrição: " + descricao + "\nKm Percorrida: " + kmPercorrida + "\nValor do Pedágio: " + valorPedagio + "\nValor Total: " + valorTotal;
        }
    }
}
