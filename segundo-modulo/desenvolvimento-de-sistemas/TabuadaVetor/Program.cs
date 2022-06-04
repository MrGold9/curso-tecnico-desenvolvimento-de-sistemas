using System;

namespace TabuadaVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            char[][] matriz = {
                new char[] {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'} ,
                new char[] {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'},
                new char[] {' ', '-','/' }
            };

            Console.WriteLine("Informe seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe sua idade");
            int idade = int.Parse(Console.ReadLine());

            char[] nomeVetor = nome.ToCharArray();
            string[] indices = new string[nomeVetor.Length];
            string[] indicesIdade = new string[3];
            string indicesMatriz = "", indicesVetor = "";

            for (int i = 0; i < nomeVetor.Length; i++)
            {
                for (int x = 0; x < matriz.Length; x++)
                {
                    for (int y = 0; y < matriz[x].Length; y++)
                    {
                        if (nomeVetor[i] == matriz[x][y])
                        {
                            indices[i] = "[" + x + "]" + "[" + y + "]";
                            indicesMatriz += indices[i] + " , ";
                            break;
                        }
                    }
                }
            }

            for (int i = 0; i < idade.ToString().Length; i++)
            {
                for (int x = 0; x < vetor.Length; x++)
                {
                    if (idade.ToString().Substring(i, 1) == vetor[x].ToString())
                    {
                        indicesIdade[i] = "[" + x + "]";
                        indicesVetor += indicesIdade[i] + " , ";
                        break;
                    }
                }
            }

            Console.WriteLine("Indices da matriz = " + indicesMatriz);
            Console.WriteLine("Indices do vetor = " + indicesVetor);
            Console.ReadKey();
        }
    }
}
