using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite sua data de nascimento:");
    string ano = Console.ReadLine().Substring(6, 4);
    int idade = 2019 - int.Parse(ano);
    Console.WriteLine(idade);
  }
}
