using ProjetoCalculoSalario.Control;
using ProjetoCalculoSalario.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCalculoSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            Gerente gerente = new Gerente();
            Vendedor vendedor = new Vendedor();
            Atendente atendente = new Atendente();
            GerenciadorFuncionarios gerenciador = new GerenciadorFuncionarios();

            do
            {
                Console.Clear();
                Console.WriteLine("Selecione uma opção \n1-Gerente \n2-Vendedor" +
                   "\n3-Atendente \n4-Apresentar Totais \n0-Sair");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        int opcao = 0;
                        do
                        {

                            Console.WriteLine("Selecione uma opção \n1-Cadastrar Funcionário \n2-Calcular Bonificação " +
                            "\n3-Calcular Salário Final \n4- Apresentar Salário Final\n5-Incluir no Gerenciador\n0-Sair");
                            opcao = int.Parse(Console.ReadLine());
                            switch (opcao)
                            {
                                case 1:
                                    Console.WriteLine("Informe o nome do " + gerente.GetType().Name);
                                    string nome = Console.ReadLine();
                                    Console.WriteLine("Informe o cpf do Gerente ");
                                    string cpf = Console.ReadLine();
                                    Console.WriteLine("Informe o salário base do Gerente ");
                                    double salarioBase = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Informe o valor da Gratificação do Gerente ");
                                    double gratificacao = double.Parse(Console.ReadLine());
                                    gerente.CadastrarFuncionario(nome, cpf, salarioBase, gratificacao);
                                    break;
                                case 2:
                                    gerente.CalcularBonificacao();
                                    Console.WriteLine("Bonificação calculada!");
                                    break;
                                case 3:
                                    Console.WriteLine("Salário Final =  " + gerente.CalcularSalarioFinal());
                                    break;
                                case 4:
                                    Console.WriteLine(gerente.ApresentarSalario());
                                    break;
                                case 5:
                                    gerenciador.Totalizador(gerente);
                                    Console.WriteLine("Gerente incluído no totalizador!");
                                    break;
                                case 0:
                                    break;
                                default:
                                    Console.WriteLine("Opção Inválida");
                                    break;
                            }
                        } while (opcao != 0);
                        break;
                    case 2:
                        opcao = 0;
                        do
                        {
                            Console.WriteLine("Selecione uma opção \n1-Cadastrar Funcionário \n2-Calcular Bonificação " +
                            "\n3-Calcular Salário Final \n4- Apresentar Salário Final\n5-Incluir no Gerenciador\n0-Sair");
                            opcao = int.Parse(Console.ReadLine());
                            switch (opcao)
                            {
                                case 1:
                                    Console.WriteLine("Informe o nome do Vendedor ");
                                    string nome = Console.ReadLine();
                                    Console.WriteLine("Informe o cpf do Vendedor ");
                                    string cpf = Console.ReadLine();
                                    Console.WriteLine("Informe o salário base do Vendedor ");
                                    double salarioBase = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Informe o valor da Comissão do Vendedor ");
                                    double comissao = double.Parse(Console.ReadLine());
                                    vendedor.CadastrarFuncionario(nome, cpf, salarioBase, comissao);
                                    break;
                                case 2:
                                    vendedor.CalcularBonificacao();
                                    Console.WriteLine("Bonificação calculada!");
                                    break;
                                case 3:
                                    Console.WriteLine("Salário Final Vendedor =  " + vendedor.CalcularSalarioFinal());
                                    break;
                                case 4:
                                    Console.WriteLine(vendedor.ApresentarSalario());
                                    break;
                                case 5:
                                    gerenciador.Totalizador(vendedor);
                                    Console.WriteLine("Vendedor incluído no totalizador!");
                                    break;
                                case 0:
                                    break;
                                default:
                                    Console.WriteLine("Opção Inválida");
                                    break;
                            }
                        } while (opcao != 0);
                        break;
                    case 3:
                        opcao = 0;
                        do
                        {
                            Console.WriteLine("Selecione uma opção \n1-Cadastrar Funcionário \n2-Calcular Bonificação " +
                            "\n3-Calcular Salário Final \n4- Apresentar Salário Final\n5-Incluir no Gerenciador\n0-Sair");
                            opcao = int.Parse(Console.ReadLine());
                            switch (opcao)
                            {
                                case 1:
                                    Console.WriteLine("Informe o nome do Atendente ");
                                    string nome = Console.ReadLine();
                                    Console.WriteLine("Informe o cpf do Atendente ");
                                    string cpf = Console.ReadLine();
                                    Console.WriteLine("Informe o salário base do Atendente ");
                                    double salarioBase = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Informe o valor da Adicional Noturno do Atendente ");
                                    double adicionalNoturno = double.Parse(Console.ReadLine());
                                    atendente.CadastrarFuncionario(nome, cpf, salarioBase, adicionalNoturno);
                                    break;
                                case 2:
                                    atendente.CalcularBonificacao();
                                    Console.WriteLine("Bonificação calculada!");
                                    break;
                                case 3:
                                    Console.WriteLine("Salário Final Atendente =  " + atendente.CalcularSalarioFinal());
                                    break;
                                case 4:
                                    Console.WriteLine(atendente.ApresentarSalario());
                                    break;
                                case 5:
                                    gerenciador.Totalizador(atendente);
                                    Console.WriteLine("Atendente incluído no totalizador!");
                                    break;
                                case 0:
                                    break;
                                default:
                                    Console.WriteLine("Opção Inválida");
                                    break;
                            }
                        } while (opcao != 0);
                        break;
                    case 4:
                        Console.WriteLine("Total de Salários = " + gerenciador.TotalSalarios + 
                            "\nTotal de Bonificações = " + gerenciador.TotalBonificacoes);
                        Console.ReadKey();
                        break;
                    case 0:
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
