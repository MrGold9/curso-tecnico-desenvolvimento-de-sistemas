using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancario
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta(123);

            int op = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Informe a opção desejada: \n1-Depositar" +
                    "\n2-Sacar\n3-Transferir\n4-Consultar Saldo\n0-Sair");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine("Informe o valor do deposito");
                        double valor = double.Parse(Console.ReadLine());
                        
                        conta.Depositar(valor);
                        Console.WriteLine("Depósito efetuado com sucesso!");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Informe o valor do saque");
                        valor = double.Parse(Console.ReadLine());
                        bool retorno = conta.Sacar(valor);
                        if (retorno)
                        {
                            Console.WriteLine("Saque efetuado com sucesso");
                        } else
                        {
                            Console.WriteLine("Saldo insuficiente");
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Informe o valor da transferência");
                        valor = double.Parse(Console.ReadLine());
                        retorno = conta.Transferir(valor,new Conta());
                        if (retorno)
                        {
                            Console.WriteLine("Transferência efetuado com sucesso");
                        }
                        else
                        {
                            Console.WriteLine("Saldo insuficiente");
                        }
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine(conta.ConsultarSaldo());
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
