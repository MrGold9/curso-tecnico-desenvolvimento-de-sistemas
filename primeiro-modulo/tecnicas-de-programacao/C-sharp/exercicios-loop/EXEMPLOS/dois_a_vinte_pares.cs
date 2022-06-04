using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dois_a_vinte_pares
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 2;

            while (contador <= 20)
            {
                Console.WriteLine(contador.ToString());
                contador += 2;
            }

            Console.ReadKey();
        }
    }
}
