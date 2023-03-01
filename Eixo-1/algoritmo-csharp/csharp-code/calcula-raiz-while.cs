using System;
class MainClass {
  public static void Main (string[] args) {
    Double numero, raiz;

    Console.Write ("Digite um número: ");
    numero = Double.Parse(Console.ReadLine());
    while (numero > 0)
    {
      raiz = Math.Sqrt(numero);
      Console.WriteLine($"A raíz quadrada de {numero} = {raiz}");
      Console.Write("Digite um número: ");
      numero = Double.Parse(Console.ReadLine());
    }
  }
}