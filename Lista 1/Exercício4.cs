using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite as notas dos três primeiros bimestres:");
    int primeiro, segundo, terceiro;
    primeiro = int.Parse(Console.ReadLine());
    segundo = int.Parse(Console.ReadLine());
    terceiro = int.Parse(Console.ReadLine());
    int necessario = (600 - ((primeiro * 2) + (segundo * 2) + (terceiro * 3))) / 3;
    Console.WriteLine($"Nota para passar = {necessario}");
  }
}
