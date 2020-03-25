using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o raio do círculo:");
            double raio = double.Parse(Console.ReadLine());
            double area = AreaCirculo(raio);

            Console.WriteLine("A área do círculo é {0:0.00}", area);
            Console.ReadKey();
        }

        public static double AreaCirculo(double x)
        {
            double pi = 3.1415;
            return pi * Math.Pow(x, 2);
        }
    }
}
