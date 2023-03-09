# **Introdução à linguagem Python**

## Aula 01 - Bem-vindo

> #### Olá, seja bem-vindo ao curso de **Introdução à linguagem Python**.

Neste curso você aprenderá os fundamentos da programação usando Python que, diga-se de passagem, é uma linguagem fantástica tanto para quem está começando a programar quanto para quem já é *expert* na área.

Gostaria de começar este curso me apresentando:

Meu nome é Diego e qualquer dúvida estou à disposição ;)

Para saber mais peço que entre na minha página do Facebook:

https://facebook.com/professordiegomariano



Abraços.



\---

**Sobre o instrutor**

![img](https://img-c.udemycdn.com/redactor/raw/2018-11-14_14-40-16-475122358c7aa729afb160864354bc1b.png)

> #### **Dr. Diego Mariano**
>
> #### Mestre, doutor e pesquisador

Analista de sistemas, pesquisador e professor de cursos EAD em programação, banco de dados e bioinformática (alguns gratuitos).

Atualmente cursa *Professional degree* em *Data Science* pela **Universidade de Harvard**.

Possui ainda:

\- **Mestrado e doutorado** em Bioinformática pela UFMG;

\- **Bacharelado** em Sistemas de Informação;

**-** Formação **técnica** em Redes Computacionais.

**Website**: [http://diegomariano.com](http://diegomariano.com/)



## Aula 02 - Introdução

- Alto nível
- Dinâmica
- Fortemente tipada
- Orientada a objetos
- Indentação define blocos

Página oficial : http://www.python.org

Criador: Guido van Rossum

Surgiu em: 1991

Mantido por: Python Software Foundation

- Alternativa à linguagem C
- Grupo de comédia: *Monty __Python'__s Flying Circus*
  - Originalmente chamava-se B
- Editora O'Reilly
  - *Programming Python*
  - Animal píton

### Como funciona?

Desenvolve o script

Chama o interpretador python

Python compila e exibe os resultados na tela

### Como instalar

- Windows
  - https://www.python.org/downlods/
- Linux e MacOs
  - Já vem instalado

### Primeiros passos

```python
print("Ola mundo") 
```

```shell
Ola mundo
```

## Aula 03 - Instalando Python

Instale dois programas no seu computador:

1. **Python**
2. **Sublime text**

> *Caso não consiga instalar, NÃO tem problema, pois você poderá fazer os exercícios de programação online.*



Abaixo uma descrição detalhada de como instalar os programas:



**1. Python**

Se você usa Windows, acesse:

https://www.python.org/downloads/windows/

E baixe a última versão do Python 3 disponível (por exemplo, atualmente a versão mais recente é o Python 3.7.0).

![img](https://img-c.udemycdn.com/redactor/raw/2018-09-10_20-58-04-a07e62da0303ec2f572edc1372848383.jpg)

(Linux e Mac já possuem Python instalado)



> **RESOLVENDO PROBLEMAS NA INSTALAÇÃO**
>
> Caso após instalar Python, você receba uma mensagem informando que "o comando python não foi reconhecido" ou algo assim, verifique se o caminho (PATH) do Python está correto.
>
> *Veja este tutorial:*
>
> https://python.org.br/instalacao-windows/

**2. Sublime text**

Acesse https://www.sublimetext.com/

E faça o download da mais recente versão do Sublime text. Você pode usar o sublime text gratuitamente, mas ele às vezes pedirá que faça um registro e compre o produto, **mas você não é obrigado**.

> Você pode usá-lo gratuitamente por quanto tempo quiser.

![img](https://img-c.udemycdn.com/redactor/raw/2018-09-10_21-01-48-d2564d7705c7a3d3b108d5439d7c35ed.jpg)



**Rodando scripts no sublime:**

Crie um novo arquivo e o salve com o nome "script.py". Escreva no arquivo:

```
print("ola mundo")
```

E salve. Agora pressione CTRL + B para chamar o Python para interpretar o script.

A primeira vez que você fizer isso, aparecerá uma quadrado branco escrito "Python" (é necessário ter instalado o Python antes). Pressione enter. O resultado aparecerá embaixo da tela.

Das próximas vezes será necessário apenas pressionar CTRL+B.

![img](https://img-c.udemycdn.com/redactor/raw/2018-09-10_21-06-07-8f822fa821a664c2690e20812e9dd591.jpg)



## Aula 04 - Instalando Python (prática)

## Aula 05 - Resolvendo problemas na instalação do Python

> #### Seu Python não funciona corretamente?

Se você tentou executar a mensagem de "hello world" e o Sublime emitiu algum dos erros abaixo:

```
# ERRO 1[Finished in 0.0s] # ERRO 2'python' n�o � reconhecido como um comando internoou externo, um programa oper�vel ou um arquivo em lotes.[Finished in 0.0s with exit code 1]
```

**Há duas possibilidades para resolver esse problema:**

> 1) Python não está instalado corretamente (o PATH não está configurado).

Para resolver isso, reinstale seguindo o tutorial oficial:

https://python.org.br/instalacao-windows/



Não se esqueça de marcar a opção do PATH

![img](https://i.udemycdn.com/redactor/raw/2019-10-18_20-15-20-d76b4ac6bf3ed9abb41fa7007f7ae5b2.png)

*Dica do [Rui Filipe Cardoso Lopes](https://www.udemy.com/user/rui-filipe-cardoso-lopes/).



#### 2) Configure o Sublime para executar um script em Python

No sublime text, salve o arquivo com a extensão ".py" (por exemplo, hello.py). A seguir vá no menu superior e clique em:

```
TOOLS > BUILD SYSTEM > PYTHON
```



## Aula 06 - Google Colab (ambiente para desenvolvimento alternativo)

https://colab.research.google.com/



## Aula 07 - Comentários

- Organização e explicação do código

- Não são processados

- Começa com:

  - ```tex
    # cerquilha
    ```

```python
# -*- coding: utf-8 -*-
# Isto eh um comentario
print("Olá mundo!")

# outro comentario
print("Outra Mensagem")

"""
comentarios
de muitas
linhas
"""
print("Mensagem")
```



## Aula 08 - Operações matemáticas

```python
print(2 + 2)
print(2 - 2)
print(2 / 2)
print(2 * 2)
print(2 ** 3)
print(10 % 3)
```

```shell
4
0
1.0
4
8
1
```



## Aula 09 - Variáveis

- Permite o armazenamento de informação na memória

### Sintaxe

```tex
Nome_da_variavel = valor
```

```python
# Aula 09 - Variáveis
minha_variavel = "Olá mundo!"

print(minha_variavel)
print(minha_variavel)
print(minha_variavel)
```

```shell
Olá mundo!
Olá mundo!
Olá mundo!
```

- __Nome da variável__ não deve ter caracteres especiais e nem espaços
  - É *case sensitive*:
    - Nome_da_variavel
    - nome_da_variavel
- [ = ] operador de atribuição
- __Valor__: define o tipo da variável

### Tipos de dados

- Numérico inteiro
  - 47
- Numérico Flutuante
  - 12.89
- Textual (*string*)
  - "Olá mundo"
- Booleana
  - *True* (verdadeiro) ou *False* (falso)

```python
# Aula 09 - Variáveis
minha_variavel = "Olá mundo!"

print(minha_variavel)
print(minha_variavel)
print(minha_variavel)

var1 = 1 # variável inteira
var2 = 1.1 # variável float
var3 = "Eu sou uma string" # variável string
var4 = True # verdadeiro
var5 = False # falso

print(var1)
print(var2)
print(var3)
print(var4)
print(var5)
```

```shell
Olá mundo!
Olá mundo!
Olá mundo!
1
1.1
Eu sou uma string
True
False
```



## Aula 10 - Operadores lógicos e relacionais

- ### Operadores Matemáticos

| Operador |   Operação    |
| :------: | :-----------: |
|    +     |    Adição     |
|    -     |   Subtração   |
|    *     | Multiplicação |
|    /     |    Divisão    |
|    **    | Exponenciação |
|    %     |    Módulo     |

- ### Operador de atribuição

  - =
  - x = 10
  - Se lê "x recebe o valor 10"

- ### Operadores relacionais

| Operador |  Operação   |
| :------: | :---------: |
|    ==    |    Igual    |
|    !=    |  Diferente  |
|    >     |    Maior    |
|    >     |    Menor    |
|    >=    | Maior igual |
|    <=    | Menor igual |















