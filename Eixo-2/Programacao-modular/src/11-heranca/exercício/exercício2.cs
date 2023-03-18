using System;

public class Pessoa
{
    private string nome;
    private string endereco;
    private string telefone;

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public string Endereco
    {
        get { return endereco; }
        set { endereco = value; }
    }

    public string Telefone
    {
        get { return telefone; }
        set { telefone = value; }
    }
}

public class PessoaFisica : Pessoa
{
    private string cpf;

    public string Cpf
    {
        get { return cpf; }
        set { cpf = value; }
    }
}

public class PessoaJuridica : Pessoa
{
    private string cnpj;

    public string Cnpj
    {
        get { return cnpj; }
        set { cnpj = value; }
    }
}

public class MainClass
{
    public static void Main()
    {
        PessoaFisica pf = new PessoaFisica();
        pf.Nome = "João da Silva";
        pf.Endereco = "Rua das Flores, 123";
        pf.Telefone = "11 98765-4321";
        pf.Cpf = "123.456.789-10";

        Console.WriteLine("Pessoa física:");
        Console.WriteLine("Nome: {0}", pf.Nome);
        Console.WriteLine("Endereço: {0}", pf.Endereco);
        Console.WriteLine("Telefone: {0}", pf.Telefone);
        Console.WriteLine("CPF: {0}", pf.Cpf);

        PessoaJuridica pj = new PessoaJuridica();
        pj.Nome = "Empresa XYZ Ltda.";
        pj.Endereco = "Av. das Árvores, 456";
        pj.Telefone = "11 12345-6789";
        pj.Cnpj = "12.345.678/0001-90";

        Console.WriteLine("Pessoa jurídica:");
        Console.WriteLine("Nome: {0}", pj.Nome);
        Console.WriteLine("Endereço: {0}", pj.Endereco);
        Console.WriteLine("Telefone: {0}", pj.Telefone);
        Console.WriteLine("CNPJ: {0}", pj.Cnpj);
    }
}
