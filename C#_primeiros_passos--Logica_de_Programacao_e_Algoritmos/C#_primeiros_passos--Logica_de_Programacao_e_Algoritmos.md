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

## Instalar .NET 6.0

```shell
wget https://packages.microsoft.com/config/debian/11/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
wget https://packages.microsoft.com/config/debian/11/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
rm packages-microsoft-prod.deb
```

```shell
sudo apt-get update &&   sudo apt-get install -y dotnet-sdk-6.0
```

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

## Aula 19 - Funções matemáticas em C#

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

## Aula 20 - Exercício resolvido 01

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

## Aula 21 - Como utilizar o Debug no Visual Studio

## Aula 22 - Nosso primeiro exercício do URI Online Judge

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

## Aula 23 - Exercícios propostos PARTE 1

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

Exercício 1014

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
      Console.Clear();
      Console.WriteLine("Exercício 1014");
      Console.WriteLine("km/Litros");

      int X;
      double Y, consumo;

      X = int.Parse(Console.ReadLine());
      Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      consumo = X / Y;

      Console.WriteLine(consumo.ToString("F3", CultureInfo.InvariantCulture) + " km/l");

      Console.ReadLine();
    }
  }
};
```

Exercício 1016

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
      Console.Clear();
      Console.WriteLine("Exercício 1016");
      Console.WriteLine("km");

      int distancia, tempo;

      distancia = int.Parse(Console.ReadLine());

      tempo = distancia * 2;

      Console.WriteLine(tempo + " minutos");

      Console.ReadLine();
    }
  }
};
```

Exercício 1017

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
      Console.Clear();
      Console.WriteLine("Exercício 1017");
      Console.WriteLine("Tempo/Velocidade");

      int tempo, velocidadeMedia, distancia;
      double litros;

      tempo = int.Parse(Console.ReadLine());
      velocidadeMedia = int.Parse(Console.ReadLine());

      distancia = velocidadeMedia * tempo;

      litros = (double) distancia / 12;

      Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));

      
      Console.ReadLine();
    }
  }
};
```

## Aula 24 - Exercício resolvido 02

Fazer um programa para ler as medidas da base e altura de um retângulo. em seguida, mostrar o valor da área, perímetro e diagonal deste retângulo, com quatro casa decimais.

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
      Console.Clear();
      Console.WriteLine("------------------------------");
      Console.WriteLine("          Retângulo");
      Console.WriteLine("------------------------------");

      double _base, altura, area, perimetro, diagonal;

      Console.Write("Digite a base: ");
      _base = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.Write("Digite a altura: ");
      altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      area = _base * altura;
      perimetro = 2 * (_base + altura);
      diagonal = Math.Sqrt(Math.Pow(_base, 2) + Math.Pow(altura, 2));

      Console.WriteLine("------------------------------");
      Console.WriteLine("AREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
      Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
      Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));
      Console.WriteLine("------------------------------");
      
      Console.ReadLine();
    }
  }
};
```

## Aula 25 - Exercício resolvido 03

Faazer um programa para ler o nome (apenas uma palavra) e idade de duas pessoas. Ao final mostrar uma mensagem com os nomes e a idade média entre essas pessoas, com uma casa decimal.

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
      Console.Clear();
      Console.WriteLine("------------------------------");
      Console.WriteLine("          IdadeMédia");
      Console.WriteLine("------------------------------");

      string nomeA, nomeB;
      int idadeA, idadeB;
      double idadeMedia;
      string[] vet;

      Console.Write("Digite o nome e idade: ");
      vet = Console.ReadLine().Split(' ');
      nomeA = vet[0];
      idadeA = int.Parse(vet[1]);
      
      Console.Write("Digite o nome e idade: ");
      vet = Console.ReadLine().Split(' ');
      nomeB = vet[0];
      idadeB = int.Parse(vet[1]);

      idadeMedia = (double) (idadeA + idadeB) / 2.0;

      Console.WriteLine("------------------------------");
      Console.WriteLine("A idade média de " + nomeA + " e " + nomeB + " é de " + idadeMedia.ToString("F1", CultureInfo.InvariantCulture) + " anos");
      Console.WriteLine("------------------------------");
      
      Console.ReadLine();
    }
  }
};
```

## Aula 26 - Exercícios propostos - PARTE 2

- ### Exercício 1009 - string

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
      Console.Clear();
      Console.WriteLine("Exercício 1009");
      Console.WriteLine("Salário com bônus");
      Console.WriteLine("NOME/SALARIO/VENDAS");

      string nomeVendedor;
      double salarioFixo, totalDeVendas, comissao, totalAReceber;

      nomeVendedor = Console.ReadLine();
      salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      totalDeVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      comissao = totalDeVendas * 0.15;
      totalAReceber = salarioFixo + comissao;

      Console.WriteLine("TOTAL = R$ " + totalAReceber.ToString("F2", CultureInfo.InvariantCulture));
      
      Console.ReadLine();
    }
  }
};
```

- ### Exercício 1011 - casting

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
      Console.Clear();
      Console.WriteLine("Exercício 1011");
      Console.WriteLine("Esfera");
      Console.WriteLine("RAIO");

      double raio, volume;
      const double Pi = 3.14159;

      raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      volume = (4.0/3) * Pi * Math.Pow(raio, 3);

      Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));
      
      Console.ReadLine();
    }
  }
};
```

- ### Exercício 1012 - geometria

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
      Console.Clear();
      Console.WriteLine("Exercício 1012");
      Console.WriteLine("Área");
      Console.WriteLine("A/B/C");

      double A, B, C;
      const double Pi = 3.14159;
      double areaTrianguloRetangulo, areaCirculo, areaTrapezio, areaQuadrado, areaRetangulo;
      string[] vet;

      vet = Console.ReadLine().Split(' ');
      A = double.Parse(vet[0], CultureInfo.InvariantCulture);
      B = double.Parse(vet[1], CultureInfo.InvariantCulture);
      C = double.Parse(vet[2], CultureInfo.InvariantCulture);

      areaTrianguloRetangulo = (A * C) / 2;
      areaCirculo = Pi * Math.Pow(C, 2);
      areaTrapezio = ((A + B) * C) / 2;
      areaQuadrado = Math.Pow(B, 2);
      areaRetangulo = A * B;

      Console.WriteLine("TRIANGULO: " + areaTrianguloRetangulo.ToString("F3", CultureInfo.InvariantCulture));
      Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
      Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
      Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
      Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));
      
      Console.ReadLine();
    }
  }
};
```

- ### Exercício 1013 - abs

```c#
using System;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
      Console.Clear();
      Console.WriteLine("Exercício 1013");
      Console.WriteLine("O Maior");
      Console.WriteLine("A/B/C");

      int A, B, C, maiorAB, maiorABC;
      string[] vet;

      vet = Console.ReadLine().Split(' ');
      A = int.Parse(vet[0]);
      B = int.Parse(vet[1]);
      C = int.Parse(vet[2]);
    
      maiorAB = ((A + B + Math.Abs(A - B)) / 2);
      maiorABC = ((C + maiorAB + Math.Abs(C - maiorAB)) / 2);
      
      Console.WriteLine(maiorABC + " eh o maior");
      
      Console.ReadLine();
    }
  }
};
```

