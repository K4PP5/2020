using System;

class MainClass {
  public static void Main (string[] args) {
    string[] valores = Console.ReadLine().Split(' ');
    int lados, comprimento, perimetro;
    lados = int.Parse(valores[0]);
    comprimento = int.Parse(valores[1]);
    perimetro = lados * comprimento;
    Console.WriteLine(perimetro);
  }
}
