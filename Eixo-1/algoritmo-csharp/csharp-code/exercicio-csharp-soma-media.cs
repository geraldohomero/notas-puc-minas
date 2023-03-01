using System;
class MainClass {
    public static void Main (string[] args) {
        //Declara variáveis
        int n1, n2, n3, n4, n5, Soma;
        Double Media;
        //Entra dados
        Console.Write("Digite o primeiro número: ");
        n1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        n2 = int.Parse(Console.ReadLine());
        Console.Write("Digite o terceiro número: ");
        n3 = int.Parse(Console.ReadLine());
        Console.Write("Digite o quarto número: ");
        n4 = int.Parse(Console.ReadLine());
        Console.Write("Digite o último número: ");
        n5 = int.Parse(Console.ReadLine());
        //Cálculo
        Soma = n1 + n2 + n3 + n4 + n5;
        Media = Soma / 5.0;
        //Saída
        Console.WriteLine($"Soma = {Soma}");
        Console.WriteLine($"Média = {Media}");
    }
}