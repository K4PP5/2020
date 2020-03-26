using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1
{
    class Program
    {
        struct IMC
        {
            public double Massa;
            public double Altura;
            public double Imc;
        }
        static void Main(string[] args)
        {
            IMC seuIMC = new IMC();

            Console.Write("Informe sua massa em kg: ");
            seuIMC.Massa = double.Parse(Console.ReadLine());

            Console.Write("Informe sua altura em metros: ");
            seuIMC.Altura = double.Parse(Console.ReadLine());

            seuIMC.Imc = CalculoIMC(seuIMC.Massa, seuIMC.Altura);
            Console.WriteLine("Seu índice de massa corporal é {0:0.0}", seuIMC.Imc);
            Console.ReadKey();
        }

        public static double CalculoIMC(double m, double a)
        {
            return m / Math.Pow(a, 2);
        }
    }
}
