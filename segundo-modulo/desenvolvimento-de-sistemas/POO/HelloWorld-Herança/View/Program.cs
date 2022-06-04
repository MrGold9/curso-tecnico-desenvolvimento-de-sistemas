using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Exibir\n0 - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        break;
                    case 1:
                        //double value = 1634.9234;
                        //CultureInfo.CurrentCulture = new CultureInfo("pt-BR");
                        //Console.WriteLine("{0:C2}\n", value);
                        Console.WriteLine("Digite seu nome");
                        string nome = Console.ReadLine();
                        Model.ModeloHeranca objeto = new Model.ModeloHeranca(nome, "Outra mensagem para testar");
                        Console.WriteLine(objeto.exibir());
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

            } while (opcao != 0);
        }
    }
}
