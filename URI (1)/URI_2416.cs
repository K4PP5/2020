using System;

class MainClass {
  public static void Main (string[] args) {
    string[] valores = Console.ReadLine().Split(' ');
    int metrosLeonardo = int.Parse(valores[0]);
    int comprimentoPista = int.Parse(valores[1]);
    int termino = metrosLeonardo % comprimentoPista;
    Console.WriteLine(termino);
  }
}
