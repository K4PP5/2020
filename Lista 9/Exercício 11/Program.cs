using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o texto e a posição da palavra");
            string texto = Console.ReadLine();
            int posição = int.Parse(Console.ReadLine());

            string palavra = Palavra(texto, posição);

            Console.WriteLine($"A palavra na posição {posição} é {palavra}");
            Console.ReadKey();
        }

        public static string Palavra(string t, int p)
        {
            string[] lista = t.Split(' ');
            return lista[p];
        }
    }
}
