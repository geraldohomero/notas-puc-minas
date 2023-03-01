using System;

class MainClass {
  public static void Main (string[] args) {
    Double numero, raiz;
    int cont = 1;
    // Calcula a raiz quadrada de 10 numeros
    while (cont <= 10)
    {
      Console.Write("Digite um numero: ");
      numero = Double.Parse(Console.ReadLine()); 
      raiz = Math.Sqrt(numero);
      Console.WriteLine($"A raiz quadrada de {numero} = {raiz}");
      cont = cont + 1; // ou cont++ ou cont += 1
    }
  }
}