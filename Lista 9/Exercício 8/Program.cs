using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número real");
            double real = double.Parse(Console.ReadLine());
            int menorInteiro = MenorInteiro(real);

            Console.WriteLine("O menor inteiro maior ou igual ao número informado é {0}", menorInteiro);
            Console.ReadKey();
        }

        public static int MenorInteiro(double x)
        {
            int y = Convert.ToInt32(x);

            if (y >= x) return y;
            y += 1;
            return y;

        }
    }
}
