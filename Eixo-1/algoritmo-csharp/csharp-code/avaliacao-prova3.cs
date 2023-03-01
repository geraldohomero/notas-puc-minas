using System;
class Pessoa {

    private string _Nome;

    public string Nome

    {

        get { return _Nome; }
        set { _Nome = value; }

    }


    private double _Salário;

 

    public double Salário

    {

        get { return _Salário; }
        set { _Salário = value; }

    }

}

class TestPerson
{
    static void Main()
    {
Pessoa xPes = new Pessoa();

 

xPes.Nome = "Gustavo Campos Nascimento";

xPes.Salário = 4567.89;

 

Console.WriteLine($"{xPes.Nome}");

Console.WriteLine($"Salário: R${xPes.Salário}");
  }

}