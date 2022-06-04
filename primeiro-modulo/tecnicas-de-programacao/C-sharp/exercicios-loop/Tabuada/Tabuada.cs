using System;

namespace Tabuada
{
    class Tabuada
    {
        static void Main(string[] args)
        {
            int num, cont, resultado;
            Console.WriteLine("Quer saber a tabuada de qual número?");
            num = int.Parse(Console.ReadLine());
            for (cont = 1; cont <= 10; cont++)
            {
                resultado = num * cont;
                Console.WriteLine(num + "X" + cont + "=" + resultado);
            }
            Console.ReadKey();
        }
    }
}
