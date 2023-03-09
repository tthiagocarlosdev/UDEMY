# -*- coding: utf-8 -*-
print("EXERCÍCIO NÚMERO 3")
print(" ")
import random
a = random.randint(0, 10) # retorna um número aleatório
print(a)
b = random.randint(0, 10) # retorna um número aleatório
print(b)
c = random.randint(0, 10) # retorna um número aleatório
print(c)
print(" ")
delta = ((b**2) - (4*(a*c)))
print(delta)
print(" ")
x1 = ((-b) + (delta**(1/2)) / (2*(a)))
print(x1)
x2 = ((-b) - (delta**(1/2)) / (2*(a)))
print(x2)

# ax²+bx+c=0
# delta = ((b**2) - (4*(a*c)))
# x¹ = ((-b) + (delta**(1/2)) / (2*(a)))
# x² = ((-b) - (delta**(1/2)) / (2*(a)))
print(" ")
print("RESOLUÇÃO DO PROFESSOR")

from math import sqrt
a = int(input("Digite o valor de A: "))
b = int(input("Digite o valor de B: "))
c = int(input("Digite o valor de C: "))
 
delta = b**2 - 4*a*c
raiz_delta = sqrt(delta)
 
if raiz_delta < 0:
    print("Delta negativo")
else:
    x1 = (-b + raiz_delta)/2*a
    x2 = (-b + raiz_delta)/2*a
 
    print("As raízes são", x1, "e", x2)