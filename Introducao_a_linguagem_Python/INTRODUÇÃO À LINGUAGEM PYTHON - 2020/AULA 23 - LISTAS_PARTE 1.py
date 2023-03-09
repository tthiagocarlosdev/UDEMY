# -*- coding: utf-8 -*-
print("AULA 23 - LISTAS_PARTE 1")
"""
LISTAS
- representam conjuntos de dados;
- podem ser:
	- numéricas: [1, 2, 3, 4, 5]
	- Strings: ["bolas", "sapato", "chuva"]
"""
minha_lista = ["abacaxi", "melancia", "abacate"]
minha_lista2 = [1, 2, 3, 4, 5]
minha_lista3 = ["abacaxi", 2, 9.89, True]

print(minha_lista)
print(minha_lista2)
print(minha_lista3)
print(minha_lista[2]) # exibe o elemento da lista de acordo com sua posição

for item in minha_lista:
	print(item)

tamanho = len(minha_lista) # determina o tamanho da minha lista

print(tamanho)

minha_lista.append("limão") # adiciona elemento a minha lista
print(minha_lista)

# verificando se um elemento pertence a uma lista

if "abacaxi" in minha_lista:
	print("abacaxi pertence a minha lista")

if 7 in minha_lista2:
	print("O numeral pertence a lista")
else:
	print("O numeral não pertence a lista")

# Removendo elementos

del minha_lista[3:] # remoção do elemento 3 até o final, no caso, removeu "limão" de minha_lista

print(minha_lista)

del minha_lista2[:] # apaga a lista inteira

print(minha_lista2)
