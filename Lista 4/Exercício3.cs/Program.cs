using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício3.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o salário atual");
            double salario = double.Parse(Console.ReadLine());

            if (salario < 500) salario += (salario * 0.2);
            else if (500 < salario && salario < 1000) salario += (salario * 0.15);
            else salario += (salario * 0.1);

            Console.WriteLine($"Seu novo salário é: {salario}");

            Console.ReadKey();
        }
    }
}
