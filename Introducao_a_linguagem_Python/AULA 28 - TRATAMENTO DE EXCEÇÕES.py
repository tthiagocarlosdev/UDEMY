# -*- coding: utf-8 -*-
print("AULA 28 - TRATAMENTO DE EXCEÇÕES")
print(" ")
a = 2
b = 0

try: # o programa irá tentar ralizar a operação
	print (a/b)
except:
	print("Não é permitida a divisão por 0")
print(" ")
print(a/a)
