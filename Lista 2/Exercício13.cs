using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite dez valores inteiros");
    string[] valores = Console.ReadLine().Split(' ');
    int a, b, c, d, e, f, g, h, i, j, maior, menor;
    a = int.Parse(valores[0]);
    b = int.Parse(valores[1]);
    c = int.Parse(valores[2]);
    d = int.Parse(valores[3]);
    e = int.Parse(valores[4]);
    f = int.Parse(valores[5]);
    g = int.Parse(valores[6]);
    h = int.Parse(valores[7]);
    i = int.Parse(valores[8]);
    j = int.Parse(valores[9]);

    maior = a;
    if (b > maior) maior = b;
    if (c > maior) maior = c;
    if (d > maior) maior = d;
    if (e > maior) maior = e;
    if (f > maior) maior = f;
    if (g > maior) maior = g;
    if (h > maior) maior = h;
    if (i > maior) maior = i;
    if (j > maior) maior = j;

    menor = a;
    if (b < menor) menor = b;
    if (c < menor) menor = c;
    if (d < menor) menor = d;
    if (e < menor) menor = e;
    if (f < menor) menor = f;
    if (g < menor) menor = g;
    if (h < menor) menor = h;
    if (i < menor) menor = i;
    if (j < menor) menor = j;

    Console.WriteLine($"O maior valor é {maior} e o menor é {menor}");
  }
}
