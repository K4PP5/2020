using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2
{
    class Program
    {
        struct Data
        {
            public int Dia;
            public int Mes;
            public int Ano;
        }
        static void Main(string[] args)
        {
            Data d = new Data();
            Console.Write("Informe a data: ");
            string[] valores = Console.ReadLine().Split('/');

            d.Dia = int.Parse(valores[0]);
            d.Mes = int.Parse(valores[1]);
            d.Ano = int.Parse(valores[2]);

            bool analise = Validação(d.Dia, d.Mes, d.Ano);

            if (analise) Console.WriteLine("A data informada é válida.");
            else Console.WriteLine("A data informada não é válida.");
            Console.ReadKey();
        }

        public static bool Validação(int d, int m, int a)
        {
            bool bissexto;
            if ((a % 4 == 0 && a % 100 != 0) || (a % 4 != 0 && a % 400 == 0)) bissexto = true;
            else bissexto = false;

            if (a > 0 && a <= 2020)
            {
                if (m >= 01 && m <= 12)
                {
                    if (m == 01 || m == 03 || m == 05 || m == 07 || m == 08 || m == 10 || m == 12)
                    {
                        if (d >= 01 && d <= 31) return true;
                        else return false;
                    }

                    else if (m == 02)
                    {
                        if (bissexto)
                        {
                            if (d >= 01 && d <= 29) return true;
                            else return false;
                        }
                        else if (d >= 1 && d <= 28) return true;
                        else return false;
                    }

                    else if (d >= 1 && d <= 30) return true;

                    else return false;
                }
                else return false;
            }
            else return false;
        }
    }
}
