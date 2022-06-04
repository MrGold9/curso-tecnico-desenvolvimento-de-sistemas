using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidarUsuario.Control;
using ValidarUsuario.Model;

namespace ValidarUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            Administrador adm = new Administrador("Tuji", "Tuji", "1234", true,
            5000, 1234);
            Operador ope = new Operador();
            Cliente cli = new Cliente();
            Validador validador = new Validador();

            int op = 0, oper = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Selecione uma das opções abaixo: \n1-Cliente\n2-Operador" +
                    "\n3-Administrador\n0-Sair");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 0:
                        break;
                    case 1:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Selecione uma das opções abaixo: " +
                                "\n1-Logar no sistema" +
                                "\n2-Cadastrar cliente" +
                                "\n3-Visualizar cliente" +
                                "\n0-Voltar ao menu anterior");
                            oper = int.Parse(Console.ReadLine());
                            switch (oper)
                            {
                                case 0:
                                    break;
                                case 1:
                                    Console.WriteLine(validador.ValidarUsuario(cli));
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    cli.CadastrarCliente("Cliente","loginCliente", "senhaCliente","cpfCliente",6000);
                                    break;
                                case 3:
                                    Console.WriteLine(cli.ApresentarCliente());
                                    Console.ReadLine();
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida!");
                                    break;
                            }
                        } while (oper != 0);
                        break;
                    case 2:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Selecione uma das opções abaixo: " +
                                "\n1-Logar no sistema" +
                                "\n2-Cadastrar operador " +
                                "\n3-Visualizar operador" +
                                "\n4-Calcular salário final do operador" +
                                "\n0-Voltar ao menu anterior");
                            oper = int.Parse(Console.ReadLine());
                            switch (oper)
                            {
                                case 0:
                                    break;
                                case 1:
                                    Console.WriteLine(validador.ValidarUsuario(ope));
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    ope.CadastrarOperador("Nome Operador", "loginOperador", "senhaOperador", 1200, "Operador", 800);
                                    break;
                                case 3:
                                    Console.WriteLine(ope.ApresentarOperador());
                                    Console.ReadLine();
                                    break;
                                case 4:
                                    Console.WriteLine(ope.CalcularSalario());
                                    Console.ReadLine();
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida!");
                                    Console.ReadLine();
                                    break;
                            }
                        } while (oper != 0);
                        break;
                    case 3:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Selecione uma das opções abaixo: " +
                                "\n1-Logar no sistema" +
                                "\n2-Autorizar usuário" +
                                "\n3-Calcular limite de credito" +
                                "\n0-Voltar ao menu anterior");
                            oper = int.Parse(Console.ReadLine());
                            switch (oper)
                            {
                                case 0:
                                    break;
                                case 1:
                                    Console.WriteLine(validador.ValidarUsuario(adm));
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.WriteLine(adm.autorizarUsuario(1234,adm));
                                    Console.WriteLine(adm.autorizarUsuario(1234,cli));
                                    Console.WriteLine(adm.autorizarUsuario(1234,ope));
                                    Console.ReadLine();
                                    break;
                                case 3:
                                    Console.WriteLine(adm.calcularLimiteCredito(1234,cli));
                                    Console.ReadLine();
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida!");
                                    break;
                            }
                        } while (oper != 0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while (op != 0);
        }
    }
}
