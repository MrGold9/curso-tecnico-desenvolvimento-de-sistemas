using System;
using System.Collections.Generic;
using System.Text;

namespace Despesas
{
    class GerenciadorDespesas
    {
        public int qtdeAlimentacao { get; set;}
        public int qtdeTransporte { get; set;}
        public int qtdeDiaria { get; set;}

        public double totalAlimentacao { get; set; }
        public double totalTransporte { get; set; }
        public double totalDiaria { get; set; }
        public double totalDespesas { get; set; }

        public GerenciadorDespesas()
        {
            int qtdeAlimentacao = 0;
            int qtdeTransporte = 0;
            int qtdeDiaria = 0;

            double totalAlimentacao = 0;
            double totalTransporte = 0;
            double totalDiaria = 0;
            double totalDespesas = 0;
        }

        public GerenciadorDespesas(int QtdeAlimentacao, int QtdeTransporte, int QtdeDiaria, double TotalAlimentacao, double TotalTransporte, double TotalDiaria, double TotalDespesas)
        {
            int qtdeAlimentacao = QtdeAlimentacao;
            int qtdeTransporte = QtdeTransporte;
            int qtdeDiaria = QtdeDiaria;

            double totalAlimentacao = TotalAlimentacao;
            double totalTransporte = TotalTransporte;
            double totalDiaria = TotalDiaria;
            double totalDespesas = TotalDespesas;
        }

        public void analisarDespesas(Despesa despesa)
        {
            if (despesa.GetType().Name == "Alimentacao")
            {
                totalAlimentacao += despesa.valorTotal;
                qtdeAlimentacao += 1;
            }
            else if (despesa.GetType().Name == "Transporte")
            {
                totalTransporte += despesa.valorTotal;
                qtdeTransporte += 1;
            }
            else
            {
                totalDiaria += despesa.valorTotal;
                qtdeDiaria += 1;
            }

            totalDespesas = totalAlimentacao + totalTransporte + totalDiaria;
        }

        public String listarDespesas()
        {
            return "Total gasto em alimentação: " + totalAlimentacao + "\nTotal de despesas em alimentação: " + qtdeAlimentacao + "\n\nTotal gasto em transporte: " + totalTransporte + "\nTotal de despesas em transporte: " + qtdeTransporte + "\n\nTotal gasto em diárias: " + totalDiaria + "\nTotal de despesas em diárias: " + qtdeDiaria + "\n\nTotal gasto em despesas: " + totalDespesas;
        }
    }
}
