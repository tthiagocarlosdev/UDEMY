# -*- coding: utf-8 -*-
print("AULA 34 - PYTHON AVANÇADO - FUNÇÃO ENUMERATE")
print(" ")
lista = ["abacate", "bola", "cachorro"]
# quero obter o nome de cada item da lista e o seu respectivo índice
for i in lista:
	print(i)
print(" ")
for i in range(len(lista)):
	print(i, lista[i])
print(" ")
print("com a função enumerate")
for i, nome in enumerate(lista):
	print(i, nome)
