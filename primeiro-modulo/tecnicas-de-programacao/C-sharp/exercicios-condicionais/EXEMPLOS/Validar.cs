using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número");
            int numero = int.Parse(Console.ReadLine());
            if (numero >= 0 && numero <= 100)
            {
                Console.WriteLine("Numero Válido!");
            }
            else
            {
                Console.WriteLine("Número Inválido!");
            }
            Console.ReadKey();
        }
    }
}
