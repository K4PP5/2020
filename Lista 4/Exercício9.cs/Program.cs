using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício9.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe quatro valores inteiros diferentes");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            int somaTotal = A + B + C + D;
            int maior = A;
            int menor = A;
            if (B > maior) maior = B;
            if (C > maior) maior = C;
            if (D > maior) maior = D;

            if (B < menor) menor = B;
            if (C < menor) menor = C;
            if (D < menor) menor = D;

            int soma2 = somaTotal - maior;




        }
    }
}
