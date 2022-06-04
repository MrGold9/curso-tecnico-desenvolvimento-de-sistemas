using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0, resultado=0;
            char continuar = 'S';

            while (continuar=='S' || continuar == 's')
            {
                Console.WriteLine("Digite um número");
                numero = int.Parse(Console.ReadLine());
                resultado = numero * 5;
                Console.WriteLine("O resultado é " + resultado);
                Console.WriteLine("Deseja continuar? (S/N)");
                continuar = char.Parse(Console.ReadLine());
            }
        }
    }
}
