using System;

class MainClass {
  public static void Main() {
    Console.WriteLine("Digite seu nome!");
    string nome = Console.ReadLine();
    Console.WriteLine($"Bem Vindo ao C#, {nome}");
    Console.WriteLine("Em qual ano você nasceu?");
    int ano = int.Parse(Console.ReadLine());
    Console.WriteLine($"Você tem {2020 - ano} anos, certo?");
  }
}
