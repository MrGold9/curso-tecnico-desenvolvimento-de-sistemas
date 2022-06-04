using ProjetoRestaurante.Control;
using ProjetoRestaurante.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRestaurante
{
    class Program
    {
        static void Main(string[] args)
        {
            Comanda controleMesa = new Comanda(1);
            Caixa caixa = new Caixa();

            int op = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Selecione a opção desejada:" +
                    "\n\n1-Lançar Gastos" +
                    "\n2-Verificar Promoção" +
                    "\n3-Fechar Mesa" +
                    "\n4-ListarComanda" +
                    "\n0-Sair");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Informe o valor do consumo");
                        double Consumo = double.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o valor do estacionamento");
                        double Estacionamento = double.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o valor do couvert");
                        double Couvert = double.Parse(Console.ReadLine());
                        controleMesa.LancarGastos(Consumo,Estacionamento,Couvert);
                        Console.ReadKey();
                        break;
                    case 2:
                        controleMesa.VerificarPromocao();
                        if (controleMesa.getValorConsumo() > 100)
                        {
                            Console.WriteLine("Valor Consumo:  " + controleMesa.getValorConsumo() +
                                "\nValor do Desconto: " + controleMesa.getDescontoPromocional());
                        }
                        else
                        {
                            Console.WriteLine("Valor Consumo não superior de 100");
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        double total = caixa.TotalizarComanda(controleMesa);
                        Console.WriteLine("Total da comanda: " + total);
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine(controleMesa.ListarComanda());
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
