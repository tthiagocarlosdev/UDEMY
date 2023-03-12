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

```python
# Operadores relacionais
x = 2
y = 3
print(x == y)

x = 3
y = 3
print(x == y)

x = 2
y = 3
print(x < y)

x = 2
y = 3
print(x > y)

x = 2
y = 3
soma = x + y
print(soma == x)
print(soma == y)
print(soma >= y)
```

```shell
False
True
True
False
False
False
True
```



## Aula 11 - Operadores relacionais

### Operadores lógicos

| Operador |                 Operação                 |
| :------: | :--------------------------------------: |
|   AND    |     Duas condições sejam verdadeiras     |
|    OR    | Pelos menos uma condição seja verdadeira |
|   NOT    |             Inverte o valor              |

Comandos condicionais

```python
# class11_operadores_relacionais
x = 3
y = 3
z = 3
soma = x + y
print(x == y and x == z)

x = 3
y = 3
z = 4
soma = x + y
print(x == y and x == z)

x = 3
y = 3
z = 4
soma = x + y
print(x == y or x == z)

x = 3
y = 3
z = 4
soma = x + y
print(x == y or x == z and z == y)
```

```shell
True
False
True
True
```



## Aula 12 - Estruturas condicionais

### Comando condicional *if*

- Realiza testes condicionais
- Executa um bloco __SE__ uma determinada condição for atendida
- Avalia se a condição é verdadeira ou não

### Sintaxe

```tex
if condição:
	execute_esta_linha
```

### Bloco

- Trecho de código que depende de outro trecho
- Observe que a linha 7 não é executada

```python
# class12_estruturas_condicionais
x = 1
y = 10000000000

if x > y:
	print("x é maior que y")

if y > x:
	print("y é maior que x")
```

```shell
y é maior que x
```

### Indentação

- Python blocos são definidos pelo espaçamento da linha
- Pode ser feito com espaços ou tabulações
- Tecla TAB



## Aula 13 - Estruturas condicionais (comando else)

### Comando *else*

- É executado caso a condição do comando *if* não seja atendida

```python
# aula_13__estruturas_condicionais_comando_else
x = 1
y = 2

if x > y:
	print("x maior que y")
else:
	print("x não é maior que y")
```

```shell
x não é maior que y
```



## Aula 14 - Estruturas condicionais (comando elif)

### Comando *else*

- É executado caso a condição do comando *if* não seja atendida

### Sintaxe

```tex
if condição:
	execute_esta_linha
else:
	caso_if_falhe_execute_esta_linha
```

### Comando *elif*

- Caso haja necessidade de mais condições entre if e o else

### Sintaxe

```tex
if condição:
	execute_esta_linha
elif condição:
	execute_esta_linha
else:
	execute_esta_linha
```

```python
# aula_14__estruturas_condicionais_comando_elif
x = 1
y = 2

if x == y:
	print("numeros iguais")
elif y > x:
	print("y maior que x")
else:
	print("numeros diferentes")
```

```shell
y maior que x
```



## Aula 15 - Estruturas de repetição (comando while)

### Laços de repetição

- Estruturas de repetição
- Iteradores 
  - iterar == repetir
- Repetem um trecho do código
  - enquanto uma condição avaliada for verdadeira
  - durante uma pré-determinada condição
- *while* (enquanto)

```python
# aula_15__estruturas_de_repeticao_comando_while
x = 1

while x < 10:
	print(x)
	x += 1
```

```sh
1
2
3
4
5
6
7
8
9
```



## Aula 16 - Estruturas de repetição (comando for)

### Laços de repetição

- *for* (para)

```python
# aula_16__estruturas_de_repeticao_comando_for
lista1 = [1,2,3,4,5]
lista2 = ["ola", "mundo", "!"]
lista3 = [0, "ola", "biscoito", "bolacha", 9.99, True]

for i in lista1:
	print(i)
print("--------------")
for i in lista2:
	print(i)
print("--------------")
for i in lista3:
	print(i)
```

```shell
1
2
3
4
5
--------------
ola
mundo
!
--------------
0
ola
biscoito
bolacha
9.99
True
```



## Aula 17 - Estruturas de repetição (comandos for e range)

```python
# aula_17__estruturas_de_repeticao_comandos_for_e_range
for i in range(10):
	print(i)
print("--------------")
for i in range(10, 20):
	print(i)
print("--------------")
for i in range(10, 20, 2):
	print(i)
```

```shell
0
1
2
3
4
5
6
7
8
9
--------------
10
11
12
13
14
15
16
17
18
19
--------------
10
12
14
16
18
```



## Aula 18 - Objetos

> #### Em Python, tudo é objeto!

