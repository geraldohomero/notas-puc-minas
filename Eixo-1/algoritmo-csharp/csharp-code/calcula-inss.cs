using System;

class MainClass {
  public static void Main (string[] args) {
    Double salario, inss; 

    Console.Write("Informe o seu salário: ");
    salario = Double.Parse(Console.ReadLine());

    inss = salario * 0.11;

    Console.WriteLine($"O valor do INSS é = {inss:0.00}");
  }
}