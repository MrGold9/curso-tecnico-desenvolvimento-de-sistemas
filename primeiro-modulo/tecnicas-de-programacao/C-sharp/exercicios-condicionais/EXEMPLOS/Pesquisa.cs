using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesquisa
{
    class Program
    {
        static void Main(string[] args)

        {/*Os consumidores entrevistados deverão ser do sexo masculino, 
            idade entre 20 e 25 anos, da classe A ou B, nível superior, 
            que tenham adquirido o produto há mais de 6 meses e menos de 1 ano. 
            Teste as informações e exiba “Apto” ou “Fora da faixa pesquisada”*/
            Console.WriteLine("Informe seu gênero (M / F)");
            char genero = char.Parse(Console.ReadLine());

            if (genero == 'M')
            {
                Console.WriteLine("Informe sua idade");
                int idade = int.Parse(Console.ReadLine());
            
            if (idade >=20 && idade <=25)
            {
                Console.WriteLine("Informe sua classe (A, B, C, D, etc)");
                char classe = char.Parse(Console.ReadLine());
                if (classe == 'A' || classe == 'B')
                {
                    Console.WriteLine("Você possui nível superior? (S/N)");
                    char nivel = char.Parse(Console.ReadLine());

                    if (nivel == 'S')
                    {
                        Console.WriteLine("Há quantos meses o produto foi adquirido?");
                        int meses = int.Parse(Console.ReadLine());
                        if (meses >=6 && meses <= 12)
                        {
                            Console.WriteLine("Apto");
                        } else
                        {
                            Console.WriteLine("Fora da faixa de pesquisa");
                        }
                    } else
                    {
                        Console.WriteLine("Fora da faixa de pesquisa");
                    }
                } else
                {
                    Console.WriteLine("Fora da faixa de pesquisa");
                }
            } else
            {
                Console.WriteLine("Fora da faixa de pesquisa");
            }
            }
            else
            {
                Console.WriteLine("Fora da faixa de pesquisa");
            }

            Console.ReadKey();
        }
    }
}
