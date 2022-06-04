using System;

namespace Aumento
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario_ant, aumento1, aumento2, aumento3, salario_atu1, salario_atu2, salario_atu3;
            Console.Write("Digite seu salário:");
            salario_ant = Convert.ToDouble(Console.ReadLine());
            aumento1 = salario_ant / 100 * 10;
            aumento2 = salario_ant / 100 * 6;
            aumento3 = salario_ant / 100 * 2;
            salario_atu1 = salario_ant + aumento1;
            salario_atu2 = aumento2 + salario_ant;
            salario_atu3 = aumento3 + salario_ant;

            if (salario_ant < 1000)
            {
                Console.WriteLine("Seu salário anterior era:" + salario_ant);
                Console.WriteLine("Seu aumento é de:" + aumento1);
                Console.WriteLine("Seu salário agora é:" + salario_atu1);
            }
            if (salario_ant <= 2000) if (salario_ant >= 1000)
            {
                Console.WriteLine("Seu salário anterior era:" + salario_ant);
                Console.WriteLine("Seu aumento é de:" + aumento2);
                Console.WriteLine("Seu salário agora é:" + salario_atu2);
            }
            if (salario_ant > 2000) if (salario_ant < 9999999999999999999)
            {
                    Console.WriteLine("Seu salário anterior era:" + salario_ant);
                    Console.WriteLine("Seu aumento é de:" + aumento3);
                    Console.WriteLine("Seu salário agora é:" + salario_atu3);
            }
            Console.ReadKey();

        }
    }
}
