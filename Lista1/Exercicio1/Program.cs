using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as notas dos dois bimestres: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int m = (a * 2 + b * 3) / 5;
            Console.WriteLine($"Média parcial = {m}");
        }
    }
}
