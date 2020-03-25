using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o texto");
            string texto = Console.ReadLine();
            string semEspaço = RemoverEspacos(texto);

            Console.WriteLine(semEspaço);
            Console.ReadKey();
        }

        public static string RemoverEspacos(string t)
        {
            foreach (char c in t)
            {
                if (c == ' ') t = t.Remove(t.IndexOf(c), 1);
            }

            return t;

        }
    }
}
