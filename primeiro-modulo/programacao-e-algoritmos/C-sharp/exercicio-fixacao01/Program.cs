using System;

namespace Exercicio_Fixacao01
{
    class Program
    {
        static void Main(string[] args) {
            Double tempo, velocidade, distancia, litros_usados;

            Console.WriteLine ("informe o tempo gasto na viagem");
            tempo = Convert.ToDouble (Console.ReadLine ());
            Console.WriteLine ("informe a velocidade");
            velocidade = Convert.ToDouble (Console.ReadLine ());
            distancia = tempo * velocidade;
            Console.Write ("\n Distancia=" + distancia);
            litros_usados = distancia / 12;
            Console.Write("\nLitros usados=" + litros_usados);
            Console.ReadKey();
        }
    }
}
