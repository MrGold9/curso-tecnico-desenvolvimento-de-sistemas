using System;

namespace Maior_Ganha
{
    class MaiorGanha
    {
        static void Main(string[] args)
        {
            char continuar = 'S';
            Random gerador = new Random();
            int numero_j, numero_c , placar_j = 0, placar_c = 0;
            do
            {
                numero_j = gerador.Next(0, 999);
                numero_c = gerador.Next(0, 999);
                Console.WriteLine("O número obtido para o jogador é: " + numero_j);
                Console.WriteLine("O número obtido para o computador é: " + numero_c);
                  Console.WriteLine();
                Console.WriteLine("Deseja continuar apostando? (S/N) ");
                continuar = char.Parse(Console.ReadLine());
                if (numero_j > numero_c)
                {
                    placar_j++;
                    Console.WriteLine("A pontuação do jogador é= " + placar_j);
                    Console.WriteLine("A pontuação do computador é= " + placar_c);
                      Console.WriteLine();
                      Console.WriteLine();

                }
                if (numero_c > numero_j)
                {
                    placar_c++;
                    Console.WriteLine("A pontuação do jogador é= " + placar_j);
                    Console.WriteLine("A pontuação do computador é= " + placar_c);
                      Console.WriteLine();
                      Console.WriteLine();
                }
                if (numero_j == numero_c)
                {
                    Console.WriteLine("A pontuação do jogador é= " + placar_j);
                    Console.WriteLine("A pontuação do computador é= " + placar_c);
                    Console.WriteLine();
                    Console.WriteLine();
                }
            } 
            while (continuar == 'S' || continuar == 's');
            Console.ReadKey();
        }
    }
}
