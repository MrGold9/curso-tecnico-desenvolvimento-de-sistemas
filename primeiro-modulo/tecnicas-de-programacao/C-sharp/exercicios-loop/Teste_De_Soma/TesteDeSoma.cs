using System;

namespace Teste_De_Soma
{
    class TesteDeSoma
    {
        static void Main(string[] args)
        {
            int numero1, numero2, resultado_ori, resultado, cont = 0, cont_geral=0, percentual;
            char novamente = 'S';
            Random gerador = new Random();
            while (novamente == 'S' || novamente == 's')
            {
                cont_geral++;
                numero1 = gerador.Next(1, 11);
                numero2 = gerador.Next(1, 11);
                Console.WriteLine("Quanto é " + numero1 + "+" + numero2);
                resultado_ori = numero1 + numero2;
                Console.WriteLine("Digite o resultado da soma: ");
                resultado = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (resultado_ori == resultado)
                {
                    cont++;
                    Console.WriteLine("Uhuuu, você acertou! Você deseja continuar? (S/N) (Pressione a tecla 'enter' após)");
                    novamente = char.Parse(Console.ReadLine());
                }
                percentual = cont / cont_geral;
                percentual = percentual * 100;
                Console.WriteLine("Seus acertos foram= " + cont);
                Console.WriteLine("Percentual de acertos é= " + percentual + "%");
                Console.WriteLine();
                Console.WriteLine();

                if (resultado_ori != resultado)
                {
                    Console.WriteLine("Puuts, deseja tentar novamente? (S/N) (Pressione a tecla 'enter' após)");
                    novamente = char.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
        }
    }
}
