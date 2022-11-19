# -*- coding: utf-8 -*-
print("AULA 33 - PYTHON AVANÇADO - LIST COMPREHENSION")
# Compreensão de lista

x = [1, 2, 3, 4, 5]
y = [] # quero adicionar em "y" cada elemento de "x" elevado ao quadrado.

for e in x:
	y.append(e**2)

print(x)
print(y)

"""
usando list comprehension
sintaxe:

		y = [valor_a_adicionar laço condição]
"""
x = [6, 7, 8, 9, 10]
y = [e**2 for e in x]
# valor_a_adicionar = e**2
# laço = for e in x
# condição = neste exemplo não tem.
print(x)
print(y)

# quero adicionar apenas os números ímparares de z
z = [1, 2, 3, 4, 5]
w = [e**2 for e in z]
k = [e for e in z if e % 2 == 1] # condição - "if e % 2 == 1"
print(k)
