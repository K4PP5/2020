using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício5.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            for (int i = 1; i <= 46; i += k)
            {
                Console.WriteLine($"{i} ");
                k++;

          

            }
            Console.ReadKey();
        }
    }
}
