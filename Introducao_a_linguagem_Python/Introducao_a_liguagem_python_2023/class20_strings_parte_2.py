# aula_20_strings_parte_2
a = "Diego"
b = "Mariano"

concatenar = a + " " + b + "\n"

print(concatenar)

# Alterando a caixa: minúsculo/maiúsculo
print(concatenar.lower())
print(concatenar.upper())
print(concatenar)

# Removendo espaços
print("--------------")
print(concatenar.strip())

# Convertendo uma string em uma lista
print("--------------")
minha_string = "O rato roeu a roupa do rei de Roma"
print(minha_string)
minha_lista = minha_string.split(" ")
print(minha_lista)
minha_lista_r = minha_string.split("r")
print(minha_lista_r)

# Buscando *substrings*
print("--------------")
busca = minha_string.find("rei")
print(busca)
print(minha_string[busca:])

# Substituir partes de uma *string*
print("--------------")
print(minha_string.replace("o rei", "a rainha"))