using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor do lado 1 = "); 
            double lado1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o valor do lado 2 = "); 
            double lado2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o valor do lado 3 = "); 
            double lado3 = Convert.ToDouble(Console.ReadLine());
            Triangulo triangulo = new Triangulo(lado1, lado2, lado3);


            if (triangulo.vTriangulo())
            {
                Console.WriteLine("Lado 1= " + triangulo.lado1 + 
                    "\nLado 2= " + triangulo.lado2 + 
                    "\nLado 3= " + triangulo.lado3);
                Console.WriteLine("Perimetro = " + triangulo.cPerimetro());
                Console.WriteLine("Area = " + triangulo.cArea());
                Console.WriteLine("Classificação = " + triangulo.classificao());
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Os lados não formam um triângulo."); 
                Console.ReadKey();
            }
        }
    }
}
