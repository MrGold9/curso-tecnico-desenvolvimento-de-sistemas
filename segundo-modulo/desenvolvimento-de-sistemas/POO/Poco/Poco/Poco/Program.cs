using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poco
{
    class Program
    {
        static void Main(string[] args)
        {
            Poco p = new Poco();
            Console.WriteLine("Informe o diâmetro do Poço");
            p.SetDiametro(Double.Parse(Console.ReadLine()));
            Console.WriteLine("Informe a profundidade do Poço");
            p.SetProfundidade(Double.Parse(Console.ReadLine()));
            Console.WriteLine("A profundidade do poço é " + p.GetProfundidade());
            Console.WriteLine("O Volume do poço é " + p.Volume());
            Console.WriteLine(p.Valida());
        }
    }
}
