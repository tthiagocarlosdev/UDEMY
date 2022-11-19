# -*- coding: utf-8 -*-
print("AULA 27 - NÚMEROS ALEATÓRIOS")
import random

numero = random.randint(0, 10) # retorna um número aleatório
print(numero)
# random.seed(1) - sempre retornará o mesmo resultado

lista = [3, 6, 9]
a = random.choice(lista) # escolhe um número de uma determinada lista
print(a)
