# C# primeiros passos: Lógica de Programação e Algoritmos

## Visão geral sobre o curso

- Panorama sobre a formação como programador;
  - Association for Computing Machinery
    - Básico / Fundamentos:
      - Lógica de Programação;
      - Programação Orientada a Objetos;
      - Estruturas de Dados;
      - Técnicas de algoritmos;
      - Fundamentos de Banco de dados.
    - Profissional / Comercial:
      - Engenharia e Projeto de Software:
        - Análise e Projeto de Software;
        - Qualidade e validação de software;
        - Processo de Desenvolvimento de Software.
      - Backend
        - Camada de domínio;
        - Aceso a Dados;
        - Webservices REST;
        - Ferramentas.
      - Frontend
        - Web: HTML + CSS + JavaScript;
        - App para dispositivos Móveis;
        - Ferramentas.
- Conteúdo do curso;
  - Introdução / conceitos;
    - Capítulo 1: Apresentação
    - Capítulo 2: Introdução / Conceitos:
      - Algoritmo / Programa de COmputador / Linguagem de Progrmação / IDE / Compilador & Inerpretador / Máquina Virtual / Código fonte / Bytecode / Modelos de execução de programas;
      - Microsoft Visual Studio.
  - Estrutura sequencial;
    - Capítulo 3: Estrutura sequencial:
      - Expressões aritméticas + - / * %
      - Variáveis e tipos básicos em C#
      - Entrada de dados / Processamento de dados / Saída de dados
      - Funções matemáticas
      - Microsoft Visual Studio - edição e depuração
      - Exercícios:
        - 5 resolvidos;
        - 20 propostos;
        - Total: 25 exercícios.
  - Estrutura condicional;
    - Capítulo 4: Estrutura condicional
      - Expressões comparativas  >  <  >=  <=  ==  !=
      - Expressões lógicas &&  ||  !
      - Estrutura condicional simples
      - Estrutura condicional composta
      - Encadeamento de estruturas condicionais
      - Exercícios
        - 3 resolvidos
        - 22 propostos
        - Total: 25 exercícios
  - Estruturas repetitivas;
    - Capítulo 5: Estruturas repetitivas
      - Estrutura repetitiva enquanto
      - Estrutura repetitiva para
      - Estrutura repetitiva faça-enquanto
      - Testes de mesa manuais
      - Exercícios
        - 12 testes de mesa
        - 4 resolvidos
        - 39 propostos
        - Total: 43 exercícios
  - Vetores;
    - Teoria
    - Declaração
    - Instanciação
    - Acesso
    - Testes de mesa manuais
    - Exercícios
      - 6 testes de mesa
      - 2 resolvidos
      - 9 propostos
      - Total: 11 exercícios
  - Matrizes.
    - Teoria
    - Declaração
    - Instanciação
    - Acesso
    - Testes de mesa manuais
    - Exercícios
      - 6 testes de mesa
      - 2 resolvidos
      - 7 propostos
      - Total: 9 exercícios
  - Exercícios na plataforma URI Online Judge (estilo Maratona de Programação)
    - Descrição inicial
    - Descrição dos dados de entrada
    - Descrição dos dados de saída
    - Exemplo(s); Entrada / saída
- Pré-requisitos para fazer o curso;
- A quem se destina este curso;
  - Iniciantes que desejam aprender a programar usando C# como linguagem
  - Interessados em cursar ou revisar a disciplina de Lógica de Programação
  - Interessados em desenvolver aplicativos e games, mas que precisam dos fundamentos iniciais de programação
- Apresentação do professor;
  - Professor Dr. Nelio Alves
  - Bacharel em Ciência da Computação
  - Mestrado e doutorado em Engenharia de Software
  - Professor universitário desde 2001

## Aula 12 - Primeiro programa C# no VSC

No terminal, navegue até a pasta onde vai armazenar os seus projetos.

Em seguida crie a pasta do projeto com o comando abaixo:

```shell
mkdir PrimeiroProjeto
```

Acesse a pasta e crie o projeto com o comando abaixo:

```shell
dotnet new console
```

Pronto, o seu projeto está criado!

```c#
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
```



## Aula 15 - saída de dados

