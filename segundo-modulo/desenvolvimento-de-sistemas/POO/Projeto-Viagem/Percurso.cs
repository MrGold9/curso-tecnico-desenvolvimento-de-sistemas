using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viagem
{
    class Percurso
    {
        public double kmPercorrida { get; set; }
        public double valorCombustivel { get; set; }
        public double valorPedagio { get; set; }

        public Percurso() { 
            kmPercorrida = 0; 
            valorCombustivel = 0; 
            valorPedagio = 0; 
        }
        public Percurso(double KmPercorrida, double ValorCombustivel, double ValorPedagio) {
            KmPercorrida = kmPercorrida; 
            ValorCombustivel = valorCombustivel; 
            ValorPedagio = valorPedagio; }
        public void cadastrarPercurso(double KmPercorrida, double ValorCombustivel, double ValorPedagio) {

            kmPercorrida = KmPercorrida;
            valorCombustivel = ValorCombustivel;
            valorPedagio = ValorPedagio;
        }
        public string listarPercurso() {
            return "Km Percorrida " + kmPercorrida +
            "Valor Combustivel " + valorCombustivel +
            "Valor Pedagio " + valorPedagio;
        }

    }
}
