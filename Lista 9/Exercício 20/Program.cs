using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe três valores");
            int A = int.Parse(Console.ReadLine()), B = int.Parse(Console.ReadLine()), C = int.Parse(Console.ReadLine());
            Console.WriteLine("Deseja ordenar de forma crescente ou decrescente?");
            string opção = Console.ReadLine();
            bool decisão;

            if (opção == "crescente") decisão = true;
            else decisão = false;

            Ordenar(decisão, ref A, ref B, ref C);

            Console.WriteLine($"Números em ordem {opção}: {A} {B} {C}");
            Console.ReadKey();
        }

        static void Ordenar(bool crescente, ref int a, ref int b, ref int c)
        {
            int soma = a + b + c;

            int maior = a;
            if (b > maior) maior = b;
            if (c > maior) maior = c;

            int menor = a;
            if (b < menor) menor = b;
            if (c < menor) menor = c;

            int médio = soma - (maior + menor);

            if (crescente)
            {
                a = menor;
                b = médio;
                c = maior;
                
            }

            else
            {
                a = maior;
                b = médio;
                c = menor;
                
            }
        }
    }
}
