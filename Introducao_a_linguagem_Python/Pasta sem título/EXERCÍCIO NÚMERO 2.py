# -*- coding: utf-8 -*-
print("EXERCÍCIO NÚMERO 2")
print(" ")
import random
nota = random.randint(0, 10) # retorna um número aleatório
print(nota)

z = 6

if nota >= z:
	print("aprovado")
if nota < z:
	print("reprovado")
print(" ")
print("RESOLUÇÃO DO PROFESSOR")
nota1 = float(input("Digite a primeira nota:"))
nota2 = float(input("Digite a segunda nota"))

media = ((nota1+nota2)/2)
if media >=6:
	print("Aprovado")
else:
	print("Reprovado")
