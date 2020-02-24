using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite quatro valores inteiros");
    int a, b, c, d, media;
    a = int.Parse(Console.ReadLine());
    b = int.Parse(Console.ReadLine());
    c = int.Parse(Console.ReadLine());
    d = int.Parse(Console.ReadLine());
    media = (a + b + c + d) / 4;

    Console.WriteLine($"Média = {media}");

    Console.WriteLine("Números menores que a média");

    if (a < media) Console.WriteLine(a);
    if (b < media) Console.WriteLine(b);
    if (c < media) Console.WriteLine(c);
    if (d < media) Console.WriteLine(d);

    Console.WriteLine("Números maiores ou iguais à média");

    if (a >= media) Console.WriteLine(a);
    if (b >= media) Console.WriteLine(b);
    if (c >= media) Console.WriteLine(c);
    if (d >= media) Console.WriteLine(d);

  }
}
