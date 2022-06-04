using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viagem
{
    class Custos
    {
        public string calcularViagem(Percurso p) {
            double totalPercurso = (p.kmPercorrida * p.valorCombustivel) + p.valorPedagio;
            return "Total do percurso foi " + totalPercurso;
        }
    }
}
