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

## Atributos estáticos e propriedades

### Membro estático

O `escopo` de uma variável descreve a região do código em que aquela variável pode ser acessada. O termo escopo é também comumente chamado como visibilidade da variável, pois compreende a parte do código em que uma variável é “reconhecida” pelo programa.

Um membro estático é definido como um membro com `tempo de vida global, e escopo local`. São atributos ou métodos que são comuns a todos os objetos de uma classe. Quando declaramos um atributo ou método estático, ele passa a ser um membro de classe, e é compartilhado por todos os objetos daquela classe.

>Suponha que desejamos adicionar um novo atributo à classe Produto, que consiste em um código que é incrementado a cada vez que uma nova instância de Produto é criada. Iremos utilizar atributos estáticos para resolver este problema.

```csharp
class Produto 
{
  public int id;
  public string descricao;
  public float preco;
  public int quantidade;

  public static int contador;

  public Produto(String descricao, float preco, int quantidade) 
  {
    this.id = ++Produto.contador;

    if (descricao.Length >= 3)
      this.descricao = descricao;
    if (preco > 0)
      this.preco = preco;
    if (quantidade >= 0)
      this.quantidade = quantidade;
  }

  public Produto() 
  {
    this.id = ++Produto.contador;
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
Como um atributo estático pertence ao escopo da classe, sempre que quisermos acessá-lo devemos referenciá-lo a partir da classe:

```csharp 
Console.WriteLine("Contador de produtos: {0}", Produto.contador);
```

[Exemplo](./code/5-contadorStatic.cs)

### Destrutores
```csharp
using System;
using System.Threading;

class Produto 
{
  public int id;
  public string descricao;
  public float preco;
  public int quantidade;

  public static int contador = 0;
  public static int instancias = 0;

  public Produto(String descricao, float preco, int quantidade) 
  {
    Produto.instancias++;
    this.id = ++Produto.contador;

    if (descricao.Length >= 3)
      this.descricao = descricao;
    if (preco > 0)
      this.preco = preco;
    if (quantidade >= 0)
      this.quantidade = quantidade;
  }

  public Produto() 
  {
    Produto.instancias++;
    this.id = ++Produto.contador;
    this.descricao = "Novo Produto";
    this.preco = 0.01F;
    this.quantidade = 0;
  }

  ~Produto() 
  {
      Console.WriteLine("Executando o destrutor...");
      Produto.instancias--;
  }

  public bool emEstoque() 
  {
    return (quantidade > 0);
  }
}

class MainClass 
{

  public static void Main (string[] args) 
  {
    Console.WriteLine ("-\nInstancias produtos: {0}", Produto.instancias);
    Console.WriteLine ("Contador de produtos: {0}\n-", Produto.contador);

    Produto produto1 = new Produto();
    Console.WriteLine ("Construído o Produto {0}: construtor default", produto1.id);

    Console.WriteLine ("-\nInstancias produtos: {0}", Produto.instancias);
    Console.WriteLine ("Contador de produtos: {0}\n-", Produto.contador);

    Produto produto2 = new Produto("Leite", 3.59F, 12);
    Console.WriteLine ("Construindo o Produto {0}: construtor com parâmetros", produto2.id);

    Console.WriteLine ("-\nInstancias produtos: {0}", Produto.instancias);
    Console.WriteLine ("Contador de produtos: {0}\n-", Produto.contador);

    produto1 = null;
    Console.WriteLine("Referência para Produto 1 recebe valor null");
    
    Console.WriteLine ("-\nInstancias produtos: {0}", Produto.instancias);
    Console.WriteLine ("Contador de produtos: {0}\n-", Produto.contador);

    GC.Collect();
    GC.WaitForPendingFinalizers();

    Console.WriteLine ("-\nInstancias produtos: {0}", Produto.instancias);
    Console.WriteLine ("Contador de produtos: {0}\n-", Produto.contador);


  }
}
```
## Princípio da ocultação da informação

Encapsulamento e o princípio da caixa preta: Um módulo deve consistir de um conjunto de comandos com uma função bem definida, e o mais independente possível em relação ao resto do sistema.

`Independência funcional`: Cada módulo deve cuidar de uma função específica, servindo a um propósitto específico. 

`Coesão`: Atributo de um módulo em que todas as suas partes estão ligadas umas às outras. Em software, todas as partes estão coerentemente relacionadas. O objetivo de um módulo em programação modular é obter alta coesão interna.

`Acoplamento`: Medida da interconexão entre os elementos de software. A dependência pode ser medida pela quantidade de conexões entre os módulos de um sistema. A situação ideal é que um sistema possua baixo acoplamento.

`Sistema modular bem implementado = alta coesão interna e baixo acoplamento`

Indicadores de baixo acoplamento

- Tamanho: quantidade de parâmetros e métodos públicos.
- Visibilidade: uso de parâmetros x uso de variáveis globais.
- Flexibilidade: facilidade na chamada

 
### Modificadores de acesso

Vários níveis de acesso podem ser atribuídos aos atributos e métodos de uma classe. Em C#, os três níveis mais comuns de acesso são: privado, protegido e público. Esses níveis são definidos a partir de modificadores de acesso, que são palavras-chave da linguagem que são adicionadas na declaração destes membros de classe.

`Privado` (modificador de acesso `private`)

>Membros declarados com acesso privado são acessíveis apenas na própria classe.

`Protegido` (modificador de acesso `protected`)

>Membros declarados com acesso protegido são acessíveis na própria classe e adicionalmente por suas subclasses (ou classes filha).

`Público` (modificador de acesso `public`)

>Membros declarados com acesso público são acessíveis de qualquer lugar do programa.


>>>>>>O `nível de acesso padrão` para membros da classe é privado quando nenhum modificador de acesso é especificado.


```csharp
class Produto 
{
  private int id;
  private string descricao;
  private float preco;
  private int quantidade;

