using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aumento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu salário atual");
            double salario = double.Parse(Console.ReadLine());
            double salarioAtual, aumento, percentual;

            if (salario < 1000)
            {
                percentual = 0.1;
            } else if (salario <= 2000)
            {
                percentual = 0.06;
            } else
            {
                percentual = 0.02;
            }

            aumento = salario * percentual;
            salarioAtual = salario + aumento;

            Console.WriteLine("Salário Anterior = " + salario
                + "\nAumento = " + aumento 
                + "\nSalário Atual = " + salarioAtual);

            Console.ReadKey();
        }
    }
}
