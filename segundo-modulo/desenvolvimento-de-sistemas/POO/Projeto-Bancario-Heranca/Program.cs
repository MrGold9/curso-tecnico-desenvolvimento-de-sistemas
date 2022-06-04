using ProjetoBancario.Model;
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
            //Conta conta = new Conta(123);
            ContaCorrente cc = new ContaCorrente(0,0,500,0);
            ContaPoupanca cp = new ContaPoupanca();

            int op = 0, opcao=0;
            do
            {
                Console.Clear();
                Console.WriteLine("Informe a opção desejada: \n1-Conta Corrente" +
                    "\n2-Conta Poupança\n0-Sair");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 0:
                        break;
                    case 1:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Informe a opção desejada: \n1-Depositar" +
                                "\n2-Sacar\n3-Transferir\n4-Consultar Saldo" +
                                "\n5-Calcular Juros Cheque Especial\n0-Sair");
                            op = int.Parse(Console.ReadLine());
                            switch (op)
                            {
                                case 0:
                                    break;
                                case 1:
                                    Console.WriteLine("Informe o valor do deposito");
                                    double valor = double.Parse(Console.ReadLine());

                                    cc.Depositar(valor);
                                    Console.WriteLine("Depósito efetuado com sucesso!");
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.WriteLine("Informe o valor do saque");
                                    valor = double.Parse(Console.ReadLine());
                                    bool retorno = cc.Sacar(valor);
                                    if (retorno)
                                    {
                                        Console.WriteLine("Saque efetuado com sucesso");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Saldo insuficiente");
                                    }
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    Console.WriteLine("Informe o valor da transferência");
                                    valor = double.Parse(Console.ReadLine());
                                    retorno = cc.Transferir(valor, cp);
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
                                    Console.WriteLine(cc.ConsultarSaldo());
                                    Console.ReadKey();
                                    break;
                                case 5:
                                    Console.WriteLine("Informe o valor da taxa de juros");
                                    double taxa = double.Parse(Console.ReadLine());
                                    cc.calcularJuros(taxa);
                                    break;
                                default:
                                    Console.WriteLine("Opção Inválida");
                                    Console.ReadKey();
                                    break;
                            }
                        } while (op != 0);
                        break;
                    case 2:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Informe a opção desejada: \n1-Depositar" +
                                "\n2-Sacar\n3-Transferir\n4-Consultar Saldo" +
                                "\n5-Calcular Reajuste Mensal\n0-Sair");
                            op = int.Parse(Console.ReadLine());
                            switch (op)
                            {
                                case 0:
                                    break;
                                case 1:
                                    Console.WriteLine("Informe o valor do deposito");
                                    double valor = double.Parse(Console.ReadLine());

                                    cp.Depositar(valor);
                                    Console.WriteLine("Depósito efetuado com sucesso!");
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.WriteLine("Informe o valor do saque");
                                    valor = double.Parse(Console.ReadLine());
                                    bool retorno = cp.Sacar(valor);
                                    if (retorno)
                                    {
                                        Console.WriteLine("Saque efetuado com sucesso");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Saldo insuficiente");
                                    }
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    Console.WriteLine("Informe o valor da transferência");
                                    valor = double.Parse(Console.ReadLine());
                                    retorno = cp.Transferir(valor, cc);
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
                                    Console.WriteLine(cp.ConsultarSaldo());
                                    Console.ReadKey();
                                    break;
                                case 5:
                                    Console.WriteLine("Informe o valor da taxa de rendimento");
                                    double taxa = double.Parse(Console.ReadLine());
                                    cp.CalcularRendimento(taxa);
                                    break;
                                default:
                                    Console.WriteLine("Opção Inválida");
                                    Console.ReadKey();
                                    break;
                            }
                        } while (op != 0);
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        Console.ReadKey();
                        break;
                }
            } while (opcao != 0);
        }
    }
}