  private static int contador = 0;
  private static int instancias = 0;

  public Produto(String descricao, float preco, int quantidade) 
  {…
  } 

  public Produto() 
  {…
  }

  ~Produto() 
  {…
  }

  public bool emEstoque() 
  {…
  }
}
```
[Exemplo completo](./code/7-produtoComEncapsulamento.cs)
### Regras de encapsulamento

- Use o nível de acesso mais restrito e que faça sentido para um membro particular.
>Na dúvida, coloque tudo no `private` e libere quando necessário
- Use private a menos que haja uma boa razão para não o fazer.
- Evite campos public exceto para `constantes`. Campos públicos aumentam o acoplamento em relação a uma implementação específica e reduz a flexibilidade do sistema a mudanças.

## Métodos de acesso

Métodos de acesso são criados para permitir que os usuários de uma classe possam acessar os valores dos atributos, sem expor os atributos à possíveis atribuições de valores inválidos. 

Esses métodos são chamados de **getters** e **setters**.

- Métodos **`get`**: acessam o valor de um atributo privado. Eventualmente, os valores podem ser tratados antes de serem exibidos.

Por exemplo: um atributo booleano pode ser exibido como V ou F, e um atributo numérico pode ser retornado no formato string correspondente.

- Métodos **`set`**: atribuem um valor a um atributo privado. Os valores passados como argumento devem ser validados/tratados antes de serem atribuídos.

Exemplo:

```csharp
private float preco;
```

Método de acesso:

```csharp
public float GetPreco()
{
  return preco;
}

