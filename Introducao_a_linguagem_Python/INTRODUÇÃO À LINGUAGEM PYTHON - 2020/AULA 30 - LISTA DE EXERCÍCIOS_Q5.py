# -*- coding: utf-8 -*-
print("AULA 30 - LISTA DE EXERCÍCIOS_Q5")
# Escreva um programa que receba dois números e um sinal, e faça a operação matemática definida pelo sinal.

num_a = int(input("Digite um número: "))
num_b = int(input("Digite um número: "))
operacao = input("Digite um operacao: ")

if operacao == adicao:
	print(num_a + num_b)
elif subtracao:
	print(num_a - num_b)
elif multiplicacao:
	print(num_a * num_b)
elif divisao:
	print(num_a / num_b)
else:
	print("Operacao invalida")
