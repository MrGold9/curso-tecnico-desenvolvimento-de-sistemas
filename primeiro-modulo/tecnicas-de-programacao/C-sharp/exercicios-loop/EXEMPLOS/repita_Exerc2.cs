using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repita_Exerc2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 7;

            do
            {
                Console.WriteLine(cont);
                cont += 7;
            } while (cont < 1500);
            Console.ReadKey();
        }
    }
}
