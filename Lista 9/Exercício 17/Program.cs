using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois números inteiros positivos");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            int mmc = MMC(A, B);

            Console.WriteLine($"O MMC entre {A} e {B} é {mmc}");
            Console.ReadKey();
        }

        public static int MMC(int x, int y)
        {
            int b = 2, contador = 1;
            while (x > 1 || y > 1)
            {
                if (x % b == 0 || y % b == 0)
                {
                    contador *= b;
                    if (x % b == 0) x /= b;
                    if (y % b == 0) y /= b;
                }
                else b++;
            }

            return contador;
        }
    }
}
