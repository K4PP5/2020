using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício5.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorEntrada = 10;
            Console.WriteLine("Informe o dia da semana");
            string dia = Console.ReadLine();
            Console.WriteLine("Informe a hora inicial do filme");
            int hora = int.Parse(Console.ReadLine());

            if (dia == "segunda" || dia == "terça" || dia == "quarta") valorEntrada -= 2;
            else if (dia == "sexta" || dia == "sábado") valorEntrada += 5;

            if (hora < 17) valorEntrada -= 2;

            Console.WriteLine($"O valor da entrada é R$ {valorEntrada},00");
            Console.ReadKey();
        }
    }
}
