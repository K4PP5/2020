using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeercício4.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome da primeira pessoa");
            string nome1 = Console.ReadLine();
            Console.WriteLine("Informe a data de nascimento");
            string[] data1 = Console.ReadLine().Split('/');
            int dia1, mes1, ano1;
            dia1 = int.Parse(data1[0]);
            mes1 = int.Parse(data1[1]);
            ano1 = int.Parse(data1[2]);

            Console.WriteLine("Informe o nome da segunda pessoa");
            string nome2 = Console.ReadLine();
            Console.WriteLine("Informe a data de nascimento");
            string[] data2 = Console.ReadLine().Split('/');
            int dia2, mes2, ano2;
            dia2 = int.Parse(data2[0]);
            mes2 = int.Parse(data2[1]);
            ano2 = int.Parse(data2[2]);

            if (ano1 < ano2) Console.WriteLine($"{nome1} é mais velho(a) que {nome2}");
            else if (ano2 < ano1) Console.WriteLine($"{nome2} é mais velho(a) que {nome1}");
            else if (ano1 == ano2)
            {
                if (mes1 < mes2) Console.WriteLine($"{nome1} é mais velho(a) que {nome2}");
                else if (mes2 < mes1) Console.WriteLine($"{nome2} é mais velho(a) que {nome1}");
                else if (mes1 == mes2)
                {
                    if (dia1 < dia2) Console.WriteLine($"{nome1} é mais velho(a) que {nome2}");
                    else if (dia2 < dia1) Console.WriteLine($"{nome2} é mais velho(a) que {nome1}");
                    else if (dia1 == dia2) Console.WriteLine("Os dois tem a mesma idade");

                }
            

            }
            Console.ReadKey();
        }
    }
}
