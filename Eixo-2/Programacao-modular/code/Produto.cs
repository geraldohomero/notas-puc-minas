class Produto 
{
  public string descricao;
  public float preco;
  public int quantidade;

  public bool emEstoque() 
  {
    return (quantidade > 0);
  }
}