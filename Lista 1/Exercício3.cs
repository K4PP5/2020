using System;

class MainClass {
  public static void Main (string[] args) {
    const double pi = 3.14159265359;
    Console.WriteLine ("Digite o raio de um círculo:");
    double raio = double.Parse(Console.ReadLine());
    double circunferencia = 2 * pi * raio;
    double area = pi * raio * raio;
    Console.WriteLine ($"Circunferência = {circunferencia}\nÁrea = {area}");

  }
}
