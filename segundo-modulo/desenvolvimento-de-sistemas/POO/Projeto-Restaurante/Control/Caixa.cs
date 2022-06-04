using ProjetoRestaurante.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRestaurante.Control
{
    class Caixa
    {
        public Caixa()
        {

        }

        public double TotalizarComanda(Comanda mesa)
        {
            mesa.setValorTotal(
                mesa.getValorConsumo()
                + mesa.getValorEstacionamento()
                + mesa.getValorCouvert() - 
                mesa.getDescontoPromocional()
                ) ;
            return mesa.getValorTotal();
        }
    }

}
