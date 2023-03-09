# -*- coding: utf-8 -*-
print("AULA 34 - PYTHON AVANÇADO - FUNÇÃO ENUMERATE")
# obter o índice de cada elemento que está na lista

# forma não pythonica!
lista = ["abacate", "bola", "cachorro"]

for i in range(len(lista)):
	print(i, lista[i])

print(" ")
print("usando o enumerate")
# forma pythonica

for i, nome in enumerate(lista):
	print(i, nome)

