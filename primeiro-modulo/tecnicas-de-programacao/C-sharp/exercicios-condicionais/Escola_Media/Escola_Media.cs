using System;

namespace Escola_Media
{
    class Program
    {
        static void Main(string[] args)
        {
            Double n1, n2, n3, n4, nf, media;
            Console.WriteLine("Digite a nota do primeiro bimestre:");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota do segundo bimestre:");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota do terceiro bimestre:");
            n3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota do quarto bimestre:");
            n4 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            nf = n1 + n2 + n3 + n4;
            Console.Write("Soma das notas=" + nf);
            media = nf / 4;
            Console.WriteLine();
            Console.Write("Média do aluno=" + media);
            Console.WriteLine();
            if (media >= 5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("O aluno passou de ano!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("O aluno foi retido...");
            }
            Console.ReadKey();
        }
    }
}
