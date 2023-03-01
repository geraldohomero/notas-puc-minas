using System;

class MainClass {
  public static void Main (string[] args) {
    int n1, n2, soma;
    double media;
    Console.Write("Digite um número: ");
    n1 = int.Parse(Console.ReadLine());
    Console.Write("Digite outro número: ");
    n2 = int.Parse(Console.ReadLine());
    soma = n1 + n2;
    media = soma / 2;
    Console.WriteLine("Soma = "+soma);
    Console.WriteLine("Media = "+media);
  }
}
