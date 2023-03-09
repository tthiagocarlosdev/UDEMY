# -*- coding: utf-8 -*-
print("AULA 20 - STRINGS - PARTE 2")
"""
Em Python strings são objetos
Pode-se aplicar métodos a strings
string = string.metodo()
"""
print("ALTERANDO A CAIXA")
a = "Thiago"
b = "Carlos"
concatenar = a + " " + b
print(concatenar)
print(concatenar.lower()) # método lower - coloca tudo em minúsculo
print(concatenar.upper()) # método upper - coloca tudo em maiúsculo
print("REMOVENDO ESPAÇOS NO COMEÇO E FIM DA STRING")
concatenar2 = a + " " + b + "\n"
print(concatenar2)
print(concatenar2.strip()) # método strip remove espaço ou caractére especial no início e fim da string]
print("CONVERTENDO UMA STRING EM LISTA")
minha_string = "O rato roeu a roupa do rei de Roma"
milha_lista = minha_string.split() # separa a string por espaço
print(milha_lista)
print(minha_string.split("r")) # separa a string sem a letra "r"
print("BUSCANDO SUBSTRINGS")
# em que posição aparece a busca
busca = minha_string.find("rei")
print(busca) # indicou o índice de minha busca
print(minha_string[23:]) # utilizo o índice encontrado no find
print(minha_string.find("rainha")) # quando não encontra a substring, retorna o valor -1
print("SUBSTITUIR PARTES DE UMA STRING")
substituir = minha_string.replace("o rei", "a rainha") # replace - substitui uma parte de uma substring
print(substituir)
