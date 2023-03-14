# Aula 22 - Arquivos
arquivo = open("meu_arquivo.txt")
linhas = arquivo.readlines()
texto_completo = arquivo.read()

print(arquivo)
print("--------------")
print(linhas)
print("--------------")
for linha in linhas:
	print(linha)
print("--------------")
print(texto_completo)
print("--------------")

# w = open("arquivo2.txt", "w")
# w.write("Esse eh o meu arquivo")
# w.close()

# z = open("meu_arquivo.txt", "w")
# z.write("Esse é o meu arquivo")
# z.close()

n = open("meu_arquivo.txt", "a")
n.write("Esse é o meu arquivo\n")
n.close()