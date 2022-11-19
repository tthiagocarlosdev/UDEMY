# -*- coding: utf-8 -*-
print("AULA 19 - STRINGS - PARTE 1")
"""
String é um tipo de dados em que se armazena coleções de caracteres (texto)
São declaradas entr aspas
 var1 = 1 (numeral)
 var2 = "1" (string)
 """
print("CONCATENAÇÃO")
var1 = "Thiago"
var2 = "Carlos"
print(var1)
print(var2)
concatenar = var1 + var2
print(concatenar)
concatenar2 = var1 + " " + var2
print(concatenar2)

print("TAMANHO DE UMA STRING - FUNÇÃO len")
tamanho_concatenar = len(concatenar) # conta o número de caractéres dentro da string
print(tamanho_concatenar)
tamanho_concatenar2 = len(concatenar2) # a função também conta a quantidade de espaços
print(tamanho_concatenar2)
print("NAVEGAÇÃO PELO ÍNDICE")
# usa-se o colchete para dentro deste colocar a posição que se deseja encontrar.
print(concatenar)
ordem1 = concatenar[0] # a contagem sempre inicia pelo valor 0
ordem2 = concatenar[1]
ordem3 = concatenar[2]
print(ordem1)
print(ordem2)
print(ordem3)
print(var1[3])
print("IMPRIMINDO UMA PARTE DE UMA STRING")
print(concatenar[0:6])
print(concatenar[6:])