Convencionou-se dizer que em Python tudo é um objeto. De fato, Python é uma linguagem orientada a objetos.

Objetos são instâncias de classes. Por exemplo, quando você cria uma variável com uma *string*, você está criando um objeto do tipo *string*.

Objetos possuem **atributos** (características) e **métodos** (ações que podem ser aplicadas).

Observe como verificar atributos e métodos a um objeto:

- #### objeto.atributo

- #### objeto.método( )



## Aula 19 - Strings parte 1

- *Strings* é um tipo de dados em que se armazena coleções de caracteres (texto)
- São declaradas entre aspas

```python
var1 = 1
var2 = "1"
```

- Nesse exemplo var1 é um numeral, enquanto var2 é uma *string*

### Concatenação de *strings*

```python
# aula_19__strings_parte_1
a = "Diego"
b = "Mariano"

concatenar = a + " " + b
print(concatenar)
```

```shell
Diego Mariano
```

### Verificando o tamanho de uma *string*

```python
# aula_19__strings_parte_1
a = "Diego"
b = "Mariano"

concatenar = a + " " + b
print(concatenar)

# tamanho de uma string
print("--------------")
tamanho = len(concatenar)
print(tamanho)
```

```shell
Diego Mariano
--------------
13
```

### Navegando pelo índice

- A contagem inicia do zero

```python
# aula_19__strings_parte_1
a = "Diego"
b = "Mariano"

concatenar = a + " " + b
print(concatenar)

# tamanho de uma string
print("--------------")
tamanho = len(concatenar)
print(tamanho)

# navegando pelo índice
print("--------------")
print(a[0])
print(a[1])
print(a[2])
print(a[3])
print(a[4])
```

```shell
Diego Mariano
--------------
13
--------------
D
i
e
g
o
```

### Imprimindo parte de uma *string*

```python
# aula_19__strings_parte_1
a = "Diego"
b = "Mariano"

concatenar = a + " " + b
print(concatenar)

# tamanho de uma string
print("--------------")
tamanho = len(concatenar)
print(tamanho)

# navegando pelo índice
print("--------------")
print(a[0])
print(a[1])
print(a[2])
print(a[3])
print(a[4])

# imprimindo uma parte da string
print("--------------")
print(concatenar[0:])
print(concatenar[1:])
print(concatenar[2:9])
print(concatenar[0:4])
```

```shell
Diego Mariano
--------------
13
--------------
D
i
e
g
o
--------------
Diego Mariano
iego Mariano
ego Mar
Dieg
```

## Aula 20 - Strings parte 2

- Em Python, *strings* são objetos
- Pode-se aplicar métodos a *strings*

```pseudocode
string = string.metodo()
```

### Alterando a caixa: minúsculo/maiúsculo

```python
# aula_20__strings_parte_2
a = "Diego"
b = "Mariano"

# Alterando a caixa: minúsculo
concatenar = a + " " + b
print(concatenar)
print(concatenar.lower())
print(concatenar.upper())
print(concatenar)
```

```shell
Diego Mariano
diego mariano
DIEGO MARIANO
Diego Mariano
```

### Removendo espaços no começo e no fim das *string*

```python
# aula_20_strings_parte_2
a = "Diego"
b = "Mariano"

concatenar = a + " " + b + "\n"

print(concatenar)

# Alterando a caixa: minúsculo/maiúsculo
print(concatenar.lower())
print(concatenar.upper())
print(concatenar)

# Removendo espaços
print(concatenar.strip())
```

```shell
Diego Mariano

diego mariano

DIEGO MARIANO

Diego Mariano

Diego Mariano
[Finished in 21ms]
```

### Convertendo uma string em uma lista

```python
# Convertendo uma string em uma lista
print("--------------")
minha_string = "O rato roeu a roupa do rei de Roma"
print(minha_string)
minha_lista = minha_string.split(" ")
print(minha_lista)
minha_lista_r = minha_string.split("r")
print(minha_lista_r)
```

```shell
O rato roeu a roupa do rei de Roma
['O', 'rato', 'roeu', 'a', 'roupa', 'do', 'rei', 'de', 'Roma']
['O ', 'ato ', 'oeu a ', 'oupa do ', 'ei de Roma']
```

### Buscando *substrings*

Quando não encontra a string retorna o valor -1

```python
busca = minha_string.find("rei")
print(busca)
print(minha_string[busca:])
```

```shell
23
rei de Roma
```

### Substituir partes de uma *string*

```python
print("--------------")
print(minha_string.replace("o rei", "a rainha"))
```

```shell
O rato roeu a roupa da rainha de Roma
```



## Aula 21 - Funções





























