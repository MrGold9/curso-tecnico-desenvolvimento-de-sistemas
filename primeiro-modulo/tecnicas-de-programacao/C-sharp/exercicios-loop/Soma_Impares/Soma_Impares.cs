using System;

namespace Soma_Impares
{
    class Soma_Impares
    {
        static void Main(string[] args)
        {
            int somatoria=0;
            for (int cont=3; cont <= 200; cont+=3)
            {
                Console.WriteLine(cont);
                somatoria = somatoria + cont;
            }
            Console.WriteLine("A soma dos números ímpares é= " + somatoria);
            Console.ReadKey();
        }
    }
}
