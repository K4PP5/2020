using System;

class MainClass {
  public static void Main (string[] args) {
    double A, B, media1;
    A = double.Parse(Console.ReadLine());
    B = double.Parse(Console.ReadLine());
    media1 = (((A * 3.5) + (B * 7.5)) / 11);
    string media2 = media1.ToString("0.00000");
    Console.WriteLine($"MEDIA = {media2}");
  }
}
