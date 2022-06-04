using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intervalo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random gerador = new Random();
            int num = 0, validos = 0;

            for(int i=0; i<=8; i++)
            {
                num = gerador.Next(1, 1501);
                Console.WriteLine(num);
                if(num>10 && num <= 150)
                {
                    validos++;
                }
            }

            Console.WriteLine("Foram gerados " + validos + " números entre" +
                " 10 e 150");
            Console.ReadKey();

        }
    }
}
