# -*- coding: utf-8 -*-
print("AULA 22 - ARQUIVOS")
"""
Abrindo arquivos:
- Função open
- variavel = open(nome, modo)
- Tipos de modo:
	r - somente leitura
	w - escrita (caso o arquivo já exista, ele será apagado e um novo arquivo vazio será criado)
	a - leitura e escrita (adiciona o novo conteúdo ao fim do arquivo)
	r+ - leitura e escrita
	w+ - escrita (o modo w+, assim como o w, também apaga o conteúdo anteior do arquivo)
	a+ - leitura e escrita (abre o arquivo para atualização)
- Lendo arquivos:
	- read()
		* Lê arquivo inteiro
	- readline()
		* Lê uma linha
	- readlines()
		* Lê arquivo e o armazena em uma lista
"""
arquivo = open("arquivo.txt")

print(arquivo) # quando print direto ele não abre o conteúdo do arquivo, para isto tem que se usar a função de leitura
linhas = arquivo.readlines() # coloca cada linha do arquivo dentro de uma lista
print(linhas) 
for linha in linhas:
	print(linha)
arquivo = open("arquivo.txt")
print("read")
texto_completo = arquivo.read()
print(texto_completo)
print("LINHA")
arquivo = open("arquivo.txt")
linha = arquivo.readline()
print(linha)
print("CRIANDO ARQUIVOS")
w = open("arquivo2.txt", "w")
w.write("Esse é meu arquivo")
w.close()

y = open("arquivo.txt", "a")
y.write("Esse é meu arquivo\n")
y.close()