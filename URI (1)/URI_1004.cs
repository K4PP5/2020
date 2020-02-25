using System;

class MainClass {
  public static void Main (string[] args) {
    int valor1, valor2, produto;
    valor1 = int.Parse(Console.ReadLine());
    valor2 = int.Parse(Console.ReadLine());
    produto = valor1 * valor2;
    Console.WriteLine($"PROD = {produto}");

  }
}
