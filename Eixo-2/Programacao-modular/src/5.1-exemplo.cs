using System;

class Instancia 
{
  public static int id;
  public string tipoInstancia;

  public Instancia(String tipoRequerido) 
  {
    id = id + 1;
    tipoInstancia = tipoRequerido;
  }
}

class MainClass {
  public static void Main (string[] args) {
    Instancia[] instancias = new Instancia[2];
    instancias[0] = new Instancia("Prod");
    instancias[1] = new Instancia("Obj");
    for (int i = 0; i < 2; i++)
      Console.WriteLine ("Tipo: {0}, Id: {1}", instancias[i].tipoInstancia, Instancia.id);
  }
}