- ### Exercício 1015 - sqrt, pow

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
      Console.Clear();
      Console.WriteLine("Exercício 1015");
      Console.WriteLine("Distância");
      Console.WriteLine("x1/y1/x2/y2");

      double x1, y1, x2, y2, distancia;
      string[] p1;
      string[] p2;

      p1 = Console.ReadLine().Split(' ');
      p2 = Console.ReadLine().Split(' ');

      x1 = double.Parse(p1[0], CultureInfo.InvariantCulture);
      y1 = double.Parse(p1[1], CultureInfo.InvariantCulture);
      x2 = double.Parse(p2[0], CultureInfo.InvariantCulture);
      y2 = double.Parse(p2[1], CultureInfo.InvariantCulture);

      distancia = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

      Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));

      Console.ReadLine();
    }
  }
};
```

## Aula 27 - Exercício resolvido 04

- ### Exercício 1019

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1019");
        Console.WriteLine("Conversão de Tempo");
        Console.WriteLine("Segundos");

        int tempoEmSegundos, horas, minutos, segundos, resto;

        tempoEmSegundos = int.Parse(Console.ReadLine());

        horas = tempoEmSegundos / 3600;
        resto = tempoEmSegundos % 3600;
        minutos = resto / 60;
        segundos = resto % 60;

        Console.WriteLine(horas + ":" + minutos + ":" + segundos);
        

      Console.ReadLine();
    }
  }
};
```

## Aula 28 - Exercícios propostos - PARTE 3

- ### Exercício 1018

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1018");
        Console.WriteLine("Cédulas");
        Console.WriteLine("Número inteiro");

        int numero, cedulaCem, cedulaCinquenta, cedulaVinte, cedulaDez, cedulaCinco, cedulaDois, cedulaUm;
        int restoDeCem, restoDeCinquenta, restoDeVinte, restoDeDez, restoDeCinco, restoDeDois, restoDeUm;

        numero = int.Parse(Console.ReadLine());
        cedulaCem = numero / 100;
        restoDeCem = numero % 100;
        cedulaCinquenta = restoDeCem / 50;
        restoDeCinquenta = restoDeCem % 50;
        cedulaVinte = restoDeCinquenta / 20;
        restoDeVinte = restoDeCinquenta % 20;
        cedulaDez = restoDeVinte / 10;
        restoDeDez = restoDeVinte % 10;
        cedulaCinco = restoDeDez / 5;
        restoDeCinco = restoDeDez % 5;
        cedulaDois = restoDeCinco / 2;
        restoDeDois = restoDeCinco % 2;
        cedulaUm = restoDeDois / 1;
        // restoDeUm = restoDeDois % 1;

        Console.WriteLine(numero);
        Console.WriteLine(cedulaCem + " nota(s) de R$ 100,00");
        // Console.WriteLine(restoDeCem);
        Console.WriteLine(cedulaCinquenta + " nota(s) de R$ 50,00");
        // Console.WriteLine(restoDeCinquenta);
        Console.WriteLine(cedulaVinte + " nota(s) de R$ 20,00");
        // Console.WriteLine(restoDeVinte);
        Console.WriteLine(cedulaDez + " nota(s) de R$ 10,00");
        // Console.WriteLine(restoDeDez);
        Console.WriteLine(cedulaCinco + " nota(s) de R$ 5,00");
        // Console.WriteLine(restoDeCinco);
        Console.WriteLine(cedulaDois + " nota(s) de R$ 2,00");
        // Console.WriteLine(restoDeDois);
        Console.WriteLine(cedulaUm + " nota(s) de R$ 1,00");
        // Console.WriteLine(restoDeUm);

      Console.ReadLine();
    }
  }
};
```

- ### Exercício 1020

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1020");
        Console.WriteLine("Idade em Dias");
        Console.WriteLine("Número inteiro");

        int quantidadeDeDias, anos, meses, dias, resto;

        quantidadeDeDias = int.Parse(Console.ReadLine());

        anos = quantidadeDeDias / 365;
        meses = (quantidadeDeDias % 365) / 30;
        dias = (quantidadeDeDias % 365) % 30;
        
        Console.WriteLine(anos + " ano(s)");
        Console.WriteLine(meses + " mes(es)");
        Console.WriteLine(dias + " dia(s)");

      Console.ReadLine();
    }
  }
};
```

- ### Exercício 1021

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1021");
        Console.WriteLine("Notas e Moedas");
        Console.WriteLine("Valor em real");

        double numero;
        int quociente, dividendo, divisor,resto;

        numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        dividendo = (int)(numero * 100.0 + 0.5);

        Console.WriteLine("NOTAS:");

        
        divisor = 100;
        quociente = (dividendo / (divisor * 100));
        resto = dividendo % (divisor * 100);
        Console.WriteLine(quociente + " nota(s) de R$ "+ divisor + ".00");

        divisor = 50;
        dividendo = resto;
        quociente = (dividendo / (divisor * 100));
        resto = dividendo % (divisor * 100);
        Console.WriteLine(quociente + " nota(s) de R$ "+ divisor + ".00");

        divisor = 20;
        dividendo = resto;
        quociente = (dividendo / (divisor * 100));
        resto = dividendo % (divisor * 100);
        Console.WriteLine(quociente + " nota(s) de R$ "+ divisor + ".00");

        divisor = 10;
        dividendo = resto;
        quociente = (dividendo / (divisor * 100));
        resto = dividendo % (divisor * 100);
        Console.WriteLine(quociente + " nota(s) de R$ "+ divisor + ".00");

        divisor = 5;
        dividendo = resto;
        quociente = (dividendo / (divisor * 100));
        resto = dividendo % (divisor * 100);
        Console.WriteLine(quociente + " nota(s) de R$ "+ divisor + ".00");

        divisor = 2;
        dividendo = resto;
        quociente = (dividendo / (divisor * 100));
        resto = dividendo % (divisor * 100);
        Console.WriteLine(quociente + " nota(s) de R$ "+ divisor + ".00");

        Console.WriteLine("MOEDAS:");

        divisor = 100;
        dividendo = resto;
        quociente = dividendo / divisor;
        resto = dividendo % divisor;
        Console.WriteLine(quociente + " moeda(s) de R$ 1.00");

        divisor = 50;
        dividendo = resto;
        quociente = dividendo / divisor;
        resto = dividendo % divisor;
        Console.WriteLine(quociente + " moeda(s) de R$ 0.50");

        divisor = 25;
        dividendo = resto;
        quociente = dividendo / divisor;
        resto = dividendo % divisor;
        Console.WriteLine(quociente + " moeda(s) de R$ 0.25");

        divisor = 10;
        dividendo = resto;
        quociente = dividendo / divisor;
        resto = dividendo % divisor;
        Console.WriteLine(quociente + " moeda(s) de R$ 0.10");

        divisor = 5;
        dividendo = resto;
        quociente = dividendo / divisor;
        resto = dividendo % divisor;
        Console.WriteLine(quociente + " moeda(s) de R$ 0.05");

        divisor = 1;
        dividendo = resto;
        quociente = dividendo / divisor;
        resto = dividendo % divisor;
        Console.WriteLine(quociente + " moeda(s) de R$ 0.01");

      Console.ReadLine();
    }
  }
};
```

- ### Exercício 1061

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1061");
        Console.WriteLine("Tempo de um Evento");
        Console.WriteLine("Dia e Hora Inicial");

        int diaInicial, horaInicial, minutoInicial, segundoInicial;
        int diaFinal, horaFinal, minutoFinal, segundoFinal;
        int tempoInicial, tempoFinal, duracaoEmSegundos;
        int dias, horas, minutos, segundos, resto;

        string[] v = Console.ReadLine().Split(' ');
        diaInicial = int.Parse(v[1]);

        string[] y = Console.ReadLine().Split(':');
        horaInicial = int.Parse(y[0]);
        minutoInicial = int.Parse(y[1]);
        segundoInicial = int.Parse(y[2]);
        
        string[] x = Console.ReadLine().Split(' ');
        diaFinal = int.Parse(x[1]);

        string[] z = Console.ReadLine().Split(':');
        horaFinal = int.Parse(z[0]);
        minutoFinal = int.Parse(z[1]);
        segundoFinal = int.Parse(z[2]);

        tempoInicial = (diaInicial * 86400) + (horaInicial * 3600) + (minutoInicial * 60) + segundoInicial;
        tempoFinal = (diaFinal * 86400) + (horaFinal * 3600) + (minutoFinal * 60) + segundoFinal;

        duracaoEmSegundos = tempoFinal - tempoInicial;

        dias = duracaoEmSegundos / 86400;
        resto = duracaoEmSegundos % 86400;
        horas = resto / 3600;
        resto = resto % 3600;
        minutos = resto / 60;
        segundos = resto % 60;

        // Console.WriteLine(duracaoEmSegundos);
        Console.WriteLine(dias + " dia(s)");
        Console.WriteLine(horas + " hora(s)");
        Console.WriteLine(minutos + " minuto(s)");
        Console.WriteLine(segundos + " segundo(s)");

      Console.ReadLine();
    }
  }
};
```

