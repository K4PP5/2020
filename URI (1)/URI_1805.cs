using System;

class MainClass {
  public static void Main (string[] args) {
    string[] valores = Console.ReadLine().Split(' ');
    int inicio = int.Parse(valores[0]);
    int final = int.Parse(valores[1]);
    int quantidade = (final - inicio) + 1;
    int naturais = ((inicio + final) * quantidade) / 2;
    Console.WriteLine(naturais);
  }
}
