using System;

class MainClass {
  public static void Main (string[] args) {
    string[] valores1 = Console.ReadLine().Split(' ');
    string[] valores2 = Console.ReadLine().Split(' ');
    int comprimento, distancia, custoKM, valorPedagio, dinheiroComKM, dinheiroComPedagio, total;
    comprimento = int.Parse(valores1[0]);
    distancia = int.Parse(valores1[1]);
    custoKM = int.Parse(valores2[0]);
    valorPedagio = int.Parse(valores2[1]);

    dinheiroComKM = comprimento * custoKM;
    dinheiroComPedagio = (comprimento / distancia) * valorPedagio;
    total = dinheiroComKM + dinheiroComPedagio;
    Console.WriteLine(total);
  }
}
