using System;

class MainClass {
  public static void Main (string[] args) {
    int a, b, c, d, somaPar, somaImpar;
    a = int.Parse(Console.ReadLine());
    b = int.Parse(Console.ReadLine());
    c = int.Parse(Console.ReadLine());
    d = int.Parse(Console.ReadLine());
    somaPar = 0;
    somaImpar = 0;

    somaPar = somaPar + (a % 2 == 0 ? a : 0);
    somaPar = somaPar + (b % 2 == 0 ? b : 0);
    somaPar = somaPar + (c % 2 == 0 ? c : 0);
    somaPar = somaPar + (d % 2 == 0 ? d : 0);

    somaImpar = somaImpar + (a % 2 != 0 ? a : 0);
    somaImpar = somaImpar + (b % 2 != 0 ? b : 0);
    somaImpar = somaImpar + (c % 2 != 0 ? c : 0);
    somaImpar = somaImpar + (d % 2 != 0 ? d : 0);
    Console.WriteLine($"Soma dos pares = {somaPar}");
    Console.WriteLine($"Soma dos ímpares = {somaImpar}");


  }
}
