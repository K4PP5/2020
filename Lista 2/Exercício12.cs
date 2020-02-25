using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite dois valores inteiros separados por um sinal +, -, * ou /");
			string operacao = Console.ReadLine();
			char sinal;
			if (operacao.Contains ("+")) {
				sinal = '+';
			} else if (operacao.Contains ("-")) {
				sinal = '-';
			} else if (operacao.Contains ("*")) {
				sinal = '*';
			} else if (operacao.Contains ("/")) {
				sinal = '/';
      } else {
				Console.WriteLine ("Expressão incorreta.");
				return;
			}

			int valor1, valor2;
			string[] valores = operacao.Split(sinal);
			valor1 = int.Parse (valores [0]);
			valor2 = int.Parse (valores [1]);
			int resultado;
			switch (sinal) {
				case '+': 
					resultado = valor1 + valor2;
					break;
				case '-': 
					resultado = valor1 - valor2;
					break;
				case '*': 
					resultado = valor1 * valor2;
					break;
				case '/': 
					resultado = valor1 / valor2;
					break;
				default:
					resultado = 0;
					break;
			}
			Console.WriteLine ($"O resultado da operação é {resultado}");
  }
}
