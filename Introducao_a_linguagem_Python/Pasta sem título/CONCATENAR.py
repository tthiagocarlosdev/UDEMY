# -*- coding: utf-8 -*-
# CONCATENAR

print("CONCATENTAR")

a = "Thiago"
b = "Carlos"

concatenar = a + " " + b + "\n"
print(concatenar)

print("TAMANHO")
tamanho = len(concatenar)
print(tamanho)

print(" ")
print(a[0])
print(a[1])
print(a[2])
print(a[3])
print(a[4])
print(a[5])

print(" ")
print(concatenar[0:6])
print(concatenar[0:])


print("FUNÇÃO LOWER (minúsculo) e UPPER (MAIÚSCULO)")
print(concatenar.lower()) # minúsculo
print(concatenar.upper()) # MAIÚSCULO

print("REMOVER CARACTERE") # Função strip - remove caractere
print(concatenar.strip())
print(concatenar)

print("SEPARAR STRING/SEPARAR POR LETRA")
minha_string = "O rato roeu a roupa do rei de Roma"

minha_lista = minha_string.split(" ")
print(minha_lista)
minha_lista2 = minha_string.split("r") #case sensitive
print(minha_lista2)


minha_string2 = "O rato roeu a roupa do rei de Roma"

print(" ")
print("BUSCA DE SUBSTRING")
busca = minha_string2.find("rei") # retorna o valor de onde começa s substring
busca2 = minha_string2.find("rainha")
print(busca)
print(minha_string2[busca:]) # retorna o valor a partir de busca até o final
print(busca2) # Quando ele não encontra a substring, retorna o valor -1 

print(" ")
print("REPLACE") # Substitui partes de strings
minha_string3 = minha_string2.replace("o rei", "a rainha")
print(minha_string3)
busca3 = minha_string3.find("rainha")
print(busca3)
