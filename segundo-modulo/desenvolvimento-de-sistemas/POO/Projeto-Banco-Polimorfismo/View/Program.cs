using ProjetoBancarioPolimorfismo.Model;
using ProjetoBancarioPolimorfismo.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancarioPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            ContaCorrente cc= new ContaCorrente(500, 1000); ;
            ContaPoupanca cp = new ContaPoupanca(5000,0.01);
            GerenciadorContas gerenciador = new GerenciadorContas(0);

            do {
                Console.Clear();
                Console.WriteLine("Selecione uma opção \n1-Conta Corrente \n2-Conta Poupança " +
                   "\n3-Consultar Saldo Total \n0-Sair");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        int opcao = 0;
                        do
                        {
                            
                            Console.WriteLine("Selecione uma opção \n1-Depositar \n2-Sacar " +
                            "\n3-Transferir \n4- Consultar Saldo\n5-Reajustar Saldo \n0-Sair");
                            opcao = int.Parse(Console.ReadLine());
                            switch (opcao)
                            {
                                case 1:
                                   Console.WriteLine("Informe o valor do depósito ");
                                   double valor = double.Parse(Console.ReadLine());
                                    cc.creditar(valor);
                                    break;
                                case 2:
                                    Console.WriteLine("Informe o valor do saque ");
                                    valor = double.Parse(Console.ReadLine());
                                   bool retorno =  cc.debitar(valor);
                                    if (retorno)
                                    {
                                        Console.WriteLine("Saque efetuado com sucesso!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Saldo insuficiente!");
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("Informe o valor da transferência ");
                                    valor = double.Parse(Console.ReadLine());
                                    cc.transferir(valor,cp);
                                    break;
                                case 4:
                                    Console.WriteLine("Saldo" + cc.ConsultarSaldo());
                                    break;
                                case 5:
                                    Console.WriteLine("Saldo anterior="+cc.getSaldo());
                                    cc.atualizarSaldo();
                                    Console.WriteLine("Saldo atual="+cc.getSaldo());
                                    break;
                                case 0:
                                    break;
                                default:
                                    Console.WriteLine("Opção Inválida");
                                    break;
                            }
                        } while (opcao != 0);
                        Console.ReadKey();
                        break;
                    case 2:
                        opcao = 0;
                        do
                        {
                            Console.WriteLine("Selecione uma opção \n1-Depositar \n2-Sacar " +
                            "\n3-Transferir \n4- Consultar Saldo\n5-Reajustar Saldo \n0-Sair");
                            opcao = int.Parse(Console.ReadLine());
                            switch (opcao)
                            {
                                case 1:
                                    Console.WriteLine("Informe o valor do depósito ");
                                    double valor = double.Parse(Console.ReadLine());
                                    cp.creditar(valor);
                                    break;
                                case 2:
                                    Console.WriteLine("Informe o valor do saque ");
                                    valor = double.Parse(Console.ReadLine());
                                    bool retorno = cp.debitar(valor);
                                    if (retorno)
                                    {
                                        Console.WriteLine("Saque efetuado com sucesso!");
                                    } else
                                    {
                                        Console.WriteLine("Saldo insuficiente!");
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("Informe o valor da transferência ");
                                    valor = double.Parse(Console.ReadLine());
                                    cp.transferir(valor, cc);
                                    break;
                                case 4:
                                    Console.WriteLine("Saldo poupança" + cp.getSaldo());
                                    break;
                                case 5:
                                    Console.WriteLine("Saldo anterior=" + cp.getSaldo());
                                    cp.atualizarSaldo(0.05);
                                    Console.WriteLine("Saldo atual=" + cp.getSaldo());
                                    break;
                                case 0:
                                    break;
                                default:
                                    Console.WriteLine("Opção Inválida");
                                    break;
                            }
                        } while (opcao != 0);
                        Console.ReadKey();
                        break;
                    case 3:
                        gerenciador.totalizarSaldo(cc);
                        gerenciador.totalizarSaldo(cp);
                        Console.WriteLine(
                            "Saldo Conta Corrente = " + cc.getSaldo() +
                            "\nSaldo Conta Poupança = " + cp.getSaldo() +
                            "\nSaldo total=" + gerenciador.getSaldoTotal());
                        Console.ReadKey();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }

            } while (op != 0);
            
        }
    }
}