``` c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      double x = 10.35784;
      int y = 32;
      string z = "Maria";
      char w = 'F';

      Console.Write("Olá mundo!");
      Console.WriteLine("Bom dia!");
      Console.WriteLine("Até mais.");
      Console.WriteLine();
      Console.WriteLine(x);
      Console.WriteLine(x.ToString("F2"));
      Console.WriteLine(x.ToString("F4"));
      Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));
      Console.WriteLine();
      Console.WriteLine("RESULTADO = " + x);
      Console.WriteLine("O valor do troco é " + x + " reais");
      Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais");
      Console.WriteLine();
      Console.WriteLine("A paciente " + z + " tem " + y + " anos e seu sexo é: " + w);
      Console.ReadLine();
    }
  }
}
```

## Aula 16 - Processamento de dados

- Exemplo 1

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
      int x, y;

      x = 5;

      y = 2 * x;

      Console.WriteLine(x);
      Console.WriteLine(y);
      
      Console.ReadLine();
    }
  }
}
```

- Exemplo 2

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
      int x;
      double y;

      x = 5;

      y = 2 * x;

      Console.WriteLine(x);
      Console.WriteLine(y);

      Console.ReadLine();
    }
  }
}
```

- Exemplo 3 - Calcular a área de um trapézio

```c#
namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
      double b, B, h, area;

      b = 6.0;
      B = 8.0;
      h = 5.0;

      area = ((B + b) / 2.0) * h;

      Console.WriteLine(area);

      Console.ReadLine();
    }
  }
}
```

- Exemplo 4

  Casting - é a conversão explícita de uim tipo para outro. É necessário quando o compilador não é capaz de "adivinhar" que o resultado de uma expressão deve ser de outro tipo.

```c#
namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
      int a, b;
      double resultado;

      a = 5;
      b = 2;

      resultado = (double) a / b;

      Console.WriteLine(resultado);

      Console.ReadLine();
    }
  }
}
```

- Exemplo 5

```c#
namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
      double a;
      int b;

      a = 5.0;
      b = (int) a;

      Console.WriteLine(b);

      Console.ReadLine();
    }
  }
}
```

## Aula 17 - Entrada de dados

- cd ..Comando para leitura de entrada de dados
- Lê da entrada padrão até a quebra de linha
- Retorna os dados lidos na forma de string

```c#
Console.ReadLine();
```

```c#
namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
      string frase, x, y, z, a, b, c;

      Console.Clear();
      Console.Write("Digite uma frase: ");
      frase = Console.ReadLine();
      Console.Write("Digite uma cor: ");
      x = Console.ReadLine();
      Console.Write("Digite uma cor em inglês: ");
      y = Console.ReadLine();
      Console.Write("Digite outra cor em inglês: ");
      z = Console.ReadLine();
      Console.Write("Digite 3 cores: ");
      string[] v = Console.ReadLine().Split(' ');
      a = v[0];
      b = v[1];
      c = v[2];

      Console.Clear();

      Console.WriteLine("Você digitou: " + frase);
      Console.WriteLine("Cor digitada: " + x);
      Console.WriteLine("Cor em inglês: " + y);
      Console.WriteLine("2a cor em inglês: " + z);
      Console.WriteLine("Cores: " + a + ", " + b + ", " + c);

      Console.ReadLine();
    }
  }
}
```

