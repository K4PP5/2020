using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício2.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome:");
            string[] nomeCompleto = Console.ReadLine().Split(' ');
            Console.Write($"{nomeCompleto[nomeCompleto.Length - 1]}, ");

            for (int i = 0; i < nomeCompleto.Length - 1; i++)
            {
                string nome = nomeCompleto[i];
                Console.Write($"{nome[0]}.");

            }
            Console.ReadKey();
        }
    }
}
