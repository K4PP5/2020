using System;

class MainClass {
  public static void Main (string[] args) {
    int anos, cigarrosPorDia;
    Console.WriteLine ("Há quantos anos você fuma?");
    anos = int.Parse(Console.ReadLine());
    Console.WriteLine ("Quantos cigarros por dia?");
    cigarrosPorDia = int.Parse(Console.ReadLine());
    Console.WriteLine ("Qual o preço da carteira de cigarros?");
    double carteira = double.Parse(Console.ReadLine());
    double total = Math.Round(((anos * 365) / (20 / cigarrosPorDia)) * carteira, 2);
    Console.WriteLine($"Total gasto = R${total}");
  }
}