## Aula 18 - Entrada de dados em C# - Parte 2

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
      int n1;
      char ch;
      double n2;
      string nome;
      char sexo;
      int idade;
      double altura;
      

      Console.Clear();
      Console.Write("Digite um número inteiro: ");
      n1 = int.Parse(Console.ReadLine());
      Console.Write("Digite o sexo [F][M]: ");
      ch = char.Parse(Console.ReadLine());
      Console.Write("Digite um número double: ");
      n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.Write("Digite o nome, sexo, idade e altura: ");
      string[] vet = Console.ReadLine().Split(' ');
      nome = vet[0];
      sexo = char.Parse(vet[1]);
      idade = int.Parse(vet[2]);
      altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

      Console.Clear();

      Console.WriteLine("Você digitou");
      Console.WriteLine("Número inteiro: " + n1);
      Console.WriteLine("Sexo: " + ch);
      Console.WriteLine("Número double: " + n2.ToString("F2", CultureInfo.InvariantCulture) + "\n");
      Console.WriteLine("Nome: " + nome);
      Console.WriteLine("Sexo: " + sexo);
      Console.WriteLine("Idade: " + idade);
      Console.WriteLine("Altura: " + altura.ToString(CultureInfo.InvariantCulture));

      Console.ReadLine();
    }
  }
}
```

Exercício de fixação:

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
      string nomeCompleto;
      int qtdeDeQuartos;
      double precoProduto;
      string ultimoNome;
      int idade;
      double altura;
      

      Console.Clear();
      Console.Write("Entre com seu nome completo: ");
      nomeCompleto = Console.ReadLine();
      Console.Write("Quantos quartos tem na sua casa? ");
      qtdeDeQuartos = int.Parse(Console.ReadLine());

      Console.Write("Entre com o preço de um produto: ");
      precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.Write("Entre seu último nome, idade e altura (mesma linha): ");
      string[] vet = Console.ReadLine().Split(' ');
      ultimoNome = vet[0];
      idade = int.Parse(vet[1]);
      altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

      Console.Clear();

      Console.WriteLine("Você digitou");
      Console.WriteLine("Nome completo: " + nomeCompleto);
      Console.WriteLine("Quantidade de quartos: " + qtdeDeQuartos);
      Console.WriteLine("Preço produto R$" + precoProduto.ToString("F2", CultureInfo.InvariantCulture) + "\n");
      Console.WriteLine("Último nome: " + ultimoNome);
      Console.WriteLine("Idade: " + idade);
      Console.WriteLine("Altura: " + altura.ToString(CultureInfo.InvariantCulture));

      Console.ReadLine();
    }
  }
}
```

## 19 - Funções matemáticas em C#

Variável A recebe a raiz quadrada de x:

```c#
A = Math.Sqrt(x);
```

Variável A recebe o resultado de x elevado a y:

```c#
A = Math.Pow(x, y);
```

Variável A recebe o valor absoluto de x:

```c#
A = Math.Abs(x);
```

Exemplo:

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
      double x = 3.0;
      double y = 4.0;
      double z = -5.0;
      double A, B, C;

      Console.Clear();

      A = Math.Sqrt(x);
      B = Math.Sqrt(y);
      C = Math.Sqrt(25.0);
      Console.WriteLine("Raiz quadrada de " + x + " = " + A);
      Console.WriteLine("Raiz quadrada de " + y + " = " + B);
      Console.WriteLine("Raiz quadrada de 25 = " + C);

      A = Math.Pow(x, y);
      B = Math.Pow(x, 2.0);
      C = Math.Pow(5.0, 2.0);
      Console.WriteLine(x + " elevado a " + y + " = " + A);
      Console.WriteLine(x + " elevado ao quadrado  = " + B);
      Console.WriteLine("5 elevado ao quadrado = " + C);

      A = Math.Abs(y);
      B = Math.Abs(z);
      Console.WriteLine("Valor absoluto de " + y + " = " + A);
      Console.WriteLine("Valor absoluto de " + z + " = " + B);

      Console.ReadLine();
    }
  }
}
```

Saída no terminal:

``` shell
Raiz quadrada de 3 = 1,7320508075688772
Raiz quadrada de 4 = 2
Raiz quadrada de 25 = 5
3 elevado a 4 = 81
3 elevado ao quadrado  = 9
5 elevado ao quadrado = 25
Valor absoluto de 4 = 4
Valor absoluto de -5 = 5
```

## 20 - Exercício resolvido 01

Fazer um programa para ler as medidas da largura e comprimento de um terreno retangular com uma casa decimal, bem como o valor do metro quadrado do terreno com duas casas decimais. em seguida, o programa deve mostrar o valor da ãrea do terreno, bem como o valor do preço do terreno, ambos com duas casas decimais, conforme o exemplo.

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
      double largura, comprimento, valorMetroQuadrado, area, preco;

      //entrada de dados
      Console.Clear();
      Console.WriteLine("------------------------------");
      Console.WriteLine("            TERRENO");
      Console.WriteLine("------------------------------");
      Console.Write("Digite a largura do terreno: ");
      largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.Write("Digite o comprimento do terreno: ");
      comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.Write("Digite o valor do metro quadrado: ");
      valorMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      //processamento de dados
      area = largura * comprimento;
      preco = valorMetroQuadrado * area;

      //saída de dados
      Console.Clear();
      Console.WriteLine("------------------------------");
      Console.WriteLine("            TERRENO");
      Console.WriteLine("------------------------------");
      Console.Write("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture) + "\n");
      Console.Write("PRECO = " + preco.ToString("F2", CultureInfo.InvariantCulture) + "\n");
      Console.WriteLine("------------------------------");

      Console.ReadLine();
    }
  }
}
```