## Aula 29 - Slides utilizados no capítulo

## Aula 30 - Expressões comparativas

Expressões comparativas comparam uma coisa com outra. Quando você avalia uma expressão comparativa, o resultado é um valor verdade(verdadeiro/falso). C, C++, Java, C#:

| Operador |  Significado   |
| :------: | :------------: |
|    >     |     maior      |
|    <     |     menor      |
|    >=    | maior ou igual |
|    <=    | menor ou igual |
|    ==    |     igual      |
|    !=    |   diferente    |

## Aula 31 - Expressões lógicas

São expressões que quando avaliada resultam em um valor veradade.  C, C++, Java, C#:

| Operador | Significado |
| :------: | :---------: |
|    &&    |      E      |
|   \|\|   |     OU      |
|    !     |     NÃO     |

- ### E -> Todas as condições devem ser verdadeiras.  Exemplo:

Suponha x igual a 5

x <= 20 && x == 10  Resultado: F

x > 0 && x != 3  Resultado: V

x <= 20 && x == 10 && x != 3  Resultado: F

- Tabela verdade do operador E

|  A   |  B   | A && B |
| :--: | :--: | :----: |
|  F   |  F   |   F    |
|  F   |  V   |   F    |
|  V   |  F   |   F    |
|  V   |  V   |   V    |

- ### OU -> Pelo menos uma condição deve ser verdadeira. Exemplo: 

Suponha x igual a 5

x == 10 || x <= 20  Resultado: V

x > 0 || x != 3  Resultado: V

x <= 0  || x != 3 || x != 5  Resultado: V

- Tabela verdade do operador OU

|  A   |  B   | A \|\| B |
| :--: | :--: | :------: |
|  F   |  F   |    F     |
|  F   |  V   |    V     |
|  V   |  F   |    V     |
|  V   |  V   |    V     |

- ### NÃO -> O operador "NÃO" inverte a condiçao. Exemplo: 

Suponha x igual a 5

! ( x == 10 )  Resultado: V

! ( x >= 2 )  Resultado: F

! ( x <= 20  && x == 10 )  Resultado: V

|  A   |  !A  |
| :--: | :--: |
|  F   |  V   |
|  V   |  F   |

## Aula 32 - Estrutura condicional

É uma __estrutura de controle__ que permite definir que um certo __bloco de comandos__ somente será executado dependendo de uma __condição__.

- ### Sintaxe da estrutura condicional

  - ### Simples

    ```c#
    if ( condição ) {
        comando 1
        comando 2
    }
    ```

    Regra:

    ​	Condição verdadeira - executa o bloco de comandos.

    ​	Condição Falsa - pula o bloco de comandos.

    Exemplo: 

    ```c#
    int x = 5;
            
    Console.WriteLine("Bom dia");
    
    if ( x < 5 ) {
        Console.WriteLine("Boa tarde");
    }
    
    Console.WriteLine("Boa noite");
    ```

    

    

  - ### Composta

    ```c#
    if ( condição ) {
        comando 1
        comando 2
    } else {
        comando 3
        comando 4
    }
    ```

    Condição verdadeira - executa somente o bloco do __if__.

    Condição Falsa - executa somente o bloco do __else__.

    Exemplo: 

    ```c#
    int horas;
    
    Console.WriteLine("Quantas horas? ");
    horas = int.Parse(Console.ReadLine());
    
    if ( horas < 12 ){
        Console.WriteLine("Bom dia!");
    }
    else {
        Console.WriteLine("Boa tarde!");
    }
    ```

  E se eu tiver mais de duas possibilidades ?

   - ### Encademamento de estruturas condicionais:

     ```c#
     if ( condição ) {
         comando 1
         comando 2
     }
     else {
         if ( condição 2 ) {
             comando 3
             comando 4
         }
         else {
             comando 5
             comando 6
         }
     }
     ```

     Exemplo: 

     ```c#
     int hora;
     
             Console.WriteLine("Quantas horas? ");
             hora = int.Parse(Console.ReadLine());
     
             if ( hora < 12 ){
                 Console.WriteLine("Bom dia!");
             }
             else {
                 if ( hora < 18 ) {
                     Console.WriteLine("Boa tarde!");
                 }
                 else {
                     Console.WriteLine("Boa noite!");
                 }
             }
     ```

     Uma forma mais simples de escrever as estruturas condicionais encadeadas

     ```c#
     if ( condição ) {
         comando 1
         comando 2
     }
     else if ( condição 2 ) {
         comando 3
         comando 4
     }
     else if ( condição 3 ) {
         comando 5
         comando 6
     }
     else {
         comando 7
         comando 8
     }
     ```

## Aula 33 -  Exercício resolvido 01

Fazer um programa para ler as duas notas que um aluno obteve no primeiro e segundo semestres de uma disciplina anual. em seguida, mostrar a nota final que o aluno obteve no ano juntamente com um texto explicativo. Caso a nota final do aluno seja inferior a 60,00, mostrar a mensagem "REPROVADO", conforme  exemplos. Todos os valores devem ter uma casa decimal.

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();

        Console.WriteLine("Exercício resolvido");

        double nota1, nota2, notaFinal;
        
        Console.WriteLine("Digite a 1ª nota");
        nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Digite a 2ª nota");
        nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        notaFinal = nota1 + nota2;

        Console.WriteLine("NOTA FINAL = " + notaFinal.ToString("F1", CultureInfo.InvariantCulture));

        if ( notaFinal < 60.0 ) {
            Console.WriteLine("REPROVADO");
        }
        
      Console.ReadLine();
    }
  }
};
```

## Aula 34 - Exercício resolvido 02

- beecrowd 1036

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1061");
        Console.WriteLine("Tempo de um Evento");
        Console.WriteLine("Dia e Hora Inicial");

        double A, B, C, delta, R1, R2;

        string[] v = Console.ReadLine().Split(' ');
        A = double.Parse(v[0], CultureInfo.InvariantCulture);
        B = double.Parse(v[1], CultureInfo.InvariantCulture);
        C = double.Parse(v[2], CultureInfo.InvariantCulture);

        delta = Math.Pow(B, 2.0) - (4.0 * A * C);
        
        if ( A == 0.0 || delta < 0.0 ) {
            Console.WriteLine("Impossivel calcular");
        } else {
            R1 = ( -B + Math.Sqrt(delta)) / (2.0 * A);
            R2 = ( -B - Math.Sqrt(delta)) / (2.0 * A);

            Console.WriteLine("R1 = " + R1.ToString("F5", CultureInfo.InvariantCulture));
            Console.WriteLine("R2 = " + R2.ToString("F5", CultureInfo.InvariantCulture));
        }

      Console.ReadLine();
    }
  }
};
```

## Aula 35 - Exercício resolvido 03

