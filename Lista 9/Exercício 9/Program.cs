using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o início e final do intervalo");
            int inicio = int.Parse(Console.ReadLine()), fim = int.Parse(Console.ReadLine());
            int somaInteiros = Soma(inicio, fim);

            Console.WriteLine($"A soma dos números inteiros nesse intervalo é {somaInteiros}");
            Console.ReadKey();
        }

        public static int Soma(int i, int f)
        {
            int n = (f - i) + 1;
            return ((i + f) * n) / 2;
        }
    }
}
