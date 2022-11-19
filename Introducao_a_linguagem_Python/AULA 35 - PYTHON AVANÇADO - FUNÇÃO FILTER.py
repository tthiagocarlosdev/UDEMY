# -*- coding: utf-8 -*-
# Pega uma determinada lista e vai filtrar uma determinada condição para que seja adicionada em outra lista.
# Função usada para filtrar elementos de uma lista
print("AULA 35 - PYTHON AVANÇADO - FUNÇÃO FILTER")
print(" ")

def pares(i):
	if i % 2 ==0:
		return i
def impares(i):
	if i % 2 ==1:
		return i
lista = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]

lista_pares = filter(pares, lista)
print(list(lista_pares))
print(" ")
lista_impares = filter(impares, lista)
print(list(lista_impares))