Fazer um programa para ler três números inteiros. Em seguida, mostrar qual o menor dentre os três números lidos. em caso de empate, mostrar apenas uma vez.

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício resolvido 03");
        Console.WriteLine("Menor número");
        Console.WriteLine("Três inteiros");

        int A, B, C, menor;

        string[] v = Console.ReadLine().Split(' ');
        A = int.Parse(v[0]);
        B = int.Parse(v[1]);
        C = int.Parse(v[2]);

        menor = A;

        if ( B < menor ) {
            menor = B;
        } else if ( C < menor ) {
            menor = C;
        };

        Console.WriteLine("MENOR = " + menor);
        
      Console.ReadLine();
    }
  }
};
```

## Aula 36 -  Sintaxe opcional: operadores de atribuição cumulativa

Uma operadora de relefonia cobra R$50.00 por um planobásico que dá direito a 100 minutos de telefone. Cada minuto que exceder a franquia de 100 minutos custa R$2.00. Fazer um programa para ler a quantidade de minutos que uma pessoa consumiu, daí mostrar o valor a ser pago.

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Operadores de atribuição cumulativa");
        Console.WriteLine("Número inteiro");

        int minutos;
        double valorFinal = 50.0;
        
        minutos = int.Parse(Console.ReadLine());

        if ( minutos  > 100 ) {
            valorFinal += ((minutos - 100) * 2);
        };

        Console.WriteLine("Valor a pargar: " + valorFinal.ToString("F2", CultureInfo.InvariantCulture));
        Console.ReadLine();
    }
  }
};
```

Operadores de atribuição cumulativa

| a += b  | a = a + b |
| :-----: | :-------: |
| a -= b  | a = a - b |
| a *= b  | a = a * b |
| a  /= b | a = a / b |
| a %= b  | a = a % b |

## Aula 37 - Sintaxe opcional: estrutura switch-case

- Quando se tem três ou mais opções e fluxo a serem tratadoas com base no valor de uma variável, ao invés de várias estruturas if-else encadeadas, alguns preferem utilizar a estrutura __switch-case__.

Problema exemplo:

Fazer um programa para ler um valor inteiro de 1 a 7 representando um dia da semana (sendo 1 = domingo, 2 = segunda, e assim por diante). Escrever na tela o dia da semana correspondente, conforme exemplos.

| Entrada |             Saída             |
| :-----: | :---------------------------: |
|    1    |    Dia da semana: domingo     |
|    4    |     Dia da semana: quarta     |
|    9    | Dia da semana: valor inválido |

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Estrutura switch-case");
        Console.WriteLine("Número inteiro");

        string diaDaSemana = "";
        
        int numero = int.Parse(Console.ReadLine());

        switch (numero)
        {
            case 1: 
                diaDaSemana = "domingo";
            break;
            case 2:
                diaDaSemana = "segunda";
            break;
            case 3:
                diaDaSemana = "terça";
            break;
            case 4:
                diaDaSemana = "quarta";
            break;
            case 5:
                diaDaSemana = "quinta";
            break;
            case 6:
                diaDaSemana = "sexta";
            break; 
            case 7:
                diaDaSemana = "sabado";
            break;
            default:
                diaDaSemana = "valor inválido";
            break;
        };

        Console.WriteLine("Dia da semana: " + diaDaSemana);
        Console.ReadLine();
    }
  }
};
```

### Sintaxe do switch-case

```c#
switch ( expressão ) {
    case valor1:
        comando1
        comando2
        break;
    case valor2:
        comando3
        comando4
    	break;
    default:
        comando5
        comando6
        break;
}
```

## Aula 38 - Exercícios propostos

- Exercício 1035

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1061");
        Console.WriteLine("Teste de Seleção 1");
        Console.WriteLine("Números inteiros");

        int A, B, C, D;
        string[] valores = Console.ReadLine().Split(' ');
        A = int.Parse(valores[0]);
        B = int.Parse(valores[1]);
        C = int.Parse(valores[2]);
        D = int.Parse(valores[3]);        

        if (B>C && D>A && (C+D) > (A+B) && C > 0 && D > 0 && (A%2==0)) {
            Console.WriteLine( "Valores aceitos" );
        } else {
            Console.WriteLine( "Valores nao aceitos" );
        };

        Console.ReadLine();
    }
  }
};
```

- Exercício 1038

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1038");
        Console.WriteLine("Lanche");
        Console.WriteLine("Código/Quantidade");

        int codigoProduto, quantidadeProduto;
        double valorTotal = 0.0;

        string[] valores = Console.ReadLine().Split(' ');
        codigoProduto = int.Parse(valores[0]);
        quantidadeProduto = int.Parse(valores[1]);
            
        
        switch (codigoProduto)
        {
            case 1:
                valorTotal = (double)(quantidadeProduto * 4.00);
            break;
            case 2:
                valorTotal = (double)(quantidadeProduto * 4.50);
            break;
            case 3:
                valorTotal = (double)(quantidadeProduto * 5.00);
            break;
            case 4:
                valorTotal = (double)(quantidadeProduto * 2.00);
            break;
            case 5:
                valorTotal = (double)(quantidadeProduto * 1.50);
            break;
            // default:
            //     Console.WriteLine("Código inválido!");
            // break;
        }

        Console.WriteLine("Total: R$ " + valorTotal.ToString("F2", CultureInfo.InstalledUICulture));
        

        Console.ReadLine();
    }
  }
};
```

- Exercício 1044

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1044");
        Console.WriteLine("Múltiplos");
        Console.WriteLine("A/B inteiro");

        int A, B, resto, menor, maior;

        string[] valores = Console.ReadLine().Split(' ');
        A = int.Parse(valores[0]);
        B = int.Parse(valores[1]);
        menor = A;
        maior = B;

        if(menor > B){
            menor = B;
            maior = A;
        }
            
        if(maior % menor == 0){ 
            Console.WriteLine("Sao Multiplos");
        } else {
            Console.WriteLine("Nao sao Multiplos");
        }

        Console.ReadLine();
    }
  }
};
```

- Exercício 1046

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1046");
        Console.WriteLine("Tempo de Jogo");
        Console.WriteLine("A/B inteiro");

        int horaInicial, horaFinal, tempoDeJogo;

        string[] valores = Console.ReadLine().Split(' ');
        horaInicial = int.Parse(valores[0]);
        horaFinal = int.Parse(valores[1]);
        
        if(horaInicial >= horaFinal){
            tempoDeJogo = (24 - horaInicial) + horaFinal;
        } else {
            tempoDeJogo = horaFinal - horaInicial;
        }
            
        Console.WriteLine("O JOGO DUROU " + tempoDeJogo + " HORA(S)");

        Console.ReadLine();
    }
  }
};
```

- Exercício 1048

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1048");
        Console.WriteLine("Aumento de Salário");
        Console.WriteLine("Salário/double");

        double salario, novoSalario = 0.0, reajusteGanho = 0.0;
        int percentual = 0;

        salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if(salario > 2000.0){
            novoSalario = (double)(salario + (salario * 0.04));
            reajusteGanho = (double)(salario * 0.04);
            percentual = 4;
        } else if(salario > 1200.0){
            novoSalario = (double)(salario + (salario * 0.07));
            reajusteGanho = (double)(salario * 0.07);
            percentual = 7;
        } else if(salario  > 800.0){
            novoSalario = (double)(salario + (salario * 0.10));
            reajusteGanho = (double)(salario * 0.10);
            percentual = 10;
        } else if(salario > 400.0){
            novoSalario = (double)(salario + (salario * 0.12));
            reajusteGanho = (double)(salario * 0.12);
            percentual = 12;
        } else {
            novoSalario = (double)(salario + (salario * 0.15));
            reajusteGanho = (double)(salario * 0.15);
            percentual = 15;
        }

        Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InstalledUICulture));
        Console.WriteLine("Reajuste ganho: " + reajusteGanho.ToString("F2", CultureInfo.InstalledUICulture));
        Console.WriteLine("Em percentual: " + percentual + " %");

        Console.ReadLine();
    }
  }
};
```

