using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a data");
            string[] data = Console.ReadLine().Split('/');
            int mes = int.Parse(data[1]), ano = int.Parse(data[2]);
            string ultimo = UltimoDia(mes, ano);

            Console.WriteLine($"O último dia do mês é {ultimo}");
            Console.ReadKey();
        }

        public static string UltimoDia(int m, int a)
        {
            if (m == 01 || m == 03 || m == 05 || m == 07 || m == 08 || m == 10 || m == 12) return "31";

            bool bissexto;

            if ((a % 4 == 0 && a % 100 != 0) || (a % 4 != 0 && a % 400 == 0)) bissexto = true;
            else bissexto = false;

            if (m == 02)
            {
                if (bissexto) return "29";
                else return "28";
            }

            else return "30";
        }
    }
}
