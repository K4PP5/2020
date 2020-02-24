using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite três valores inteiros");
    int a, b, c;
    a = int.Parse(Console.ReadLine());
    b = int.Parse(Console.ReadLine());
    c = int.Parse(Console.ReadLine());
    int maior = a;
    if (b > maior) maior = b;
    if (c > maior) maior = c;

    int menor = a;
    if (b < maior) menor = b;
    if (c < maior) menor = c;

    int soma = maior + menor;
    Console.WriteLine($"A soma do maior com o menor número é {soma}.");
 
  }
}
