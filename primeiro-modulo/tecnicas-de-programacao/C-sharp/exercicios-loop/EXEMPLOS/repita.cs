using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repita
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 1, num = 0, res = 0;
            do
            {
                Console.WriteLine("Digite um número");
                num = int.Parse(Console.ReadLine());
                res = num * 3;
                Console.WriteLine("O resultado é " + res);
                cont++;
            } while (cont < 5);
            Console.ReadKey();
        }
    }
}
