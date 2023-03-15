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

## Construtores

As linguagens que possuem coletores de lixo, como o C#, quando inicializam um objeto, os atributos são inicializados com `0`, no caso de atributos numéricos, ou null, no caso de atributos que são referências para objetos.

Por exemplo, o comando:

- `Produto produto = new Produto();` 
 

Irá produzir um produto com os seguintes valores:
```csharp 
Descrição: null
Preço: 0.0
Quantidade: 0
```

Um construtor é um método especial em uma classe de `POO` que é responsável por inicializar os objetos da classe. Quando um objeto é criado a partir de uma classe, o construtor da classe é invocado automaticamente pelo sistema para inicializar as variáveis da classe e definir seu estado inicial.

O construtor é um `método com um nome igual ao nome da classe`, não possui nenhum tipo de retorno e `pode receber ou não parâmetros`. Ele é chamado automaticamente sempre que um novo objeto é criado, usando a palavra-chave `new`, como em: `Produto produto = new Produto();`.

Existem dois tipos de construtores em uma classe:

- Construtores padrão (`default`): São construtores que não recebem nenhum parâmetro. Eles geralmente inicializam as variáveis da classe com valores padrão ou vazios.

- Construtores personalizados: São construtores que recebem um ou mais parâmetros e são usados para inicializar as variáveis da classe com os valores passados como argumentos. Eles podem ser usados para inicializar as variáveis com valores diferentes ou para definir um estado inicial personalizado para o objeto.

O uso de construtores é uma parte importante da programação orientada a objetos, pois ajuda a garantir que os objetos sejam inicializados corretamente e que tenham um estado inicial consistente.

>>Se a classe não possui nenhum construtor, o C# fornece um construtor `default` (construtor padrão sem parâmetros), que inicializa os atributos do objeto com 0 ou null. A partir do momento que um desenvolvedor adiciona um construtor à classe, o C# não mais fornece o construtor vazio, e passa a respeitar a forma de inicialização implementada pelo desenvolvedor. 


- Criando construtores para nossa classe `Produto`

```csharp
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
```

A aplicação agora pode construir um objeto da classe produto de duas maneiras diferentes, conforme os códigos a seguir.

```csharp
Produto produto1 = new Produto();

Produto produto2 = new Produto("Leite", 3.59F, 12);
```