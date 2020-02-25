using System;

class MainClass {
  public static void Main (string[] args) {
    int pressaoMotorista, pressaoBomba, diferenca;
    pressaoBomba = int.Parse(Console.ReadLine());
    pressaoMotorista = int.Parse(Console.ReadLine());
    diferenca = pressaoBomba - pressaoMotorista;
    Console.WriteLine(diferenca);

  }
}
