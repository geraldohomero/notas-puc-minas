using System;
class Program {
  public static void Main (string[] args) {

    double T, V, R, D, L;

    Console.Write("Por favor informe o tempo (T) gasto na viagem: ");
    T = double.Parse(Console.ReadLine());

    Console.Write("Por favor informe a velocidade media (V) durante a viagem: ");
    V = double.Parse(Console.ReadLine());

    Console.Write("Por favor informe o rendimento (R) médio do automóvel em km por litro: ");
    R = double.Parse(Console.ReadLine());

    D = T*V;
    L = D/R;

    Console.WriteLine("Distancia (D): {0}", D);
    Console.WriteLine("Litros (L) de combustível: {0}", L);

  }
}