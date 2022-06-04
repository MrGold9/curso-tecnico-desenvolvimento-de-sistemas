using System;

namespace Exercicio_Fixacao02
{
    class Program
    {
        static void Main(string[] args) {
            Double preço, quantidade, valor;

            Console.WriteLine ("Informe o preço do produto");
            preço = Convert.ToDouble (Console.ReadLine ());
            Console.WriteLine ("informe a quantidade do produto");
            quantidade = Convert.ToDouble (Console.ReadLine ());
            valor = preço * quantidade;
            Console.Write ("Valor total=" + valor);
            Console.ReadKey ();
    }
    }
}
