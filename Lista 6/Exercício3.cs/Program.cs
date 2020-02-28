using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício3.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int s = 1;

            while (Math.Abs(x) <= 10)
            {
                Console.Write(x * s + " ");
                s = -s;
                x++;
            }
            Console.ReadKey();
        }
    }
}
