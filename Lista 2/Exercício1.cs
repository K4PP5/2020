using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite dois valores inteiros");
    int a, b, maior;
    a = int.Parse(Console.ReadLine());
    b = int.Parse(Console.ReadLine());
    maior = a;
    if (b > maior) maior = b;

    Console.WriteLine($"Maior = {maior}");
  }
}
