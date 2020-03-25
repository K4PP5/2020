using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_4
{
    class Program
    {
        public static double VolumeEsfera(double r)
        {
            double raioTerceira = Math.Pow(r, 3);
            return (4 * 3.1415 * raioTerceira) / 3;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Informe o tamanho do raio");
            double raio = double.Parse(Console.ReadLine());
            double volume = VolumeEsfera(raio);

            Console.WriteLine("O volume da esfera é {0:0.00}", volume);
            Console.ReadKey();
        }
    }
}
