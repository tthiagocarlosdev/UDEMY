# -*- coding: utf-8 -*-
print("EXERCÍCIO NÚMERO 5")
print(" ")
import random
x = 2
y = 3
lista = ["+", "-", "*", '/']
z = random.choice(lista) # seleciona um número de uma lista
print(z)
print(" ")
if z == "+":
	print(x+y)
if z == "-":
	print(x-y)
if z == "*":
	print(x*y)
if z == "/":
	print(x/y)

print(" ")
print("RESOLUÇÃO DO PROFESSOR")
n1 = int(input("Digite o primeiro número: "))
sinal = input("Digite o sinal: ")
n2 = int(input("Digite o segundo número: "))
 
if sinal == "+":
    op = n1 + n2
 
elif sinal == "-":
    op = n1 - n2
 
elif sinal == "/":
    op = n1 + n2
 
elif sinal == "*":
    op = n1 * n2
 
else:
    print("Sinal inválido.")
 
print(op)