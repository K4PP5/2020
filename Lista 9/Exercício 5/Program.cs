using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_5
{
    class Program
    {
        public static double VolumeLitros(double h, double l, double p)
        {
            return h * l * p;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Infome a altura, largura e profundidade da caixa d'água");
            double altura = double.Parse(Console.ReadLine()), largura = double.Parse(Console.ReadLine()), profundidade = double.Parse(Console.ReadLine());
            double volume = VolumeLitros(altura, largura, profundidade);

            Console.WriteLine("O volume da caixa d'água é {0:0.00} litros", volume);
            Console.ReadKey();
        }

    }
}
