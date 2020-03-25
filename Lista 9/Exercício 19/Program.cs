using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a distância percorrida em quilômetros e o tempo gasto no formato hh:mm:ss");
            double distancia = double.Parse(Console.ReadLine());
            string tempo = Console.ReadLine();
            double velocidade = VelocidadeMedia(distancia, tempo);

            Console.WriteLine("A velocidade média do atleta é {0:0.00} km/h", velocidade);
            Console.ReadKey();
        }

        public static double VelocidadeMedia(double d, string t)
        {
            string[] valores = t.Split(':');
            double horas = double.Parse(valores[0]), minutos = double.Parse(valores[1]), segundos = double.Parse(valores[2]);
            double minHora = minutos / 60;
            double segHora = segundos / 3600;

            double horaConvertida = horas + minHora + segHora;

            return d / horaConvertida;
        }
    }
}
