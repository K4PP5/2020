using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioA.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia = int.Parse(Console.ReadLine());
            double combustivel = double.Parse(Console.ReadLine());
            double consumo = distancia / combustivel;
            Console.WriteLine($"{consumo.ToString("0.000")} km/l");
            Console.ReadKey();

        }
    }
}
