using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o texto a ser analisado");
            string texto = Console.ReadLine();
            string iniciais = Iniciais(texto);

            Console.WriteLine(iniciais);
            Console.ReadKey();
        }

        public static string Iniciais(string s)
        {
            string abreviação = s[0] + ". ";
            int indexEspaço = s.IndexOf(' ');

            while (indexEspaço != -1)
            {
                s = s.Substring(indexEspaço + 1);
                indexEspaço = s.IndexOf(' ');
                abreviação += s[0] + ". ";
            }

            return abreviação;
        }
    }
}
