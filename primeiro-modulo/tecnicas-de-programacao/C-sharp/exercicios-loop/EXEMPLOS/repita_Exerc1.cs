using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repita_Exerc1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, res = 0;
            char cont = 'S';

            do
            {
                Console.WriteLine("Digite um número");
                num = int.Parse(Console.ReadLine());
                res = res + num;
                Console.WriteLine("Deseja continuar a soma? (S/N)");
                cont = char.Parse(Console.ReadLine());

            } while (cont == 'S' || cont=='s');

            Console.WriteLine("A soma dos valores é " + res);
            Console.ReadKey();
        }
    }
}