## 21 - Como utilizar o Debug no Visual Studio

## 22 - Nosso primeiro exercício do URI Online Judge

Exercício 1001

```c#
using System;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
      int A, B, X;

      A = int.Parse(Console.ReadLine());
      B = int.Parse(Console.ReadLine());

      X = A + B;

      Console.WriteLine("X = " + X);

      Console.ReadLine();
    }
  }
}
```

## 23 - Exercícios propostos PARTE 1

[__Links__](https://github.com/acenelio/curso-logica-de-programacao-csharp) dos códigos dos exercícios.

Exercício 1002

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
      double raio, A, n = 3.14159;

      raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      A = (Math.Pow(raio, 2.0) * n);

      Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));

      Console.ReadLine();
    }
  }
}
```

Exercício 1003

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
      int A, B, SOMA;

      A = int.Parse(Console.ReadLine());
      B = int.Parse(Console.ReadLine());

      SOMA = A + B;

      Console.WriteLine("SOMA = " + SOMA);

      Console.ReadLine();
    }
  }
}
```

Exercício 1004

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
      int A, B, PROD;

      A = int.Parse(Console.ReadLine());
      B = int.Parse(Console.ReadLine());

      PROD = A * B;

      Console.WriteLine("PROD = " + PROD);

      Console.ReadLine();
    }
  }
}
```

Exercício 1005

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
      double A, B, media;

      A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      media = (((A * 3.5) + (B * 7.5)) / 11);

      Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));

      Console.ReadLine();
    }
  }
}
```

Exercício 1006

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
      double A, B, C, media;

      A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      media = (((A * 2) + (B * 3) + (C * 5)) / 10);

      Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));

      Console.ReadLine();
    }
  }
}
```

Exercício 1007

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
      double A, B, C, D, diferenca;

      Console.Clear();

      A = int.Parse(Console.ReadLine());
      B = int.Parse(Console.ReadLine());
      C = int.Parse(Console.ReadLine());
      D = int.Parse(Console.ReadLine());

      diferenca = (A * B - C * D);

      Console.WriteLine("DIFERENCA = " + diferenca);

      Console.ReadLine();
    }
  }
}
```

Exercício 1008

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
      int numeroDoFuncionario, horasTrabalhadas;
      double valorDaHoraDeTrabalho, salario;

      Console.Clear();

      numeroDoFuncionario = int.Parse(Console.ReadLine());
      horasTrabalhadas = int.Parse(Console.ReadLine());
      valorDaHoraDeTrabalho = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      salario = horasTrabalhadas * valorDaHoraDeTrabalho;

      Console.WriteLine("NUMBER = " + numeroDoFuncionario);
      Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
      

      Console.ReadLine();
    }
  }
}
```

Exercício 1010

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
      Console.Clear();
      Console.WriteLine("Exercício 1010");
      Console.WriteLine("Código/Quantidade/Valor");

      string[] peca1 = Console.ReadLine().Split(' ');
      string[] peca2 = Console.ReadLine().Split(' ');

      int numeroDePecas1, numeroDePecas2;
      double valorPeca1, valorPeca2, valorAPagar;

      numeroDePecas1 = int.Parse(peca1[1]);
      valorPeca1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);

      numeroDePecas2 = int.Parse(peca2[1]);
      valorPeca2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);

      valorAPagar = ((valorPeca1 * numeroDePecas1) + (valorPeca2 * numeroDePecas2));

      Console.WriteLine("VALOR A PAGAR: R$ " + valorAPagar.ToString("F2", CultureInfo.InvariantCulture));

      Console.ReadLine();
    }
  }
}
```

Exercício 1014 __PAREI__

```c#
```

Exercício 1016

```c#
```

Exercício 1017

```c#

```
