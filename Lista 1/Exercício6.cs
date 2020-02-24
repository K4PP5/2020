using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite a base e a altura do retângulo");
    int baseRetangulo, altura;
    baseRetangulo = int.Parse(Console.ReadLine());
    altura = int.Parse(Console.ReadLine());
    double area, perimetro, diagonal;
    area = baseRetangulo * altura;
    perimetro = (baseRetangulo * 2) + (altura * 2);
    diagonal = Math.Sqrt((baseRetangulo * baseRetangulo) + (altura * altura));
    Console.WriteLine($"Área = {area} - Perímetro = {perimetro} - Diagonal = {diagonal}");

  }
}
