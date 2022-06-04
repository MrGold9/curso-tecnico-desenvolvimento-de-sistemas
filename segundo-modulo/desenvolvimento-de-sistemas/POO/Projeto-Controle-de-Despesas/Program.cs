using System;

namespace Despesas
{
    class Program
    {
        static void Main(string[] args)
        {
            Alimentacao refeicoes = new Alimentacao();
            Transporte veiculos = new Transporte();
            Diaria diarias = new Diaria();
            GerenciadorDespesas gerenciador = new GerenciadorDespesas();

            int op = 0;
            int oper = 0;

            do
            {
                Console.Clear();

                Console.WriteLine("1 - Aliemntação" + "\n2 - Transporte" + "\n3 - Diaria" +
                    "\n4 - Apresenta a análise de despesas" + "\n0 - Sair");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 0: break;
                    case 1:
                        do
                        {
                            Console.Clear();

                            Console.WriteLine("1 - Cadastrar despesa" + "\n2 - Calcular despesa" + "\n3 - Apresentar despesa" +
                    "\n4 - Incluir despesa para análise" + "\n0 - Sair");
                            oper = Convert.ToInt32(Console.ReadLine());

                            switch (oper)
                            {
                                case 0: break;
                                case 1:
                                    Console.Write("Informe a descrição: ");
                                    string descricao1 = Console.ReadLine();

                                    Console.Write("Informe o nome do restaurante: ");
                                    string nome1 = Console.ReadLine();

                                    refeicoes.cadastrarDespesa(descricao1, nome1);

                                    break;
                                case 2:
                                    Console.Write("Informe a quantidade de refeições: ");
                                    int quantidade1 = Convert.ToInt32(Console.ReadLine());

                                    refeicoes.calcularDespesa(quantidade1);
                                    break;
                                case 3:
                                    Console.WriteLine(refeicoes.listarDespesa());
                                    Console.ReadLine();
                                    break;
                                case 4:
                                    gerenciador.analisarDespesas(refeicoes);
                                    break;
                            }

                        } while (oper != 0);
                        break;
                    case 2:
                        do
                        {
                            Console.Clear();

                            Console.WriteLine("1 - Cadastrar despesa" + "\n2 - Calcular despesa" + "\n3 - Apresentar despesa" +
                    "\n4 - Incluir despesa para análise" + "\n0 - Sair");
                            oper = Convert.ToInt32(Console.ReadLine());

                            switch (oper)
                            {
                                case 0: break;
                                case 1:
                                    Console.Write("Informe a descrição: ");
                                    string descricao2 = Console.ReadLine();

                                    veiculos.cadastrarDespesa(descricao2);
                                    break;
                                case 2:
                                    Console.WriteLine("Informe a kilometragem percorrida: ");
                                    double km = Convert.ToDouble(Console.ReadLine());

                                    Console.WriteLine("Informe o valor do pedágio: ");
                                    double valor = Convert.ToDouble(Console.ReadLine());

                                    veiculos.calcularDespesa(km, valor);
                                    break;
                                case 3:
                                    Console.WriteLine(veiculos.listarDespesa());
                                    Console.ReadLine();
                                    break;
                                case 4:
                                    gerenciador.analisarDespesas(veiculos);
                                    break;
                            }
                        } while (oper != 0);
                        break;
                    case 3:
                        do
                        {
                            Console.Clear();

                            Console.WriteLine("1 - Cadastrar despesa" + "\n2 - Calcular despesa" + "\n3 - Apresentar despesa" +
                    "\n4 - Incluir despesa para análise" + "\n0 - Sair");
                            oper = Convert.ToInt32(Console.ReadLine());
                          
                                switch (oper)
                                {
                                    case 0: break;
                                    case 1:
                                        Console.WriteLine("Informe a descrição");
                                        string descricao3 = Console.ReadLine();

                                        diarias.cadastrarDespesa(descricao3);
                                        break;
                                    case 2:
                                        Console.WriteLine("Informe a quantidade diária: ");
                                        double quantidade = Convert.ToDouble(Console.ReadLine());

                                        diarias.calcularDespesa(quantidade);
                                        break;
                                    case 3:
                                        Console.WriteLine(diarias.listarDespesa());
                                        Console.ReadLine();
                                        break;
                                    case 4:
                                        gerenciador.analisarDespesas(diarias);
                                        break;
                                }
                        } while (oper != 0);
                        break;
                    case 4:
                        Console.WriteLine(gerenciador.listarDespesas());
                        Console.ReadLine();
                        break;
                }

            } while (op != 0);
        }
    }
}
