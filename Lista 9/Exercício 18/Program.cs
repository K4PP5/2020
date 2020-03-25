using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o número a ser verificado: ");
            int numero = int.Parse(Console.ReadLine());
            bool éPrimo = Primo(numero);

            if (éPrimo) Console.WriteLine("O número informado é primo.");
            else Console.WriteLine("O número informado não é primo.");

            Console.ReadKey();
        }

        public static bool Primo(int n)
        {
            int contador = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0) contador++;
            }

            if (contador <= 2) return true;
            else return false;
        }
    }
}
