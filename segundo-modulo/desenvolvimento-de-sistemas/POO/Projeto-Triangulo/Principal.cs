using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Triangulo
{
    class Principal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor do 1º lado= ");
            double lado1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o valor do 2º lado= ");
            double lado2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o valor do 3º lado= ");
            double lado3 = Convert.ToDouble(Console.ReadLine());

            Triangulo triangulo = new Triangulo(lado1, lado2, lado3);

            if (triangulo.isTriangle())
            {
                Console.Clear();

                Console.WriteLine("1º lado= " + triangulo.lado1 + "\n2º lado= " + triangulo.lado2 + "\n3º lado= " + triangulo.lado3);

                Console.WriteLine("Tipo= " + triangulo.classificar());

                Console.WriteLine("Perimetro= " + triangulo.calcularPerimetro());

                Console.WriteLine("Área= " + triangulo.calcularArea());
            }
            else
            {
                Console.WriteLine("Os lados não formam um triângulo");
            }
            Console.ReadKey();
        }
    }
}
