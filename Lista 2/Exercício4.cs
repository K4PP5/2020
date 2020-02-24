using System;

class MainClass {
  public static void Main (string[] args) {
    string[] valores1 = Console.ReadLine().Split(":");
    int horas1 = int.Parse(valores1[0]);
    int minutos1 = int.Parse(valores1[1]);

    string[] valores2 = Console.ReadLine().Split(":");
    int horas2 = int.Parse(valores2[0]);
    int minutos2 = int.Parse(valores2[1]);

    int horasFinal = horas1 + horas2;
    int minutosFinal = minutos1 + minutos2;

    if (minutosFinal > 59) horasFinal = horasFinal + minutosFinal / 60;
    if (minutosFinal > 59) minutosFinal = minutosFinal % 60;

    Console.WriteLine($"{horasFinal}:{minutosFinal}");


  }
}
