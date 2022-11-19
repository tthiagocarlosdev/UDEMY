# -*- coding: utf-8 -*-
print("AULA 26 - DICIONÁRIOS")
print(" ")
meu_dicionário = {"A":"AMEIXA", "B":"BOLA", "C":"CACHORRO"}

print(meu_dicionário["A"])
print(meu_dicionário["B"])
print(meu_dicionário["C"])
print(meu_dicionário)
print(" ")
print("NAVEGAÇÃO DENTRO DO DICIONÁRIO")
for chave in meu_dicionário:
	print(chave+"-"+meu_dicionário[chave])
print(" ")
for i in meu_dicionário.items(): # converte o dicioário em uma tupla
	print(i)
print(" ")
for i in meu_dicionário.values(): # retorna apenas o valores
	print(i)
print(" ")
for i in meu_dicionário.keys(): # retorna apenas as chaves 
	print(i)