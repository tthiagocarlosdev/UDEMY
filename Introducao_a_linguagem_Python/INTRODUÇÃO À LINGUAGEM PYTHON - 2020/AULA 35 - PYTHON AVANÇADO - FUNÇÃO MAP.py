# -*- coding: utf-8 -*-
print("AULA 35 - PYTHON AVANÇADO - FUNÇÃO MAP")
"""
pega uma função e aplica a todos os elementos de uma lista
recebe dois argumentos: 1º a função que quer chamar, 2º a lista que quer aplicar.
sintaxe:
		map(função, lista)
"""
def dobro(x):
	return x*2

valor = [1, 2, 3, 4, 5]

valor_dobrado = map(dobro, valor)

"""
for v in valor_dobrado:
	print(v)
print(" ou converter em lista")
"""

valor_dobrado = list(valor_dobrado)
print(valor_dobrado)

