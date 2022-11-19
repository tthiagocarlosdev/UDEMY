# -*- coding: utf-8 -*-
print("AULA 30 - LISTA DE EXERCÍCIOS_Q3")
"""
Escreva um programa que resolva uma equação de segundo grau.
"""
a = int(input("Digite a: "))
b = int(input("Digite b: "))
c = int(input("Digite c: "))

delta = ((b**2) - (4 * (a * c)))
x_1 = ((-b + (delta ** (1/2))) / (2 * a))
x_2 = ((-b - (delta ** (1/2))) / (2 * a))
print("As raízes são", x_1, "e", x_2)
