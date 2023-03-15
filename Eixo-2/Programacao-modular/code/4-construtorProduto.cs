class Produto 
{
  public string descricao;
  public float preco;
  public int quantidade;

  public Produto(String descricao, float preco, int quantidade) 
  {
    if (descricao.Length >= 3)
      this.descricao = descricao;
    if (preco > 0)
      this.preco = preco;
    if (quantidade >= 0)
      this.quantidade = quantidade;
  }

  public Produto() 
  {
    this.descricao = "Novo Produto";
    this.preco = 0.01F;
    this.quantidade = 0;
  }

  public bool emEstoque() 
  {
    return (quantidade > 0);
  }
}