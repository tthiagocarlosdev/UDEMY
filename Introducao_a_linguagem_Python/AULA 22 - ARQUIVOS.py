# -*- coding: utf-8 -*-
arquivo = open("arquivo.txt")

print("LÊ ARQUIVO E O ARMAZENA EM UMA LISTA")
linhas = arquivo.readlines()

print(linhas)

print(" ")
print("IMPRIME LINHA POR LINHA")
for linha in linhas:
	print(linha)

print(" ")
print ("LÊ ARQUIVO INTEIRO")
arquivo1 = open("arquivo.txt") # arquivo1 == arquivo
texto_completo = arquivo1.read()

print(texto_completo)

w = open("arquivo.txt", "a") 

w.write("Esse é meu arquivo\n")

w.close()