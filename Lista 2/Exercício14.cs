using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite três valores");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    int maior = a;

    if (b > maior) maior = b;
    if (c > maior) maior = c;

    int menor = a;

    if (b < menor) menor = b;
    if (c < menor) menor = c;

    int medio = a;
    if (maior > b && b > menor) medio = b;
    if (maior > c && c > menor) medio = c;


    int somaMenores = (a + b + c) - maior;
    int diferença = maior - medio;

    if (somaMenores > maior && diferença < menor){
      if (a == b && b == c) Console.WriteLine("Triângulo equilátero");
      if (a == b || b == c || c == a) Console.WriteLine("Triângulo isósceles");
      if (a != b && b != c) Console.WriteLine("Triângulo escaleno");
    }
    else {
      Console.WriteLine("Esses valores não formam um triângulo");
    }

  }
}
