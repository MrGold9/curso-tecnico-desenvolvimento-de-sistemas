using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uma_a_vinte
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            while (contador <= 20)
            {
                Console.WriteLine(contador.ToString());
                contador++;
            }

            Console.ReadKey();
        }
    }
}
