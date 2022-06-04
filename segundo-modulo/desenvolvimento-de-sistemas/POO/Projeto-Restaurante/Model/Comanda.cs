using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRestaurante.Model
{
    class Comanda
    {
        private int id;
        private double valorConsumo;
        private double valorEstacionamento;
        private double valorCouvert;
        private double valorDescontoPromocional;
        private double valorTotal;

        public int getId()
        {
            return id;
        }
        public void setId(int Id)
        {
            id = Id;
        }

        public double getValorConsumo()
        {
            return valorConsumo;
        }
        public void setValorConsumo(double ValorConsumo)
        {
            valorConsumo = ValorConsumo;
        }

        public double getValorEstacionamento()
        {
            return valorEstacionamento;
        }
        public void setValorEstacionamento(double ValorEstacionamento)
        {
            valorEstacionamento = ValorEstacionamento;
        }

        public double getValorCouvert()
        {
            return valorCouvert;
        }
        public void setValorCouvert(double ValorCouvert)
        {
            valorCouvert = ValorCouvert;
        }

        public void setValorDescontoPromocional(double ValorDescontoPromocional)
        {
            valorDescontoPromocional = ValorDescontoPromocional;
        }
        public double getDescontoPromocional()
        {
            return valorDescontoPromocional;
        }

        public void setValorTotal(double ValorTotal)
        {
            valorTotal = ValorTotal;
        }
        public double getValorTotal()
        {
            return valorTotal;
        }


        public Comanda()
        {
            id = 0;
            valorConsumo = 0;
            valorEstacionamento = 0;
            valorCouvert = 0;
            valorDescontoPromocional = 0;
            valorTotal = 0;
        }
        public Comanda(int Id, double ValorConsumo, double
            ValorEstacionamento, double ValorCouvert, 
            double ValorDescontoPromocional, double ValorTotal
            )
        {
            id = Id;
            valorConsumo = ValorConsumo;
            valorEstacionamento = ValorEstacionamento;
            valorCouvert = ValorCouvert;
            valorDescontoPromocional = ValorDescontoPromocional;
            valorTotal = ValorTotal;
        }
        public Comanda(int Id)
        {
            id = Id;
            valorConsumo = 0;
            valorEstacionamento = 0;
            valorCouvert = 0;
            valorDescontoPromocional = 0;
            valorTotal = 0;
        }

        public void LancarGastos(double ValorConsumo,
            double ValorEstacionamento, double ValorCouvert)
        {
            valorConsumo = ValorConsumo;
            valorEstacionamento = ValorEstacionamento;
            valorCouvert = ValorCouvert;
        }

        public void VerificarPromocao()
        {
            if (valorConsumo > 100)
            {
                valorDescontoPromocional = 
                    valorConsumo * 0.1;
            }
        }

        public string ListarComanda()
        {
            return "Id Comanda:" + id +
                "\nValor Consumo: " + valorConsumo +
                "\nValor Estacionamento: " + valorEstacionamento +
                "\nValor Couvert: " + valorCouvert +
                "\nValor Desconto Promocional: " + valorDescontoPromocional +
                "\nValor Total: " + valorTotal;
        }

    }

}
