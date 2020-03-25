using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome a ser formatado");
            string nome = Console.ReadLine();
            string formatado = FormatarNome(nome);

            Console.WriteLine(formatado);
            Console.ReadKey();
        }

        public static string FormatarNome(string n)
        {
            string[] lista = n.Split(' ');
            string final = string.Empty;

            foreach (string palavra in lista)
            {
                char primeiraLetra = palavra[0];
                string novaPalavra = string.Empty;

                if (Char.IsLower(primeiraLetra) && palavra != "e" && palavra != "da" && palavra != "das" && palavra != "de" && palavra != "do" && palavra != "dos")
                {
                    novaPalavra = palavra.Replace(primeiraLetra, Char.ToUpper(primeiraLetra));
                    final += novaPalavra + " ";
                }
                else final += palavra + " ";
            }

            return final;
        }
    }
}