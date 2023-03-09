# -*- coding: utf-8 -*-
print("AULA 28 - TRATAMENTO DE EXCEÇÕES")
a = 2
b = 0

try: # tentar
	print(a/b)
except: # exceto
	print("Não é permitido divisão por zero")

print(a/a)
