# -*- coding: utf-8 -*-
print("AULA 26 - DICIONÁRIOS")
"""
Dicionários são listas de associações composta por:
	- uma chave;
	- um valor correspondente.

	dicionario = {'CHAVE':'VALOR'}
"""
meu_dicionario = {"A":"AMEIXA", "B":"BOLA", "C":"CACHORRO"}

print(meu_dicionario["A"])
print(meu_dicionario["B"])
print(meu_dicionario["C"])
print(meu_dicionario)
# navegação pelo meu dicionário

for chave in meu_dicionario:
	print(chave+":"+((meu_dicionario)[chave]))
# tupla - conjunto de dados imutáveis
for chave in meu_dicionario.items(): # retorna o dicionário em tupla
	print(chave)
for chave in meu_dicionario.values(): # retorna apenas os valores do dicionário
	print(chave)
for chave in meu_dicionario.keys(): # retorna apenas os valores das chaves
	print(chave)
