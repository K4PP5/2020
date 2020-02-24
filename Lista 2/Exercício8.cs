using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite quatro valores inteiros");
    int a, b, c, d, maior, menor, somaTotal, soma2;
    a = int.Parse(Console.ReadLine());
    b = int.Parse(Console.ReadLine());
    c = int.Parse(Console.ReadLine());
    d = int.Parse(Console.ReadLine());
    maior = a;
    if (b > maior) maior = b;
    if (c > maior) maior = c;
    if (d > maior) maior = d;
    menor = a;
    if (b < menor) menor = b;
    if (c < menor) menor = c;
    if (d < menor) menor = d;

    somaTotal = a + b + c + d;
    soma2 = somaTotal - maior - menor;
    Console.WriteLine($"Maior valor = {maior}\nMenor valor = {menor}\nA soma do segundo vaior valor com o segundo menor = {soma2}");

  }
}