- Exercício 1037

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1037");
        Console.WriteLine("Intervalo");
        Console.WriteLine("Valor/double");

        double valor = 0.0;
        string intervalo = "";

        valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if(valor >= 0 && valor <= 25.0){
            intervalo = "Intervalo [0,25]";
        } else if(valor > 25.0 && valor <= 50.0){
            intervalo = "Intervalo (25,50]";
        } else if(valor > 50.0 && valor <= 75.0){
            intervalo = "Intervalo (50,75]";
        } else if(valor > 75.0 && valor <= 100.0){
            intervalo = "Intervalo (75,100]";
        } else {
            intervalo = "Fora de intervalo";
        }

        Console.WriteLine(intervalo);
        
        Console.ReadLine();
    }
  }
};
```

- Exercício 1040 (use float)

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1040");
        Console.WriteLine("Média 3");
        Console.WriteLine("4 Valores/double");
        Console.WriteLine("------------------------");

        float N1, N2, N3, N4, media, notaDoExame, mediaFinal;
        const int peso1 = 2, peso2 = 3, peso3 = 4, peso4 = 1;
        string statusAluno = "", statusPosFinal = "";

        string[] v = Console.ReadLine().Split(' ');
        N1 = float.Parse(v[0], CultureInfo.InvariantCulture);
        N2 = float.Parse(v[1], CultureInfo.InvariantCulture);
        N3 = float.Parse(v[2], CultureInfo.InvariantCulture);
        N4 = float.Parse(v[3], CultureInfo.InvariantCulture);

        media = ( ((N1 * peso1) + (N2 * peso2) + (N3 * peso3) + (N4 * peso4)) / (peso1 + peso2 + peso3 + peso4) );
        if (media == 4.85f) {
          media = 4.8f;
        }
        
        if(media >= 7.0){
          statusAluno = "Aluno aprovado.";
        } else if(media < 7.0 && media >= 5.0) { 
          statusAluno = "Aluno em exame.";
        } else {
          statusAluno = "Aluno reprovado.";
        }

        Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
        Console.WriteLine(statusAluno);

        if(statusAluno == "Aluno em exame."){
          
          notaDoExame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
          mediaFinal = ( (notaDoExame + media) / 2 );
          
          if(mediaFinal >= 5.0){
            statusPosFinal = "Aluno aprovado.";
          } else {
            statusPosFinal = "Aluno reprovado.";
          }

          Console.WriteLine("Nota do exame: " + notaDoExame.ToString("F1", CultureInfo.InvariantCulture));
          Console.WriteLine(statusPosFinal);
          Console.WriteLine("Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
        }
        
        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};
```

- Exercício 1041

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1041");
        Console.WriteLine("Coordenadas de um Ponto");
        Console.WriteLine("2 Valores/double");
        Console.WriteLine("------------------------");

        double x = 0.0, y = 0.0;
        string quadrante = "";

        string[] v = Console.ReadLine().Split(' ');
        x = double.Parse(v[0], CultureInfo.InvariantCulture);
        y = double.Parse(v[1], CultureInfo.InvariantCulture);

        if(x == 0.0 && y == 0.0){
            quadrante = "Origem";
        } else if(y == 0.0){
            quadrante = "Eixo X";
        } else if(x == 0.0){
            quadrante = "Eixo Y";
        } else if(x > 0.0 && y > 0.0){
            quadrante = "Q1";
        } else if(x < 0.0 && y > 0.0){
            quadrante = "Q2";
        } else if(x < 0.0 && y < 0.0){
            quadrante = "Q3";
        } else if(x > 0.0 && y < 0.0){
            quadrante = "Q4";
        }

        Console.WriteLine(quadrante);

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};
```

- Exercício 1045

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1045");
        Console.WriteLine("Tipos de Triângulos");
        Console.WriteLine("2 Valores/double");
        Console.WriteLine("------------------------");

        float A, B, C, troca;
        string[] v = Console.ReadLine().Split(' ');
        A = float.Parse(v[0], CultureInfo.InvariantCulture);
        B = float.Parse(v[1], CultureInfo.InvariantCulture);
        C = float.Parse(v[2], CultureInfo.InvariantCulture);

        //ordenacao dos valores em ordem decrescente
        if(B > A){
            troca = A;
            A = B;
            B = troca;
        }
        if(C > A){
            troca = A;
            A = C;
            C = troca;
        }
        if(C > B){
            troca  = B;
            B = C;
            C = troca;
        }

        //classificacao dos valores
        if(A >= B + C){
            Console.WriteLine("NAO FORMA TRIANGULO");
        } else if(Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2)){
            Console.WriteLine("TRIANGULO RETANGULO");
        } else if(Math.Pow(A, 2) > Math.Pow(B, 2) + Math.Pow(C, 2)){
            Console.WriteLine("TRIANGULO OBTUSANGULO");
        } else if(Math.Pow(A, 2) < Math.Pow(B, 2) + Math.Pow(C, 2)){
            Console.WriteLine("TRIANGULO ACUTANGULO");
        }

        if(A == B && B == C){
            Console.WriteLine("TRIANGULO EQUILATERO");
        } else if(A == B || A == C || B == C){
            Console.WriteLine("TRIANGULO ISOSCELES");
        }


        Console.WriteLine("------------------------");
        Console.WriteLine(A.ToString("F1", CultureInfo.InvariantCulture));
        Console.WriteLine(B.ToString("F1", CultureInfo.InvariantCulture));
        Console.WriteLine(C.ToString("F1", CultureInfo.InvariantCulture));
        Console.ReadLine();
    }
  }
};
```

- Exercício 1047

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1047");
        Console.WriteLine("Tempo de Jogo com Minutos");
        Console.WriteLine("4 Valores/int");
        Console.WriteLine("------------------------");

        int horaInicial, minutoInicial, horaFinal, minutoFinal, tempoEmMinutoInicial, tempoEmMinutoFinal, duracaoEmMinutos = 0;
        int horasDeDuracao, minutosDeDuracao;
        string[] v = Console.ReadLine().Split(' ');
        horaInicial = int.Parse(v[0]);
        minutoInicial = int.Parse(v[1]);
        horaFinal = int.Parse(v[2]);
        minutoFinal = int.Parse(v[3]);

        tempoEmMinutoInicial = ((horaInicial * 60) + minutoInicial);
        tempoEmMinutoFinal = ((horaFinal * 60) + minutoFinal);

        if(tempoEmMinutoInicial < tempoEmMinutoFinal){
            duracaoEmMinutos = tempoEmMinutoFinal - tempoEmMinutoInicial;
        } else {
            duracaoEmMinutos = ((24 * 60) -tempoEmMinutoInicial) + tempoEmMinutoFinal;
        }

        horasDeDuracao = duracaoEmMinutos / 60;
        minutosDeDuracao = duracaoEmMinutos % 60;        

        Console.WriteLine("O JOGO DUROU "+ horasDeDuracao +" HORA(S) E "+ minutosDeDuracao+ " MINUTO(S)");
        
        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};
