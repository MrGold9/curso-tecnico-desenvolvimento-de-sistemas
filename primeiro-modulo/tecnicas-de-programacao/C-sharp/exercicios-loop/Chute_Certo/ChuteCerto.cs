using System;

namespace Chute_Certo
{
    class ChuteCerto
    {
        static void Main(string[] args)
        {
            int numero, num1;
            int placar_j = 0, placar_c = 0;

            do
            {
                Random gerador = new Random();
                numero = gerador.Next(0, 10);


                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" Digite um número de 0 a 10 ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("O número é= " + numero);
                if (num1 == numero)
                {
                    placar_j++;
                    Console.WriteLine("Você acertou!");
                    Console.WriteLine();
                    Console.WriteLine("A pontuação do jogador é= " + placar_j);
                    Console.WriteLine("A pontuação do computador é= " + placar_c);
                    Console.WriteLine();
                }
                else
                {
                    placar_c++;
                    Console.WriteLine("Você errou!");
                    Console.WriteLine();
                    Console.WriteLine("A pontuação do jogador é= " + placar_j);
                    Console.WriteLine("A pontuação do computador é= " + placar_c);
                    Console.WriteLine();
                }
            }
            while (numero <= 10);

            Console.ReadKey();
            }
        }
    }
