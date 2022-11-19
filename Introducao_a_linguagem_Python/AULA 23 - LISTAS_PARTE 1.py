# -*- coding: utf-8 -*-
print("AULA 23 - LISTAS_PARTE 1")
minha_lista = ["abacaxi", "melancia", "abacate"]
minha_lista2 = [1, 2, 3, 4, 5]
minha_lista3 = ["abacaxi, 1, 9.89, True"]
minha_lista4 = []

print(minha_lista)
print(minha_lista2)
print(minha_lista3)
print(minha_lista[2]) #imprime o string de acordo com a ordem
for item in minha_lista: # imprime item por item da lista por linha
	print(item)
for item in minha_lista2:
	print(item)
print(" ")
tamanho = len(minha_lista2) # comando "len" informa o tamanho da lista
print(tamanho)
print(" ")
minha_lista.append("limão") # comando "append" acrescenta item a lista

print(minha_lista)
print(" ")
if 2 in minha_lista2: # [if "x" in] verifica se o elemento existe na lista
	print("Existe número dois na lista")

print(" ")
del minha_lista[2:] # "del" remove elemento a partir da ordem que foi pedida
print(minha_lista)

print(" ")
minha_lista4.append(minha_lista + minha_lista3 + minha_lista2)
print(minha_lista4)