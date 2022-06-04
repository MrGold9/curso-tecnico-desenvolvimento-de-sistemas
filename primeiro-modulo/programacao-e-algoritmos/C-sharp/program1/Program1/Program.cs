using System;

namespace Program1
{
    class Program
    {
        static void Main(string[] args) {
            int n1, n2, n3;//Declaração da variável com tipo de dado inteiro
            Console.Write ("Digite um número:");//Mensagem para usuário
            n1 = Convert.ToInt32 (Console.ReadLine ());//Entrada de dados
            Console.Write ("Digite outro número:");//Mensagem para usuário
            n2 = Convert.ToInt32 (Console.ReadLine ());//Entrada de dados
            n3 = n1 + n2;
            Console.Write ("Resultado=" + n3);
            Console.ReadKey();
        }
    }
}
