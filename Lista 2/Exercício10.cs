using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite uma data no formato dd/mm/aaaa");
    string[] data = Console.ReadLine().Split("/");
    int dia = int.Parse(data[0]);
    int mes = int.Parse(data[1]);
    int ano = int.Parse(data[2]);

    if (dia > 30 || dia < 1) Console.WriteLine("A data informada não é válida");
    if (mes > 12 || mes < 1) Console.WriteLine("A data informada não é válida");
    if (ano > 2100 || ano < 1900) Console.WriteLine("A data informada não é válida");

  }
}
