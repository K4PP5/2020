using System;

class MainClass {
  public static void Main (string[] args) {
    double dinheiro = double.Parse(Console.ReadLine());
    double cem = dinheiro / 100;
    double cinquenta = (dinheiro % 100) / 50;
    double vinte = ((dinheiro % 100) % 50) / 20;
    double dez = (((dinheiro % 100) % 50) % 20) / 10;
    double cinco = ((((dinheiro % 100) % 50) % 20) % 10) / 5;
    double dois = (((((dinheiro % 100) % 50) % 20) % 10) % 5) / 2;

    double um = (((((dinheiro % 100) % 50) % 20) % 10) % 5) % 2;
    double cinquentaCent = (((((((dinheiro % 100) % 50) % 20) % 10) % 5) % 2) % 1) / 0.5;
    double vinteCincoCent = ((((((((dinheiro % 100) % 50) % 20) % 10) % 5) % 2) % 1) % 0.5) / 0.25;
    double dezCent = (((((((((dinheiro % 100) % 50) % 20) % 10) % 5) % 2) % 1) % 0.5) % 0.25) / 0.1;
    double cincoCent = ((((((((((dinheiro % 100) % 50) % 20) % 10) % 1) % 5) % 2) % 0.5) % 0.25) % 0.1) /  0.05;
    double umCent = (((((((((((dinheiro % 100) % 50) % 20) % 10) % 1) % 5) % 2) % 0.5) % 0.25) % 0.1) % 0.5) / 0.01;

    Console.WriteLine($"NOTAS:\n{Math.Floor(cem)} nota(s) de R$ 100.00\n{Math.Floor(cinquenta)} nota(s) de R$ 50.00\n{Math.Floor(vinte)} nota(s) de R$ 20.00\n{Math.Floor(dez)} nota(s) de R$ 10.00\n{Math.Floor(cinco)} nota(s) de R$ 5.00\n{Math.Floor(dois)} nota(s) de R$ 2.00\nMOEDAS:\n{Math.Floor(um)} moeda(s) de R$ 1.00\n{Math.Floor(cinquentaCent)} moeda(s) de R$ 0.50\n{Math.Floor(vinteCincoCent)} moeda(s) de R$ 0.25\n{Math.Floor(dezCent)} moeda(s) de R$ 0.10\n{Math.Floor(cincoCent)} moeda(s) de R$ 0.05\n{Math.Floor(umCent)} moeda(s) de R$ 0.01");
  }
}