```

- Exercício 1049

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1049");
        Console.WriteLine("Animal");
        Console.WriteLine("3 palavras/string");
        Console.WriteLine("------------------------");

        string classificacao, tipo, alimentacao, animal = "";

        classificacao = Console.ReadLine();
        tipo = Console.ReadLine();
        alimentacao = Console.ReadLine();

        if(classificacao == "vertebrado"){
            if(tipo == "ave"){
                if(alimentacao == "carnivoro"){
                    animal = "aguia";
                } else if (alimentacao == "onivoro"){
                    animal = "pomba";
                }
            } else if(tipo == "mamifero"){
                if(alimentacao == "onivoro"){
                    animal = "homem";
                } else if(alimentacao == "herbivoro"){
                    animal = "vaca";
                }
            }
        } else if(classificacao == "invertebrado"){
            if(tipo == "inseto"){
                if(alimentacao == "hematofago"){
                    animal = "pulga";
                } else if(alimentacao == "herbivoro"){
                    animal = "lagarta";
                }
            } else if(tipo == "anelideo"){
                if(alimentacao == "hematofago"){
                    animal = "sanguessuga";
                } else if(alimentacao == "onivoro"){
                    animal = "minhoca";
                }
            }
        }

        Console.WriteLine(animal);
        
        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};
```

- Exercício 1051

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1051");
        Console.WriteLine("Imposto de Renda");
        Console.WriteLine("1 Valor/double");
        Console.WriteLine("------------------------");

        double valorDoImposto = 0.0;
        double receita = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if(receita <= 2000.0){
            Console.WriteLine("Isento");
        } else if(receita <= 3000.0){
            double valorIncidente = receita  - 2000.0;
            valorDoImposto = valorIncidente * 0.08;
            Console.WriteLine("R$ " + valorDoImposto.ToString("F2", CultureInfo.InvariantCulture));
        } else if(receita <= 4500.0){
            double valorIncidente = receita - 3000.0;
            valorDoImposto = (valorIncidente * 0.18) + 80;
            Console.WriteLine("R$ " + valorDoImposto.ToString("F2", CultureInfo.InvariantCulture));
        } else if(receita > 4500.0){
            double valorIncidente = receita - 4500.0;
            valorDoImposto = (valorIncidente * 0.28) + 80 + 270;
            Console.WriteLine("R$ " + valorDoImposto.ToString("F2", CultureInfo.InvariantCulture));
        }

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};
```

- Exercício 1042

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1042");
        Console.WriteLine("Sort Simples");
        Console.WriteLine("3 Valores/int");
        Console.WriteLine("------------------------");

        int A, B, C, troca;
        string[] v = Console.ReadLine().Split();
        A = int.Parse(v[0]);
        B = int.Parse(v[1]);
        C = int.Parse(v[2]);

        if(B < A){
            troca = A;
            A = B;
            B = troca;
        }
        if(C < A){
            troca = A;
            A = C;
            C = troca;
        }
        if(C < B){
            troca = B;
            B = C;
            C = troca;
        }
        
        Console.WriteLine(A);
        Console.WriteLine(B);
        Console.WriteLine(C);
        Console.WriteLine();
        Console.WriteLine(v[0]);
        Console.WriteLine(v[1]);
        Console.WriteLine(v[2]);

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};
```

- Exercício 1043

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1043");
        Console.WriteLine("Triângulo");
        Console.WriteLine("3 Valores/double");
        Console.WriteLine("------------------------");

        double A, B, C, areaTrapezio, perimetroTriangulo;
        string[] v = Console.ReadLine().Split(' ');
        A = double.Parse(v[0], CultureInfo.InvariantCulture);
        B = double.Parse(v[1], CultureInfo.InvariantCulture);
        C = double.Parse(v[2], CultureInfo.InvariantCulture);

        if(A + B > C && A + C > B && C + B > A){
            perimetroTriangulo = A + B + C;
            Console.WriteLine("Perimetro = " + perimetroTriangulo.ToString("F1", CultureInfo.InvariantCulture));
        } else {
            areaTrapezio = (((A + B) * C) / 2);
            Console.WriteLine("Area = " + areaTrapezio.ToString("F1", CultureInfo.InvariantCulture));
        }

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};
```

- Exercício 1050

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1050");
        Console.WriteLine("DDD");
        Console.WriteLine("1 Valor/int");
        Console.WriteLine("------------------------");

        int DDD = int.Parse(Console.ReadLine());
        string destino = "";

        if(DDD == 61){
            destino = "Brasilia";
        } else if(DDD == 71){
            destino = "Salvador";
        } else if(DDD == 11){
            destino = "Sao Paulo";
        } else if(DDD == 21){
            destino = "Rio de Janeiro";
        } else if(DDD == 32){
            destino = "Juiz de Fora";
        } else if(DDD == 19){
            destino = "Campinas";
        } else if(DDD == 27){
            destino = "Vitoria";
        } else if(DDD == 31){
            destino = "Belo Horizonte";
        } else {
            destino = "DDD nao cadastrado";
        }

        Console.WriteLine(destino);

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};
```

- Exercício 1052

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1052");
        Console.WriteLine("Mês");
        Console.WriteLine("1 valor/int");
        Console.WriteLine("------------------------");

        int numero = int.Parse(Console.ReadLine());
        string mes = "";

        switch (numero){
            case 1:
                mes = "January";
                break;
            case 2:
                mes = "February";
                break;
            case 3:
                mes = "March";
            break;
            case 4:
                mes = "April";
                break;
            case 5:
                mes = "May";
                break;
            case 6:
                mes = "June";
                break;
            case 7:
                mes = "July";
                break;
            case 8:
                mes = "August";
                break;
            case 9:
                mes = "September";
                break;
            case 10:
                mes = "October";
                break;
            case 11:
                mes = "November";
                break;
            case 12:
                mes = "December";
                break;
        }

        Console.WriteLine(mes);
        
        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};
```

- Exercício 1060

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1060");
        Console.WriteLine("Números Positivos");
        Console.WriteLine("6 valores/int");
        Console.WriteLine("------------------------");

        int valoresPositivos = 0;
        double A, B, C, D, E, F;

        A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        D = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        E = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        F = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if(A > 0){
            valoresPositivos++;
        }
        if(B > 0){
            valoresPositivos++;
        }
        if(C > 0){
            valoresPositivos++;
        }
        if(D > 0){
            valoresPositivos++;
        }
        if(E > 0){
            valoresPositivos++;
        }
        if(F > 0){
            valoresPositivos++;
        }

        Console.WriteLine(valoresPositivos + " valores positivos");
        
        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};
```

- Exercício 1064

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1064");
        Console.WriteLine("Positivos e Média");
        Console.WriteLine("6 valores/int");
        Console.WriteLine("------------------------");

        int valoresPositivos = 0;
        double A, B, C, D, E, F, somaDosValoresPositivos = 0, mediaDosValoresPositivos = 0;

        A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        D = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        E = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        F = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if(A > 0){
            valoresPositivos++;
            somaDosValoresPositivos += A;
        }
        if(B > 0){
            valoresPositivos++;
            somaDosValoresPositivos += B;
        }
        if(C > 0){
            valoresPositivos++;
            somaDosValoresPositivos += C;
        }
        if(D > 0){
            valoresPositivos++;
            somaDosValoresPositivos += D;
        }
        if(E > 0){
            valoresPositivos++;
            somaDosValoresPositivos += E;
        }
        if(F > 0){
            valoresPositivos++;
            somaDosValoresPositivos += F;
        }

        mediaDosValoresPositivos = somaDosValoresPositivos / valoresPositivos;

        Console.WriteLine(valoresPositivos + " valores positivos");
        Console.WriteLine(mediaDosValoresPositivos.ToString("F1", CultureInfo.InvariantCulture));
        
        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};
