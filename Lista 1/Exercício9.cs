using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Informe sua massa em kg:");
    int massa = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe sua altura em metros:");
    double altura = double.Parse(Console.ReadLine());
    double IMC = Math.Round(massa / (altura * altura), 2);
    Console.WriteLine($"Seu IMC é {IMC}");
  }
}
