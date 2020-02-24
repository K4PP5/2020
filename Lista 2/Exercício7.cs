using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite os coeficientes a, b, e c de uma equação do II grau");
    int a, b, c, raiz1, raiz2;
    a = int.Parse(Console.ReadLine());
    b = int.Parse(Console.ReadLine());
    c = int.Parse(Console.ReadLine());
    double delta = (b * b) - 4 * a * c;
    raiz1 = 0;
    raiz2 = 0;
    if (delta < 0) Console.WriteLine("Impossível calcular");
    else {
      raiz1 = Convert.ToInt32((-b + Math.Sqrt(delta))/2*a);
      raiz2 = Convert.ToInt32((-b - Math.Sqrt(delta))/2*a);
      Console.WriteLine($"As raízes são {raiz1} e {raiz2}");
    }
  }
}
