# -*- coding: utf-8 -*-
print("AULA 36 - PYTHON AVANÇADO - FUNÇÃO REDUCE")
# recebe uma lista e retorna um único valor para esta lista
from functools import reduce

def soma(x, y):
	return x + y

lista = [1, 3, 5, 10, 20]

soma = reduce(soma, lista)
print(soma)
