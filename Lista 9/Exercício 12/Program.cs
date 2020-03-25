using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o texto");
            string texto = Console.ReadLine();
            string senha = Senha(texto);

            Console.WriteLine($"A senha gerada foi {senha}");
            Console.ReadKey();
        }

        public static string Senha(string t)
        {
            string[] lista = t.Split(' ');
            string s = string.Empty;

            foreach (string palavra in lista)
            {
                string numeroCaracteres = (palavra.Length).ToString();
                s += numeroCaracteres;
            }

            return s;
        }
    }
}
