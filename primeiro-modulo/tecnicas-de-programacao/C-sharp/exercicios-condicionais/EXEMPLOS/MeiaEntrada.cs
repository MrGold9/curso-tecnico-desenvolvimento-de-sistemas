using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeiaEntrada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe sua idade");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Você é estudante? (S/N)?");
            char est = char.Parse(Console.ReadLine());

            bool estudante = false;

            if (est=='S')
            {
                estudante = true;
            } else
            {
                estudante = false;
            }

            if (idade <12 || idade >= 65 || estudante )
            {
                Console.WriteLine("Entrada = R$ 10,00");
            } else
            {
                Console.WriteLine("Entrada = R$ 20,00");
            }

            Console.ReadKey();

        }
    }
}
