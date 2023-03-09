using System;

class Pessoa {
    public string Nome;
    public string Endereco;
    public string Telefone;

    public string primeiroNome() {
        return Nome.Split(' ')[0];
    }
}

class MainClass {
    static void Main() {
        Pessoa p = new Pessoa();
        p.Nome = "João da Silva";
        p.Endereco = "Rua 1, número 123";
        p.Telefone = "11 9999-9999";

        Console.WriteLine("Nome completo: " + p.Nome);
        Console.WriteLine("Primeiro nome: " + p.primeiroNome());
        Console.WriteLine("Endereço: " + p.Endereco);
        Console.WriteLine("Telefone: " + p.Telefone);
    }
}