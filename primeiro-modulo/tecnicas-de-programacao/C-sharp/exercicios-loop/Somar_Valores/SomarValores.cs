using System;

namespace Somar_Valores
{
    class SomarValores
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número");
            int num = int.Parse(Console.ReadLine());
            int total = 0;
            string fatores = "";
            for (int cont = 1; cont <= num; cont++)
            {
                total = total + cont;
                fatores = fatores + "+" + cont;
            }
            Console.WriteLine("A soma de " + fatores + "=" + total);
            Console.ReadKey();
        }
    }
}
