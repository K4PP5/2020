using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício6.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro horário");
            string[] tempo1 = Console.ReadLine().Split(' ');
            string[] horario1 = tempo1[0].Split(':');

            int horas1 = int.Parse(horario1[0]);
            int minutos1 = int.Parse(horario1[1]);
            string momento1 = tempo1[1];

            Console.WriteLine("Informe o segundo horário");
            string[] tempo2 = Console.ReadLine().Split(' ');
            string[] horario2 = tempo1[0].Split(':');

            int horas2 = int.Parse(horario2[0]);
            int minutos2 = int.Parse(horario2[1]);
            string momento2 = tempo2[1];

            if (momento1 == "AM" && momento2 == "PM") Console.WriteLine($"O maior horário é {horario2}");
            else if (momento1 == "PM" && momento2 == "AM") Console.WriteLine($"O maior horário é {horario1}");
            else if (momento1 == momento2)
            {
                if (horas1 > horas2) Console.WriteLine($"O maior horário é {horario1}");
                else if (horas2 > horas1) Console.WriteLine($"O maior horário é {horario2}");
                else if (horas1 == horas2)
                {
                    if (minutos1 > minutos2) Console.WriteLine($"O maior horário é {horario1}");
                    else if (minutos2 > minutos1) Console.WriteLine($"O maior horário é {horario2}");
                }
            }

            Console.ReadKey();


        }
    }
}
