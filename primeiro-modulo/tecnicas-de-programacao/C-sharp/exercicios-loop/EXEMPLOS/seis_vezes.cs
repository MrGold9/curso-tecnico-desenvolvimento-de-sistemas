using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seis_vezes
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0, resultado = 0, contador = 1;

            while (contador <=6)
            {
                Console.WriteLine("Informe um número");
                numero = int.Parse(Console.ReadLine());
                resultado = numero * 5;
                Console.WriteLine("O resultado é: " + resultado);
                contador++; //contador = contador + 1; contador+=1; 
            }
            Console.ReadKey();
        }
    }
}
