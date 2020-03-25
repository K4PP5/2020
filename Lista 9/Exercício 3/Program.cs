using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor da base e altura de um retângulo");
            double Base = double.Parse(Console.ReadLine()), Altura = double.Parse(Console.ReadLine());
            double diagonal = Diagonal(Base, Altura);

            Console.WriteLine("O tamanho da diagonal é {0:0.0}", diagonal);
            Console.ReadKey();
        }

        public static double Diagonal(double x, double y)
        {
            double z = Math.Pow(x, 2) + Math.Pow(y, 2);
            return Math.Sqrt(z);
        }
    }
}
