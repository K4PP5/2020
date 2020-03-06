using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício1.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome:");
            string[] nomeCompleto = Console.ReadLine().Split(' ');
            Console.WriteLine($"{nomeCompleto[1]}, {nomeCompleto[0]}");
            Console.ReadKey();

        }
    }
}
