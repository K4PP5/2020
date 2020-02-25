using System;

class MainClass {
  public static void Main (string[] args) {
    string[] numeros = Console.ReadLine().Split(' ');
    int t1, t2, t3, t4, total;
    t1 = int.Parse(numeros[0]) - 1;
    t2 = int.Parse(numeros[1]) - 1;
    t3 = int.Parse(numeros[2]) - 1;
    t4 = int.Parse(numeros[3]);
    total = t1 + t2 + t3 + t4;
    Console.WriteLine(total);
  }
}
