# -*- coding: utf-8 -*-
print("AULA 33 - PYTHON AVANÇADO - LIST COMPREHENSION")
print(" ")
x = [1, 2, 3, 4, 5]
y = []

for i in x:
	y.append(i**2)
print(x)
print(y)
print(" ")
print("USANDO LIST COMPREHENSION")
print(" ")
z = [1, 2, 3, 4, 5]
w = [i**2 for i in z] #[valor_a_adicionar laço condição] PS: neste exemplo não tem condição
q = [i for i in z if i%2==1] # quero adiconar apenas os números ímpares de z
print(z)
print(w)
print(q) #exemplo usando a condição
