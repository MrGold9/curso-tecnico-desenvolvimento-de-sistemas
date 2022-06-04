using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poco
{
    class Poco
    {
        private double diametro;
        private double profundidade;
        public double GetDiametro()
        {
            return diametro;
        }
        public void SetDiametro(double Diametro)
        {
                diametro = Diametro;
        }
        public double GetProfundidade()
        {
            return profundidade;
        }
        public void SetProfundidade(double Profundidade)
        {
            profundidade = Profundidade;
        }
        public Poco()
        {
            diametro = 0;
            profundidade = 0;
        }
        public Poco (double Diametro, double Profundidade)
        {
            diametro = Diametro;
            profundidade = Profundidade;
        }
        private double Raio()
        {
            return diametro/2;
        }
        public double Volume()
        {
            return (2*Math.PI * (Math.Pow(Raio(),2)) * profundidade);
        }
        public string Valida()
        {
            if (Volume() >= 5000)
            {
                return "Armazena a quantidade suficiente para família";
            }
            return "Não armazena a quantidade sufuciente para família";
            
        }
    }
}
