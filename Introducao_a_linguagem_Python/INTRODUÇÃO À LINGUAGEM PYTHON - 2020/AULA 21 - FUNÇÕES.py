# -*- coding: utf-8 -*-
print("AULA 21 - FUNÇÕES")
"""
Permitem a modularização do código
	* funções:
		- Blocos de códigos;
		- Executados apenas quando chamadas

Funções - Em Python são definidas pela palavra reservada def
* definição
def NOME(PARÂMETROS):
	COMADOS
* chamada
NOME(ARGUMENTOS)

"""
def soma(x, y):
	return x + y
def multiplicacao(x, y):
	return x * y
s = soma(2, 3) # x = 2 e y = 3
m = multiplicacao(5, 3)

print(s)
print(m)
print(soma(s, m))


