using System;

class MainClass {
  public static void Main (string[] args) {
    int num;
    int soma = 0; // Acumulador - manter o mesmo tipo de variáveis int-int
                  // ..double-double

    Console.Write("Digite um numero maior que zero: ");
    num = int.Parse(Console.ReadLine());
    while (num > 0) 
    {
      soma = soma + num;
      Console.Write("Digite um numero maior que zero: ");
      num = int.Parse(Console.ReadLine());
    }
    Console.Write($"A soma dos numeros digitados = {soma}.");
  }
}