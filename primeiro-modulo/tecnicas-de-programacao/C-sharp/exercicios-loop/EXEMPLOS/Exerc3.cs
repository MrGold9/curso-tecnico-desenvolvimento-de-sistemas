using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc3
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            int numero = 0, resultado = 0;
            string valores = "";
            while (contador <= 10)
            {
                Console.WriteLine("Informe um número");
                numero = int.Parse(Console.ReadLine());
                resultado = resultado + numero;
                valores = valores + numero + "+";
                contador++;
            }

            Console.WriteLine("A soma dos valores " + valores + 
                " é " + resultado);
            Console.ReadKey();
        }

    }
}
