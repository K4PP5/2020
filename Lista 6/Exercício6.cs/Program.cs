using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício6.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            int i = 1;
            int contador = 0;
            while (i <= 30)
            {
                k += i;
                Console.Write($"{i} ");
                if (contador < 3)
                {
                    i++;
                    contador++;
                }
                else if (contador == 3)
                {
                    i += k;
                    contador = 0;
                    k = 0;
                }
            }
            Console.ReadKey();
        }
    }
}
