using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número");
            int numA = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe um número");
            int numB = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe um número");
            int numC = int.Parse(Console.ReadLine());
            int aux=0;

            if (numA > numB)
            {
                aux = numA;
                numA = numB;
                numB = aux;
            }
            if (numA > numC)
            {
                aux = numA;
                numA = numC;
                numC = aux;
            }
            if (numB > numC)
            {
                aux = numB;
                numB = numC;
                numC = aux;
            }
            
            Console.WriteLine(numA+" - "+numB+" - "+numC);
            Console.ReadKey();

        }
    }
}
