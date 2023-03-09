# POO


### Objeto 

Um objeto possui:
- Estado
>Valores que são atribuídos aos seus atributos
- Comportamento
>Como podemos manipular o estado
- Identidade
>Referência, ou o local que o objeto encontra-se na memória

---
### Classe

Considere que desejamos implementar uma classe “Produto” que representa uma entidade Produto em um Sistema de Gerenciamento de Estoque. A classe Produto poderia ter os seguintes atributos:

- Descrição: do tipo texto
- Preço: do tipo real
- Quantidade: do tipo inteiro

A classe produto poderia ainda ter o seguinte método:

- emEstoque( ): do tipo lógico (retorna verdadeiro se a   quantidade em estoque é maior que 0).

```csharp
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
```
## Semântica de referência

Um objeto é uma instância de uma Classe, que possui um nome e uma posição na memória. Nesta posição de memória são armazenados os valores de seus atributos. Classes podem ter múltiplas instâncias de Objetos.

Em C# a declaração de um Objeto, na verdade, cria uma referência para o objeto, mas não o objeto propriamente dito. Uma referência armazena o endereço onde o objeto se encontra. Após declaramos uma referência, precisamos criar efetivamente o objeto.

A classe a seguir instancia um objeto do tipo Produto e inicializa os atributos do produto criado.

```csharp
class MainClass 
{

  public static void Main (string[] args) 
  {

    Produto produto = new Produto();

    produto.descricao = "Leite";
    produto.preco = 3.59F;
    produto.quantidade = 12;

    Console.WriteLine ("Produto:");
    Console.WriteLine ("  Atributos:");
    Console.WriteLine ("     Descrição: {0}", produto.descricao);
    Console.WriteLine ("         Preço: {0}", produto.preco);
    Console.WriteLine ("    Quantidade: {0}", produto.quantidade);
    Console.WriteLine ("  Métodos:");
    Console.WriteLine ("    Em estoque: {0}", (produto.emEstoque() ? "sim" : "não"));
  }
}
```

Em resumo:

`Produto produto`  - cria uma referência para Produto, mas não aloca a memória para armazenar o objeto. O valor inicial da variável produto é null

`produto = new Produto()`  
cria efetivamente o objeto do tipo Produto e retorna o endereço onde o objeto foi alocado. O endereço é armazenado na referência produto

`produto.descricao`  - acessa diretamente o atributo de produto

`produto.emEstoque()`  - executa o método de produto.