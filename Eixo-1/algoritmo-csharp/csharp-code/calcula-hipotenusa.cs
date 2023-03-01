using System;

class MainClass {
  public static void Main (string[] args) {
    Double Hipotenusa, Cateto1, Cateto2;

    Console.Write("Informe o valor do primeiro cateto: ");
    Cateto1 = Double.Parse(Console.ReadLine());
    Console.Write("Informe o valor do segundo cateto: ");
    Cateto2 = Double.Parse(Console.ReadLine());

    Hipotenusa = Math.Sqrt(Math.Pow(Cateto1,2) + Math.Pow(Cateto2,2));
    Console.WriteLine($"A Hipotenusa é = {Hipotenusa}");
  }
}