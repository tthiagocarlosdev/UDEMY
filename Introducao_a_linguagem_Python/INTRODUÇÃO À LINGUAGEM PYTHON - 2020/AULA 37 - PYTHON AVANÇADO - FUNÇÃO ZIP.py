# -*- coding: utf-8 -*-
print("AULA 37 - PYTHON AVANÇADO - FUNÇÃO ZIP")
# concatena listas, compila duas ou mais listas durante um laço.

lista1 = [1, 2, 3, 4, 5]
lista2 = ["abacate", "bola", "casa", "dado", "eletrodoméstico"]
lista3 = ["R$5,00", "R$10,00", "R$100.000,00", "R$2,00", "R$100,00",]

for numero, nome, valor in zip(lista1, lista2, lista3):
	print(numero, nome, valor)
