using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    class Triangulo
    {
        public double lado1 { get; set; }
        public double lado2 { get; set; }
        public double lado3 { get; set; }
        public double perimetro { get; set; }
        public double area { get; set; }
        public string tipo { get; set; }

        public Boolean vTriangulo()
        {
            if ((lado1 < lado2 + lado3) && (lado2 < lado1 + lado3) && (lado3 < lado2 + lado1)) {
                return true; 
            }
            return false;
        }
        public Triangulo(double Lado1, double Lado2, double Lado3) 
        { 
            lado1 = Lado1; 
            lado2 = Lado2; 
            lado3 = Lado3; 
            tipo = ""; 
            perimetro = 0; 
            area = 0; 
        }
        public double cPerimetro() { 
            perimetro = lado1 + lado2 + lado3;
            return perimetro; 
        }
        public string classificao()
        {
            if (lado3 == lado2 && lado2 == lado1) {
                tipo = "Triângulo equilátero";
            }
            else if (lado3 != lado2 && lado2 != lado1) {
                tipo = "Triângulo escaleno"; 
            }
            else {
                tipo = "Triângulo isósceles";
            }
            return tipo;
        }
        public double cArea()
        {
            double sp = perimetro / 2;
            area = Math.Sqrt(sp * (sp - lado1) * (sp - lado2) * (sp - lado3));
            return area;
        }
    }
}
