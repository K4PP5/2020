using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite dois números:");
            double A = double.Parse(Console.ReadLine()), B = double.Parse(Console.ReadLine());
            double maior = Maior(A, B);

            Console.WriteLine($"O maior número é {maior}");
            Console.ReadKey();
        }

        public static double Maior(double x, double y)
        {
            if (x > y) return x;
            else return y;
        }
    }
}
