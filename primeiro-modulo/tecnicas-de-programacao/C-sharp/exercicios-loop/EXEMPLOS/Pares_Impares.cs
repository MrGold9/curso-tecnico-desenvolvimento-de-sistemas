using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pares_Impares
{
    class Program
    {
        static void Main(string[] args)
        {
            int pares = 0, impares = 0, num=0;

            for(int cont=1; cont <= 10; cont++)
            {
                Console.WriteLine("Informe um número");
                
                num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    pares++;
                } else
                {
                    impares++;
                }
            }

            Console.WriteLine("Foram digitados " + pares + " pares" +
                " e " + impares + " ímpares!");
            Console.ReadKey();
        }
    }
}
