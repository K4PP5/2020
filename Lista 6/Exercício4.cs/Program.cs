using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício4.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 30; i++)
            {
                int numero = i;
                if (i % 3 == 0) numero *= -1;
                Console.Write($"{numero} ");

            }
            Console.ReadKey();
        }
    }
}
