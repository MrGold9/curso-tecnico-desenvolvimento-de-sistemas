using System;

namespace MediaDezNumeros
{
    class MediaDezNumeros
    {
        static void Main(string[] args)
        {
            double num = 0, media = 0, somatoria = 0; ;
            for (int cont = 1; cont <= 10; cont++)
            {
                Console.WriteLine("Digite um número: ");
                num = Convert.ToDouble(Console.ReadLine());
                somatoria = somatoria + num;
            }
            media = somatoria / 10;
            Console.WriteLine("A média dos números é= " + media);
            Console.ReadKey();
        }
    }
}
