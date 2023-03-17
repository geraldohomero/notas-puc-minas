using System;

public class Conta
{
    private static int proximoNumero = 1;

    private readonly int numero;
    private readonly DateTime criacao;
    private float saldo;

    public Conta()
    {
        numero = proximoNumero++;
        criacao = DateTime.Now;
        saldo = 0;
    }

    public int Numero
    {
        get { return numero; }
    }

    public DateTime Criacao
    {
        get { return criacao; }
    }

    public float Saldo
    {
        get { return saldo; }
    }

    public float Sacar(float value)
    {
        if (value <= 0)
        {
            throw new ArgumentException("O valor a ser sacado deve ser positivo.");
        }

        if (saldo < value)
        {
            throw new InvalidOperationException("Saldo insuficiente para sacar essa quantia.");
        }

        saldo -= value;

        return saldo;
    }

    public float Depositar(float value)
    {
        if (value <= 0)
        {
            throw new ArgumentException("O valor a ser depositado deve ser positivo.");
        }

        saldo += value;

        return saldo;
    }
}

public class MainClass
{
    public static void Main()
    {
        Conta conta1 = new Conta();
        Conta conta2 = new Conta();

        Console.WriteLine("Conta {0} criada em {1}", conta1.Numero, conta1.Criacao);
        Console.WriteLine("Conta {0} criada em {1}", conta2.Numero, conta2.Criacao);

        conta1.Depositar(100);
        Console.WriteLine("Saldo da conta {0}: {1}", conta1.Numero, conta1.Saldo);

        conta1.Sacar(50);
        Console.WriteLine("Saldo da conta {0}: {1}", conta1.Numero, conta1.Saldo);
    }
}
