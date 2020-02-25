using System;

class MainClass {
  public static void Main (string[] args) {
    int idadeDias, anos, meses, dias;
    idadeDias = int.Parse(Console.ReadLine());
    anos = idadeDias / 365;
    meses = (idadeDias % 365) / 30;
    dias = (idadeDias % 365) % 30;
    Console.WriteLine($"{anos} ano(s)\n{meses} mes(es)\n{dias} dia(s)");
  }
}
