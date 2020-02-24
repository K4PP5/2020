using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite um valor monetário inteiro");
    int dinheiro = int.Parse(Console.ReadLine());
    int cem = dinheiro / 100;
    int cinquenta = (dinheiro % 100) / 50;
    int vinte = ((dinheiro % 100) % 50) / 20;
    int dez = (((dinheiro % 100) % 50) % 20) / 10;
    int cinco = ((((dinheiro % 100) % 50) % 20) % 10) / 5;
    int dois = (((((dinheiro % 100) % 50) % 20) % 10) % 5) / 2;
    int um = ((((((dinheiro % 100) % 50) % 20) % 10) % 5) % 2);
    Console.WriteLine($"{cem} cédula(s) de 100 reais\n{cinquenta} cédula(s) de 50 reais\n{vinte} cédula(s) de 20 reais\n{dez} cédula(s) de 10 reais\n{cinco} cédula(s) de 5 reais\n{dois} cédula(s) de 2 reais\n{um} cédula(s) de 1 real");
  }
}