```

- Exercício 1065

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1065");
        Console.WriteLine("Pares entre Cinco Números");
        Console.WriteLine("5 valores/int");
        Console.WriteLine("------------------------");

        int A, B, C, D, E, valoresPares = 0;

        A = int.Parse(Console.ReadLine());
        B = int.Parse(Console.ReadLine());
        C = int.Parse(Console.ReadLine());
        D = int.Parse(Console.ReadLine());
        E = int.Parse(Console.ReadLine());

        if(A % 2 == 0){
            valoresPares++;
        }
        if(B % 2 == 0){
            valoresPares++;
        }
        if(C % 2 == 0){
            valoresPares++;
        }
        if(D % 2 == 0){
            valoresPares++;
        }
        if(E % 2 == 0){
            valoresPares++;
        }

        Console.WriteLine(valoresPares + " valores pares");
        
        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};
```

- Exercício 1066

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1066");
        Console.WriteLine("Pares, Ímpares, Positivos e Negativos");
        Console.WriteLine("5 valores/int");
        Console.WriteLine("------------------------");

        int A, B, C, D, E, valoresPares = 0, valoresImpares = 0, valoresPositivos = 0, valoresNegativos = 0;

        A = int.Parse(Console.ReadLine());
        B = int.Parse(Console.ReadLine());
        C = int.Parse(Console.ReadLine());
        D = int.Parse(Console.ReadLine());
        E = int.Parse(Console.ReadLine());

        //determina valores pares
        if(A % 2 == 0){
            valoresPares++;
        }
        if(B % 2 == 0){
            valoresPares++;
        }
        if(C % 2 == 0){
            valoresPares++;
        }
        if(D % 2 == 0){
            valoresPares++;
        }
        if(E % 2 == 0){
            valoresPares++;
        }

        //determina valolores impares
        if(A % 2 != 0){
            valoresImpares++;
        }
        if(B % 2 != 0){
            valoresImpares++;
        }
        if(C % 2 != 0){
            valoresImpares++;
        }
        if(D % 2 != 0){
            valoresImpares++;
        }
        if(E % 2 != 0){
            valoresImpares++;
        }

        //determina valores positivos
        if(A > 0){
            valoresPositivos++;
        }
        if(B > 0){
            valoresPositivos++;
        }
        if(C > 0){
            valoresPositivos++;
        }
        if(D > 0){
            valoresPositivos++;
        }
        if(E > 0){
            valoresPositivos++;
        }

        //determina valores negativos
        if(A < 0){
            valoresNegativos++;
        }
        if(B < 0){
            valoresNegativos++;
        }
        if(C < 0){
            valoresNegativos++;
        }
        if(D < 0){
            valoresNegativos++;
        }
        if(E < 0){
            valoresNegativos++;
        }

        Console.WriteLine(valoresPares + " valor(es) par(es)");
        Console.WriteLine(valoresImpares + " valor(es) impar(es)");
        Console.WriteLine(valoresPositivos + " valor(es) positivo(s)");
        Console.WriteLine(valoresNegativos + " valor(es) negativo(s)");
        
        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};
```

- Exercício 1070

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1070");
        Console.WriteLine("Seis Números Ímpares");
        Console.WriteLine("1 valor/int");
        Console.WriteLine("------------------------");

        int valor = int.Parse(Console.ReadLine());

        if (valor % 2 == 0) {
            valor++;
        }

        Console.WriteLine(valor);
        Console.WriteLine(valor += 2);
        Console.WriteLine(valor += 2);
        Console.WriteLine(valor += 2);
        Console.WriteLine(valor += 2);
        Console.WriteLine(valor += 2);
                
        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};
```

## Aula 39 - Slides utilizados no capítulo

## Aula 40 - Estrutura repetitiva enquanto

É uma estrutura de controle que repete um bloco de comandos enquanto uma condição for verdadeira.

### Quando usar:

Quando não se sabe previamente a quantidade de repetições que será realizada.

Fazer um programa que lê números inteiros até que um zero seja lido. Ao final mostra a soma dos números lidos.

|         Entrada         | saída |
| :---------------------: | :---: |
| 5<br />2<br />4<br /> 0 |  11   |

### Sintaxe / regra

```c#
while ( condição ) {
	comando 1
	comando 2
}
```

### Regra:
Verdadeira: executa e volta
Falsa: pula fora

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("class40_estruturaRepetitivaEnquanto");
        Console.WriteLine("Estrutura repetitiva enquanto");
        Console.WriteLine("5 valores/int");
        Console.WriteLine("------------------------");

        int numero = 1, somaValores = 0;

        while(numero != 0){
            numero = int.Parse(Console.ReadLine());
            somaValores += numero;
        }

        Console.WriteLine(somaValores);
                
        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
}; 
```

## Aula 41 - Teste de mesa com estrutura enquanto

## Aula 42 - Exercícios propostos PARTE 1 - testes de mesa com estrutura enquanto

**EXERCÍCIOS PROPOSTOS - PARTE 1**

**TESTES DE MESA COM ESTRUTURA ENQUANTO**

Caros estudantes, conforme exemplo visto no vídeo anterior, favor resolver os testes de mesa do arquivo PDF anexo a este artigo. 

Para realizar esta tarefa, sugerimos uma das seguintes alternativas:

- Imprimir o PDF, escrevendo na folha impressa
- Copiar os desenhos no seu caderno, escrevendo no caderno
- Usar um editor de PDF ou de imagem e escrever no computador

## Aula 43 - Exercício resolvido 01

- ex1113

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1113");
        Console.WriteLine("Crescente e Decrescente");
        Console.WriteLine("2 valores/int");
        Console.WriteLine("------------------------");

        int x = 0, y = 1;
        
        while(x != y){

            string[] v = Console.ReadLine().Split(' ');
            x = int.Parse(v[0]);
            y = int.Parse(v[1]);

            if(x > y){
                Console.WriteLine("Decrescente");
            } else if (x < y){
                Console.WriteLine("Crescente");
            }
        }
                
        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};
```

## Aula 44 - Exercício resolvido 02

Faça um progrma para ler um número indeterminado de dados, contendo cada um, a idade de um indivíduo. O último dado, que não entrará nos cálculos, contém um valor de idade negativa. Calcular e imprimir a idade média deste grupo de indivíduos. se for entrado um valor negativo na primeira vez, mostrar a mensagem "impossivel calcular".

| Entrada                    | Saída               |
| -------------------------- | ------------------- |
| 31<br />27<br />46<br />-5 | 34.67               |
| -10                        | impossivel calcular |

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("class44_exercicioResolvido02");
        // Console.WriteLine("Crescente e Decrescente");
        Console.WriteLine("Valores/int");
        Console.WriteLine("------------------------");

        double idade, somaIdades = 0.0, contador = 0.0, mediaIdades = 0.0;

        idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if(idade < 0.0){
            Console.WriteLine("impossivel calcular");
        } else {
            while (idade > 0.0) {
                somaIdades += idade;
                contador++;
                idade = double.Parse(Console.ReadLine());
            }

            mediaIdades = somaIdades / contador;

            Console.WriteLine(mediaIdades.ToString("F2", CultureInfo.InvariantCulture));
        }
                
        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};
```

## Aula 45 -  Exercícios propostos PARTE 2 - problemas com estrutura enquanto

[__Soluções__](https://github.com/acenelio/curso-logica-de-programacao-csharp)

- ex1114

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1114");
        Console.WriteLine("Senha Fixa");
        Console.WriteLine("Valores/int");
        Console.WriteLine("------------------------");

        int senha = int.Parse(Console.ReadLine());

        while(senha != 2002){
            Console.WriteLine("Senha Invalida");
            senha = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Acesso Permitido");
                
        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};
```

- ex1115

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1115");
        Console.WriteLine("Quadrante");
        Console.WriteLine("Valores/int");
        Console.WriteLine("------------------------");

        int x = 1, y = 1;

        while(x != 0 && y != 0){
            string[] v = Console.ReadLine().Split(' ');
            x = int.Parse(v[0]);
            y = int.Parse(v[1]);

            if(x > 0 && y > 0){
                Console.WriteLine("primeiro");
            } else if(x < 0 && y > 0){
                Console.WriteLine("segundo");
            } else if(x < 0 && y < 0){
                Console.WriteLine("terceiro");
            } else if(x > 0 && y < 0){
                Console.WriteLine("quarto");
            }
        }
                
        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};
