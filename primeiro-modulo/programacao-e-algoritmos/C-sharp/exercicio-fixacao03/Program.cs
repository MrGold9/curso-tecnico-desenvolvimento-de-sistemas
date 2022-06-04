using System;

namespace Exercicio_Fixacao03
{
    class Program
    {
        static void Main(string[] args) {
            Double salario, hora, total_horas, total_mes, desconto;            
            Console.WriteLine ("Valor por hora");
            salario = Convert.ToDouble (Console.ReadLine ());
            Console.WriteLine ("Quantidade de horas");
            hora = Convert.ToDouble (Console.ReadLine ());
            total_horas = salario * hora;
            Console.Write ("Pagamento por horas trabalhadas=" + total_horas);
            Console.ReadKey ();
        }
    }
    }

