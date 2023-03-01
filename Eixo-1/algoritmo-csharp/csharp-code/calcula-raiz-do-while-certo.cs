using System;

class MainClass {
  public static void Main (string[] args) {
    Double numero, raiz;
    
    do
    {
      Console.Write("Digite um numero: ");
      numero = Double.Parse(Console.ReadLine());  
      if (numero > 0)
      {
        raiz = Math.Sqrt(numero);
        Console.WriteLine($"A raiz quadrada de {numero} = {raiz}");
      }
    } while (numero > 0);
  }
}