using System;

class MainClass {
    public static void Main (string[] args) {
        Double Salario, INSS;
        Console.Write("Digite o salario do funcionário: ");
        Salario = Double.Parse(Console.ReadLine());
        if (Salario <= 1000)
            INSS = Salario * 0.08;
        else
            if (Salario <= 1800)
                INSS = Salario * 0.10;
            else
                INSS = Salario * 0.12;
        Console.WriteLine($"Valor a ser descontado de INSS = R$ {INSS:0:00}");
    }
}
