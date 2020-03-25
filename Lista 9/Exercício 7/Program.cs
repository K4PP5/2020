using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_7
{
    class Program
    {        
        static void Main(string[] args)
        {
            Console.Write("Informe o número: ");
            int numero = int.Parse(Console.ReadLine());
            int antecessor, sucessor;

            AntecessorSucessor(numero, out antecessor, out sucessor);

            Console.WriteLine($"O antecessor é {antecessor} e o sucessor é {sucessor}");
            Console.ReadKey();
        }

        public static void AntecessorSucessor(int num, out int antecessor, out int sucessor)
        {
            antecessor = num - 1;
            sucessor = num + 1;
        }
    }
}
