using System;

namespace ParOuImpar
{
    class ParOuImpar
    {
        static void Main(string[] args)
        {
            int placar_j, placar_c, contador;
            placar_j = 0;
            placar_c = 0;
            contador = 1;
            contador++;

            Random gerador = new Random();
            int numero = gerador.Next(0, 999);

            char Par = '1';
            char Impar = '2';


            while (Par == '1' || Impar == '2')
            {
                gerador = new Random();
                numero = gerador.Next(0, 999);
                Console.WriteLine(numero + " Este número é Par ou Ímpar? Par = '1' e Ímpar = '2' (digite 'sair' para fechar o programa):");
                Par = Impar = char.Parse(Console.ReadLine());
                if (numero % 2 == 0 && Par == '1')
                    {
                        placar_j++;
                        Console.WriteLine("Placar do Jogador= " + placar_j);
                        Console.WriteLine("Placar do Computador= " + placar_c);
                    }
                if (numero % 2 == 1 && Impar == '2')
                {
                    placar_j++;
                    Console.WriteLine("Placar do Jogador= " + placar_j);
                    Console.WriteLine("Placar do Computador= " + placar_c);
                }
                if (numero % 2 == 0 && Par != '1')
                    {
                        placar_c++;
                    Console.WriteLine("Placar do Jogador= " + placar_j);
                    Console.WriteLine("Placar do Computador= " + placar_c);
                }
                if (numero % 2 == 1 && Impar != '2')
                {
                    placar_c++;
                    Console.WriteLine("Placar do Jogador= " + placar_j);
                    Console.WriteLine("Placar do Computador= " + placar_c);
                }
            }

            Console.ReadKey();
        }
    }
}
