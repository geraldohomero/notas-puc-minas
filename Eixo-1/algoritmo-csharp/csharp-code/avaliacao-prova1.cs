using System;

class Program {  
  public static void Main (string[] args) {
    //  DECLARACAO DE VARIAVEIS
    int fruta = 0;
    
    // ENTRADA DE DADOS
    Console.Write("Digite a opção da sua fruta favorita ");
    Console.Write("1 - Abacaxi ");
    Console.Write("2 - Banana ");
    Console.Write("3 - Laranja ");
    Console.Write("4 - Maça ");
    Console.Write("5 - Uva ");
    fruta = int.Parse(Console.ReadLine());
    
    // IMPRIMINDO O RESULTADO
    Console.WriteLine("A fruta favorita digitada foi {0}", fruta);    
  }
}