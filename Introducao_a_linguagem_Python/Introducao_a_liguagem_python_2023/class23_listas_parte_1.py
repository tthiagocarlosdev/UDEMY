# aula_23___listas_parte_1

# Declarando uma lista
minha_lista = ["abacaxi", "melancia", "abacate"]
minha_lista_2 = [ 1, 2, 3, 4, 5]
minha_lista_3 = [ "abacaxi", 2, 9.89, True]

print(minha_lista)
print("--------------")
print(minha_lista_2)
print("--------------")
print(minha_lista_3)
print("--------------")

# Exibindo elementos pela posição
print(minha_lista[2])
print(minha_lista[0])
print(minha_lista[1])
print("--------------")
for item in minha_lista:
	print(item)

print("--------------")

# Verificando tamanho de uma lista
tamanho = len(minha_lista)

print(tamanho)

print("--------------")

# Adicionando elementos
minha_lista.append("limao")
print(minha_lista)

print("--------------")

# Verificando se um elemento pertence a lista
if "limao" in minha_lista:
	print("limao está na lista")

print("--------------")

# Removendo elementos

del minha_lista[2:]
print(minha_lista)

print("--------------")
# Apagando a lista inteira
del minha_lista[:]
print(minha_lista)
