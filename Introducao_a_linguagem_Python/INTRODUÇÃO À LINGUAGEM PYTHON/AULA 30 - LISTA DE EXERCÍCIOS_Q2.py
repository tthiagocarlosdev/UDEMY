# -*- coding: utf-8 -*-
print("AULA 30 - LISTA DE EXERCÍCIOS_Q2")
"""
Faça um programa que receba duas notas digitadas pelo usuário.
Se a nota for maior ou igual a seis, escreva aprovado, senão escreva reprovado.
"""
nota_1 = float(input("Digite a nota 1: "))
nota_2 = float(input("Digite a nota 2: "))

nota_final = ((nota_1 + nota_2) / 2)

if nota_final >= 6:
	print("Aprovado")
else:
	print("Reprovado")