```

- ex1117

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1117");
        Console.WriteLine("Validação de Nota");
        Console.WriteLine("2 Valores/double");
        Console.WriteLine("------------------------");

        double notaA, notaB, media;

        notaA = double.Parse(Console.ReadLine());

        while(notaA < 0.0 || notaA > 10.0) {
            Console.WriteLine("nota invalida");
            notaA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        notaB = double.Parse(Console.ReadLine());

        while(notaB < 0.0 || notaB > 10.0) {
            Console.WriteLine("nota invalida");
            notaB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        media = ((notaA + notaB) / 2);

        Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));
                
        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};
```

- ex1134

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1134");
        Console.WriteLine("Tipo de Combustível");
        Console.WriteLine("1 Valor/int");
        Console.WriteLine("------------------------");

        int alcool = 0, gasolina = 0, diesel = 0, combustivel = 0;

        while (combustivel != 4) {

            combustivel = int.Parse(Console.ReadLine());

            while ( combustivel < 1 || combustivel > 4) {
                combustivel = int.Parse(Console.ReadLine());
            }

            if ( combustivel == 1 ) {
                alcool++;
            } else if( combustivel == 2) {
                gasolina++;
            } else if ( combustivel == 3) {
                diesel++;
            }
        }

        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine("Alcool: " + alcool);
        Console.WriteLine("Gasolina: " + gasolina);
        Console.WriteLine("Diesel: " + diesel);
                
        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};
```

- ex1154

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1154");
        Console.WriteLine("Idades");
        Console.WriteLine("Valores/int");
        Console.WriteLine("------------------------");

        int idade = 1, somaIdades = 0;
        double idadeMedia, contador = 0.0;

        while (idade > 0) {
            idade = int.Parse(Console.ReadLine());
            if(idade > 0){
                somaIdades += idade;
                contador++;
            }
        }

        idadeMedia = (double) (somaIdades / contador);

        Console.WriteLine(idadeMedia.ToString("F2", CultureInfo.InvariantCulture));

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};
```

- ex1159

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1159");
        Console.WriteLine("Soma de Pares Consecutivos");
        Console.WriteLine("Valores/int");
        Console.WriteLine("------------------------");

        int x, somaPares = 0;

        x = int.Parse(Console.ReadLine());

        while ( x != 0 ) {

            if ( x % 2 == 0 ) {
                int contador = 5;
                while(contador > 0){
                    somaPares += x;
                    x += 2;
                    contador--;
                }
                Console.WriteLine(somaPares);
                somaPares = 0;
            } else if ( x % 2 != 0 ) {
                x += 1;
                int contador = 5;
                while(contador > 0){
                    somaPares += x;
                    x += 2;
                    contador--;
                }
                Console.WriteLine(somaPares);
                somaPares = 0;
            }

            x = int.Parse(Console.ReadLine());
            
        }

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};
```

- ex1118

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1118");
        Console.WriteLine("Várias Notas Com Validação");
        Console.WriteLine("2 notas/reais");
        Console.WriteLine("------------------------");

        double notaA, notaB, media;
        int X = 1;

        while(X != 2){
            notaA = double.Parse(Console.ReadLine());

            while(notaA < 0.0 || notaA > 10.0){
                Console.WriteLine("nota invalida");
                notaA = double.Parse(Console.ReadLine());
            }

            notaB = double.Parse(Console.ReadLine());

            while(notaB < 0.0 || notaB > 10.0){
                Console.WriteLine("nota invalida");
                notaB = double.Parse(Console.ReadLine());
            }

            media = (notaA + notaB) / 2.0;

            Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("novo calculo (1-sim 2-nao)");
            X = int.Parse(Console.ReadLine());

            while( X != 1 && X != 2){
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                X = int.Parse(Console.ReadLine());
            } 

        }

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};
```

- ex1131

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1131");
        Console.WriteLine("Grenais");
        Console.WriteLine("gols/int");
        Console.WriteLine("------------------------");

        int golsInter, golsGremio, grenais = 0, vitoriasInter = 0, vitoriasGremio = 0, empate = 0, x = 1;
        string vencedor = "";

        while(x != 2){
            string[] v = Console.ReadLine().Split(' ');
            golsInter = int.Parse(v[0]);
            golsGremio = int.Parse(v[1]);

            grenais++;

            if(golsInter == golsGremio){
                empate++;
            } else if(golsInter > golsGremio){
                vitoriasInter++;
            } else {
                vitoriasGremio++;
            }

            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            x = int.Parse(Console.ReadLine());
        }

        if(vitoriasInter > vitoriasGremio){
            vencedor = "Inter venceu mais";
        } else if(vitoriasGremio > vitoriasInter){
            vencedor = "Gremio venceu mais";
        } else {
            vencedor = "Nao houve vencedor";
        }

        Console.WriteLine(grenais + " grenais");
        Console.WriteLine("Inter:" + vitoriasInter);
        Console.WriteLine("Gremio:" + vitoriasGremio);
        Console.WriteLine("Empates:" + empate);
        Console.WriteLine(vencedor);

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};
```

## Aula 46 - Estrutura repetitiva para

É uma estrutura de controle que repete um bloco de comandos para um certo intervalo de valores.

### Quando usar:

Quando se sabe previamente a quantidade de repetições, ou o intervalo de valores.

Por exemplo: Fazer um programa que lê um valor inteiro N e depois N números inteiros. Ao final, mostra a soma dos N números lidos

| Entrada                | Saída |
| ---------------------- | ----- |
| 3<br />5<br />2<br />4 | 11    |

### Sintaxe:

```c#
for ( início ; condição ; incremento) {
	comando 1
	comando 2
}
```

- __início__: Executa somente na primeira vez
- __condição__: 
  - V - executa e volta
  - F - pula fora
- __incremento__: Executa toda vez depois de voltar

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("class46_estruturaRepetitivaPara");
        Console.WriteLine("------------------------");

        int soma = 0;
        int N = int.Parse(Console.ReadLine());

        for(int contador = 0; contador < N; contador++){
            int x = int.Parse(Console.ReadLine());
            soma += x;
        }

        Console.WriteLine(soma);

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};
```

### Importante

Perceba que a estrutura "para" é ótima para se fazer uma repetição baseada em uma CONTAGEM:

```c#
for (int i=0; i<5; i++) {
	Console.WriteLine("Valor de i: " + i);
}
```

Resultado na tela:

```shell
Valor de i: 0
Valor de i: 1
Valor de i: 2
Valor de i: 3
Valor de i: 4
```

### Contagem regressiva

```c#
for (int i=4; i>=0; i--) {
	Console.WriteLine("Valor de i: " + i);
}
```

Resultado na tela:

```shell
Valor de i: 4
Valor de i: 3
Valor de i: 2
Valor de i: 1
Valor de i: 0
```



## Aula 47 - Teste de mesa com estrutura para

## Aula 48 - Exercícios propostos PARTE 3 - testes de mesa com estrutura para

## Aula 49 - Exercício resolvido 03

- ex1078

```c#
using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1078");
        Console.WriteLine("Tabuada");
        Console.WriteLine("1 valor/int");
        Console.WriteLine("------------------------");

        int n = int.Parse(Console.ReadLine());

        for(int i = 1; i <= 10; i++){
            Console.WriteLine(i + " x " + n + " = " + i * n);
        }

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};
```

## Aula 50 - Exercício resolvido 04

- ex1071

```c#
```

















