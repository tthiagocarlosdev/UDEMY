# -*- coding: utf-8 -*-
# concatena listas diferentes
# compacta duas ou mais listas para que possam ser analisadas ao mesmo tempo em um laço for.
print("AULA 37 - PYTHON AVANÇADO - FUNÇÃO ZIP")
print(" ")
lista1 = [1, 2, 3, 4, 5]
lista2 = ["abacate", "bola", "casa", "diamente", "esfera"]
lista3 = ["R$2,00", "R$150,00","R$10.000,00", "R$1.000.000,00", "R$10,00"]
print("DUAS LISTAS")
for numero, nome in zip(lista1, lista2):
	print(numero, nome)
print("TRÊS LISTAS")
for numero, nome, valor in zip(lista1, lista2, lista3):
	print(numero, nome, valor)
