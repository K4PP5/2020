using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite o horário no formato hh:mm");
    string[] valores = Console.ReadLine().Split(":");
    int horas = int.Parse(valores[0]);
    int minutos = int.Parse(valores[1]);
    int anugloHora = ((minutos / 5) - horas) * 30;
    int anguloMin = minutos / 2;
    int anguloTotal = Math.Abs(anguloMin - anugloHora);

    if (anguloTotal > 180) anguloTotal = 360 - anguloTotal;

    Console.WriteLine($"Menor ângulo entre os ponteiros = {anguloTotal} graus");
  }
}
