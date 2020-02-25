using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite uma data no formato dd/mm/aaaa");
    string[] valores = Console.ReadLine().Split("/");
    string dia = valores[0];
    int mês = int.Parse(valores[1]);
    string ano = valores[2];

    switch(mês) {
      case 1: Console.WriteLine($"A data é {dia} de Janeiro de {ano}"); break;
      case 2: Console.WriteLine($"A data é {dia} de Fevereiro de {ano}"); break;
      case 3: Console.WriteLine($"A data é {dia} de Março de {ano}"); break;
      case 4: Console.WriteLine($"A data é {dia} de Abril de {ano}"); break;
      case 5: Console.WriteLine($"A data é {dia} de Maio de {ano}"); break;
      case 6: Console.WriteLine($"A data é {dia} de Junho de {ano}"); break;
      case 7: Console.WriteLine($"A data é {dia} de Julho de {ano}"); break;
      case 8: Console.WriteLine($"A data é {dia} de Agosto de {ano}"); break;
      case 9: Console.WriteLine($"A data é {dia} de Setembro de {ano}"); break;
      case 10: Console.WriteLine($"A data é {dia} de Outubro de {ano}"); break;
      case 11: Console.WriteLine($"A data é {dia} de Novembro de {ano}"); break;
      case 12: Console.WriteLine($"A data é {dia} de Dezembro de {ano}"); break;
    }

    
  }
}
