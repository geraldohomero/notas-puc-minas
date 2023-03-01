using System;

class MainClass {
  public static void Main (string[] args) {
    int n1, n2;
    double n3, n4;
    float n5;
    string s;
    bool b1, b2;
    Console.Write("Digite um número inteiro: ");
    n1 = int.Parse(Console.ReadLine());
    Console.Write("Digite outro número inteiro: ");
    n2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Digite um número real: ");
    n3 = double.Parse(Console.ReadLine());
    Console.Write("Digite outro número real: ");
    n4 = Convert.ToDouble(Console.ReadLine());
    
    Console.Write("Digite mais um número real: ");
    n5 = float.Parse(Console.ReadLine());

    Console.Write("Digite um booleano (digite true ou false): ");
    b1 = bool.Parse(Console.ReadLine());
    Console.ReadKey();
  }
}