public void SetPreco(float preco)
{
  if (preco > 0)
  {
    this.preco = preco;
  }
}
```

## Propriedades

As propriedades permitem a exposição pública de atributos, ao mesmo tempo em que permitem a implementação flexível e com menos linhas de código dos métodos de acesso.

As `propriedades` podem ter os seguintes métodos:

- **`init`**: atribui um valor inicial ao atributo no momento da criação do objeto.

- **`set`**: atribui um novo valor ao atributo enquanto verifica a validade do valor a ser atribuído.

- **`get`**: retorna o valor do atributo, diretamente, ou após processamento ou formatação.

```csharp
public float Preco { // propriedade com PascalCase
  get { return preco; }
  set { if (value > 0) preco = value; } // value representa o valor 
                                        // passado ao método de acesso set
}
```

As propriedades possuem métodos assessores padrão que não fazem nenhuma validação ou transformação de dados:

```csharp
public float Preco { get; set; }
```

retorna o valor de `preco` e inicializa o `preco` com o valor do argumento `value`, sem verificar se este valor é válido.

## Namespaces

Namespaces, ou espaço de nomes, é um recurso que permite agrupar classes relacionadas em uma unidade lógica maior, criando módulos mais complexos. Muitas vezes, os namespaces são utilizados para a criação de bibliotecas de código (code libraries).

Por convenção, quando se deseja **criar** seu próprio **namespace**, todas as **classes** de um mesmo namespace devem ser **armazenadas** na **mesma pasta**, em arquivos separados onde **cada arquivo** possui o mesmo **nome da classe** nele contido. O **nome da pasta** deve ser o mesmo **nome do namespace**.

![Namespaces](./img/namespaces.png)

E os outros módulos poderão utilizar outros namespaces com a cláusula `using`

## Partial Classes

Por padrão, uma classe deve ser implementada em um único arquivo em C# e na maioria das linguagens de programação modernas. Existe até um princípio de qualidade de código que sugere que uma classe não deve ter mais de aproximadamente 100 linhas, ou deve ser dividida em várias classes menores

A possibilidade de se criar uma classe parcial, ou partial class, em mais de um arquivo é uma funcionalidade interessante em C#. Com isso, é possível organizar melhor o conteúdo de classes que possuem um grande número de membros e métodos. Essa técnica é especialmente útil na criação de interfaces gráficas, onde há muitos códigos gerados automaticamente pelo compilador. No contexto de projetos do Windows Forms, por exemplo, as classes parciais permitem expor apenas as estruturas que precisam ser manipuladas pelos desenvolvedores, enquanto os códigos complexos gerados automaticamente são mantidos em outros arquivos para maior organização do projeto.


```csharp
public partial class ClasseParcial {
  
}
```

Pode ser desenvolvido em vários arquivos, como por exemplo:

ClasseParcial1.cs

ClasseParcial2.cs

>>Classes parciais tem de estar dentro de um mesmo namespace (que seria como o sobrenome da classe)

## Generalização e Especificação

-  A especificação é um processo *top-down* (de cima para baixo), em que uma classe mais específica é derivada de uma classe mais genérica.
-  A generalização ou abstração é um processo *bottom-up* (de baixo para cima), em que uma classe mais genérica é construída a partir dos elementos comuns de classes mais específicas.

Tomando como exemplo as propriedades básicas de um veículo, podemos definir subtipos mais específicos, tais como carros, caminhões e motocicletas. Dentre os atributos que um veículo pode possuir, destacam-se a cor, o modelo e o ano de fabricação.

Veículo é a classe genérica, enquanto carros, caminhões e motos são classes mais específicas que herdam ou se baseiam na classe veículo para obterem atributos e métodos comuns.

### Herança

Através da herança, é possível definir uma classe em termos de outra classe já existente, utilizando os processos de generalização e especificação. Essa relação é estabelecida através do mecanismo de subtipagem, onde o subtipo é mais específico que o supertipo e possui `todos os atributos do supertipo`, além de seus próprios atributos específicos. Ou seja, ela implementa a relação “é um tipo de”, ou “é um” (carro é um tipo de veículo, cachorro é um tipo de animal...)


A herança possibilita o reuso do comportamento de uma classe na definição de outra, permitindo a criação de novas classes mais específicas, conhecidas como subclasses, classes derivadas ou classes filhas, que herdam todas as características de sua classe base, também chamada de superclasse, classe pai ou classe genérica. As subclasses podem adicionar novas características à sua implementação.

Por exemplo, podemos dizer que um professor é uma pessoa, ou que um ônibus é um veículo, estabelecendo a relação de herança entre as classes. No entanto, a herança múltipla de classes é uma propriedade que não é permitida na linguagem C#, uma vez que pode causar diversos problemas na programação orientada a objetos.

>>Você deve favorecer composição sobre herança, ou seja, é melhor você atingir a reusabilidade de código a partir da composição do que pela herança.

```csharp
class Pessoa // classe base
{

}

class Professor : Pessoa  // classe Professor é um tipo de Pessoa
{

}

class Aluno : Pessoa  // classe Aluno é um tipo de Pessoa
{

}
```

## Construtores em classe filha

Uma das etapas para construir um objeto de uma classe filha é construir os elementos herdados da classe pai. Para garantir que o sistema seja robusto e correto, o método construtor da classe pai deve ser executado antes do construtor da classe filha.

Se a classe filha não definir um construtor próprio, o construtor padrão sem parâmetros da classe pai será executado automaticamente. No entanto, é possível declarar um construtor na classe filha que inicialize tanto os atributos da classe filha quanto os atributos herdados da classe pai.Os dois pontos (`:`) seguido da palavra-chave base e a lista de parâmetros invocam o construtor da classe pai. 