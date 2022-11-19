# -*- coding: utf-8 -*-
# pega uma função e aplica a todos os elementos de uma lista
print("AULA 36 - PYTHON AVANÇADO - FUNÇÃO MAP")
print(" ")
def dobro(x):
	return x*2
def triplo(x):
	return x*3

valor = [1, 2, 3, 4, 5]
print("MINHA LISTA")
print(valor)
print("VALOR DOBRADO")
valor_dobrado = map(dobro, valor) # map(função que eu quero chamar,  lista que vou aplicar)
valor_dobrado = list(valor_dobrado)
print(valor_dobrado)
print("VALOR TRIPLICADO")
valor_triplo = map(triplo, valor)
valor_triplo = list(valor_triplo)
print(valor_triplo)
