using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite um valor monetário:");
    string dinheiro = Console.ReadLine();
    int reais, centavos;
    reais = int.Parse(dinheiro.Substring(1, 0));
    centavos = int.Parse(dinheiro.Substring(4, 3));
    Console.WriteLine($"{reais} reais e {centavos} centavos");
  }
}
