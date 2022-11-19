# -*- coding: utf-8 -*-
print("EXERCÍCIO NÚMERO 1")
print(" ")

x = 20
y = 18
if x < y:
	print("Menor de idade")
if x >= y:
	print("Maior de idade")

print(" ")
print("RELOLUÇÃO DO PROFESSOR")
idade = int(input("Digite sua idade: "))

if idade >= 18:
	print("Maior de idade")
elif idade < 18:
	print("Menor de idade")
