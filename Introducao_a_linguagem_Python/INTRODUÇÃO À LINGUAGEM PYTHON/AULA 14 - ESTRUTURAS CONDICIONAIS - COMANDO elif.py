# -*- coding: utf-8 -*-
print("AULA 14 - ESTRUTURAS CONDICIONAIS - COMANDO elif")
"""
Caso haja necessidade de mais condições entre o if e o else, podemos usar o comando elif
* Sintaxe
if condição:
	execute_esta_linha
elif condição:
	execute_esta_linha
else:
	execute_esta_linha 
"""
x = 1
y = 2

if x == y:
	print("números iguais")
elif x < y:
	print("x menor que y")
elif y > x:
	print("y maior que x")
else:
	print("números diferentes")
