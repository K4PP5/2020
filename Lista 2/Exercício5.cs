using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Informe o número do mês");
    int mês = int.Parse(Console.ReadLine());

    switch(mês){
      case 1: Console.WriteLine("O mês de Janeiro é do primeiro trimestre do ano"); break;
      case 2: Console.WriteLine("O mês de Fevereiro é do primeiro trimestre do ano"); break;
      case 3: Console.WriteLine("O mês de Março é do primeiro trimestre do ano"); break;
      case 4: Console.WriteLine("O mês de Abril é do segundo trimestre do ano"); break;
      case 5: Console.WriteLine("O mês de Maio é do segundo trimestre do ano"); break;
      case 6: Console.WriteLine("O mês de Junho é do segundo trimestre do ano"); break;
      case 7: Console.WriteLine("O mês de Julho é do terceiro trimestre do ano"); break;
      case 8: Console.WriteLine("O mês de Agosto é do terceiro trimestre do ano"); break;
      case 9: Console.WriteLine("O mês de Setembro é do terceiro trimestre do ano"); break;
      case 10: Console.WriteLine("O mês de Outubro é do quarto trimestre do ano"); break;
      case 11: Console.WriteLine("O mês de Novembro é do quarto trimestre do ano"); break;
      case 12: Console.WriteLine("O mês de Dezembro é do quarto trimestre do ano"); break;
      default: Console.WriteLine("Mês inválido"); break;
    }
  }
}
