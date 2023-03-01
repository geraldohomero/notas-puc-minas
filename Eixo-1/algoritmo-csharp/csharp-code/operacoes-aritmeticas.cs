using System;

class MainClass {
  public static void Main (string[] args) {
   int a = 5, b = 2, c;
   int Soma, Subt, Mult, Quociente, Resto;
   Double DivExata, RaizQuadrada, Quadrado, Cubo, RaizCubica;
   // Realização dos cálculos
   Soma = a + b;
   Subt = a - b;
   Mult = a * b;
   Quociente = a / b;
   Resto = a % b;
   DivExata = 9 / 2.0;
   RaizQuadrada = Math.Sqrt(36);
   Quadrado = Math.Pow(a, b);
   c = b + 1;
   Cubo = Math.Pow(c, c);
   RaizCubica = Math.Pow(125, 1/3.0);
   // Impressão
   Console.WriteLine($"{a} + {b} = {Soma}");
   Console.WriteLine($"{a} - {b} = {Subt}"); 
   Console.WriteLine($"{a} * {b} = {Mult}");
   Console.WriteLine($"{a} / {b} = {Quociente}");
   Console.WriteLine($"{a} % {b} = {Resto}");
   Console.WriteLine($"9 / 2.0 = {DivExata}"); 
   Console.WriteLine($"A raiz quadrada de 36 = {RaizQuadrada}");
   Console.WriteLine($"{a} elevado a {b} = {Quadrado}"); 
   Console.WriteLine($"{c} elevado a {c} = {Cubo}"); 
   Console.WriteLine($"A raiz cubica de 125 = {RaizCubica}"); 
  }
}