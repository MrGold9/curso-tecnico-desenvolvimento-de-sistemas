using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Percurso p = new Percurso();
            Custos c = new Custos();
            int op = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Informe a opção desejada: \n1-Novo Percurso" +
                    "\n2-Apresentar percurso\n3-Calcular viagens\n0-Sair");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine("Informe o km ");
                        double kmPercorrida = double.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o Combustivel ");
                        double valorCombustivel = double.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o Pedágio ");
                        double valorPedagio = double.Parse(Console.ReadLine());
                        p.cadastrarPercurso(kmPercorrida, valorCombustivel, valorPedagio);
                        Console.WriteLine("Cadastro efetuado com sucesso!");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine(p.listarPercurso());
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine(c.calcularViagem(p));
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        Console.ReadKey();
                        break;
                }
            } while (op != 0);
        }
    }
}
