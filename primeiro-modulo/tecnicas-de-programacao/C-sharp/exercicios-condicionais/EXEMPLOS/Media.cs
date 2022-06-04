using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a primeria nota");
            double nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a segunda nota");
            double nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a terceira nota");
            double nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quarta nota");
            double nota4 = double.Parse(Console.ReadLine());

            double media = (nota1+nota2+nota3+nota4)/4;

            string msg = "";

            if (media >= 5)
            {
                msg = "Aluno aprovado";
            } else
            {
                msg = "Aluno reprovado";
            }

            Console.WriteLine(msg + " -  Média: " + media);
            Console.ReadKey();

        }
    }
}
