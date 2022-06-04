using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idades
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 0, maiorIdade = 0, menorIdade = 150;
            Random gerador = new Random();

            for (int i=0; i<=20; i++)
            {
                idade = gerador.Next(15, 68);
                Console.WriteLine(idade);
                if (idade > maiorIdade)
                {
                    maiorIdade = idade;
                }
                if (idade < menorIdade)
                {
                    menorIdade = idade;
                }
            }

            Console.WriteLine("A maior idade da turma é " + maiorIdade +
                "\nA menor idade da turma é " + menorIdade);
            Console.ReadKey();
        }
    }
}
