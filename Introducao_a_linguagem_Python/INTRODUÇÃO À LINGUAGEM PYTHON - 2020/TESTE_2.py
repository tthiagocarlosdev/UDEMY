print("TESTE_2")

idade = (65) #input
fcr = (60) #input
fcm = (220 - idade)
print("Frequencia cardiaca maxima")
print(fcm)


print(" ")
print("Frequencia cardiaca de trabalho")

fct40 = ("fct_40%" + ":")
print(fct40)
fct_40 = (((fcm - fcr)*0.4)+fcr) #40%
print(fct_40)

print(" ")

fct50 = ("fct_50%" + ":")
print(fct50)
fct_50 = (((fcm - fcr)*0.5)+fcr) #50%
print(fct_50)

print(" ")

fct60 = ("fct_60%" + ":")
print(fct60)
fct_60 = (((fcm - fcr)*0.6)+fcr) #60%
print(fct_60)

print(" ")

fct70 = ("fct_70%" + ":")
print(fct70)
fct_70 = (((fcm - fcr)*0.7)+fcr) #70%
print(fct_70)

print(" ")

fct80 = ("fct_80%" + ":")
print(fct80)
fct_80 = (((fcm - fcr)*0.8)+fcr) #80%
print(fct_80)

print(" ")

fct90 = ("fct_90%" + ":")
print(fct90)
fct_90 = (((fcm - fcr)*0.9)+fcr) #90%
print(fct_90)

print(" ")
print("Periodizacao")
print("seg", "qua", "sex")

# mes = 1 (linear); mes = 2 (ondulatorio)
mes = (2)  #input

# mesociclo linear
sem1a = (fct_70, fct_70, fct_70)
sem2a = (fct_80, fct_80, fct_80)
sem3a = (fct_90, fct_90, fct_90)
sem4a = (fct_70, fct_70, fct_70)
# mesociclo ondulatorio
sem1b = (fct_60, fct_70, fct_80)
sem2b = (fct_70, fct_80, fct_90)
sem3b = (fct_60, fct_70, fct_80)
sem4b = (fct_70, fct_80, fct_90)

if mes == 1:
	print(sem1a)
	print(sem2a)
	print(sem3a)
	print(sem4a)
else:
	print(sem1b)
	print(sem2b)
	print(sem3b)
	print(sem4b)



