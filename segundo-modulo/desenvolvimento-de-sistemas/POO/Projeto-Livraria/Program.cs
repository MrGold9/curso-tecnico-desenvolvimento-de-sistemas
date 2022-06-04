using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivrariaHeranca.Model;

namespace LivrariaHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new Livro();
            Cd cd = new Cd();
            Dvd dvd = new Dvd();

            int op = 0, opcao=0;

            do
            {
                Console.Clear();
                Console.WriteLine("Informe a opção desejada: \n1-Livro" +
                    "\n2-CD\n3-DVD\n0-Sair");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 0:
                        break;
                    case 1:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Informe a opção desejada: \n1-Cadastrar" +
                                "\n2-Comprar\n3-Calcular Preço de Venda\n4-Vender\n5-Listar\n0-Sair");
                            opcao = int.Parse(Console.ReadLine());
                            switch (opcao)
                            {
                                case 0:
                                    break;
                                case 1:
                                    livro = new Livro("Harry Potter e a Pedra Filosofal", "Ficção", 0, 20, 0,
                                        "J. K. Rowling", "British Book", "1ª edição");
                                    Console.WriteLine("Produto cadastrado com sucesso!");
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.WriteLine("Informe a quantidade comprada");
                                    int qtde = int.Parse(Console.ReadLine());
                                    livro.Comprar(qtde);
                                    Console.WriteLine("Produto comprado com sucesso!");
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    livro.CalcularPrecoVenda();
                                    Console.WriteLine("Preço de Venda calculado com sucesso!");
                                    Console.ReadKey();
                                    break;
                                case 4:
                                    Console.WriteLine("Informe a quantidade vendida");
                                    qtde = int.Parse(Console.ReadLine());
                                    livro.Vender(qtde);
                                    Console.WriteLine("Produto vendido com sucesso!");
                                    Console.ReadKey();
                                    break;
                                case 5:
                                    Console.WriteLine(livro.ListarProduto());
                                    Console.ReadKey();
                                    break;
                                default:
                                    Console.WriteLine("Opção Inválida");
                                    Console.ReadKey();
                                    break;
                            }
                           
                        } while (opcao != 0);
                        break;
                    case 2:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Informe a opção desejada: \n1-Cadastrar" +
                                "\n2-Comprar\n3-Calcular Preço de Venda\n4-Vender\n5-Listar\n0-Sair");
                            opcao = int.Parse(Console.ReadLine());
                            switch (opcao)
                            {
                                case 0:
                                    break;
                                case 1:
                                    cd = new Cd("The Dark Side of the Moon", "Rock", 0, 10, 0,
                                        "Pink Floyd", "EMI", "EUA");
                                    Console.WriteLine("Produto cadastrado com sucesso!");
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.WriteLine("Informe a quantidade comprada");
                                    int qtde = int.Parse(Console.ReadLine());
                                    cd.Comprar(qtde);
                                    Console.WriteLine("Produto comprado com sucesso!");
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    cd.CalcularPrecoVenda();
                                    Console.WriteLine("Preço de Venda calculado com sucesso!");
                                    Console.ReadKey();
                                    break;
                                case 4:
                                    Console.WriteLine("Informe a quantidade vendida");
                                    qtde = int.Parse(Console.ReadLine());
                                    cd.Vender(qtde);
                                    Console.WriteLine("Produto vendido com sucesso!");
                                    Console.ReadKey();
                                    break;
                                case 5:
                                    Console.WriteLine(cd.ListarProduto());
                                    Console.ReadKey();
                                    break;
                                default:
                                    Console.WriteLine("Opção Inválida");
                                    Console.ReadKey();
                                    break;
                            }

                        } while (opcao != 0);
                        break;
                    case 3:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Informe a opção desejada: \n1-Cadastrar" +
                                "\n2-Comprar\n3-Calcular Preço de Venda\n4-Vender\n5-Listar\n0-Sair");
                            opcao = int.Parse(Console.ReadLine());
                            switch (opcao)
                            {
                                case 0:
                                    break;
                                case 1:
                                    dvd = new Dvd("DVD Zeca Pagodinho: Uma Prova de Amor" +
                                        " - Especial MTV - Ao Vivo", "Pagode", 0, 2, 0,
                                        "Diretor do DVD", "120 minutos", "12 anos");
                                    Console.WriteLine("Produto cadastrado com sucesso!");
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.WriteLine("Informe a quantidade comprada");
                                    int qtde = int.Parse(Console.ReadLine());
                                    dvd.Comprar(qtde);
                                    Console.WriteLine("Produto comprado com sucesso!");
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    Console.WriteLine("Informe a cotação do dólar");
                                    double dolar = double.Parse(Console.ReadLine());
                                    dvd.CalcularPrecoVenda(dolar);
                                    Console.WriteLine("Preço de Venda calculado com sucesso!");
                                    Console.ReadKey();
                                    break;
                                case 4:
                                    Console.WriteLine("Informe a quantidade vendida");
                                    qtde = int.Parse(Console.ReadLine());
                                    dvd.Vender(qtde);
                                    Console.WriteLine("Produto vendido com sucesso!");
                                    Console.ReadKey();
                                    break;
                                case 5:
                                    Console.WriteLine(dvd.ListarProduto());
                                    Console.ReadKey();
                                    break;
                                default:
                                    Console.WriteLine("Opção Inválida");
                                    Console.ReadKey();
                                    break;
                            }

                        } while (opcao != 0);
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
