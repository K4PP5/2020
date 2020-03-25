using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_6
{
    class Program
    {
        public static double Frete(double m, double d)
        {
            return (m / d) / 100;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Informe a massa da carga e a distância até o destino");
            double massa = double.Parse(Console.ReadLine()), distância = double.Parse(Console.ReadLine());
            double frete = Frete(massa, distância);

            Console.Write("O valor do frete será R${0:0.00}", frete);
            Console.ReadKey();
        }
    }
}
