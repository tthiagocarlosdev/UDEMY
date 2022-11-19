print("TESTE_2")

age = (32) #input
rhr = (60) #input - Resting heart rate (Frequancia cardiaca de repouso)
mhr = (220 - age) # - Maximum heart rate (Frequancia cardiaca maxima)
print("Age")
print(age)
print("Resting heart rate")
print(rhr)
print("Maximum heart rate")
print(mhr)

print(" ")

print("Heart rate trainig") # Frequencia cardiaca de treino
hrt_40 = (((mhr - rhr)*0.4)+rhr) #40%
hrt_50 = (((mhr - rhr)*0.5)+rhr) #50%
hrt_60 = (((mhr - rhr)*0.6)+rhr) #60%
hrt_70 = (((mhr - rhr)*0.7)+rhr) #70%
hrt_80 = (((mhr - rhr)*0.8)+rhr) #80%
hrt_90 = (((mhr - rhr)*0.9)+rhr) #90%

print(" ")

print("Monday,", "Wednesday,", "Friday")

# month = 1 (linear); month = 2 (wave)
month = (2)  #input

# mesocycle linear
week1a = (hrt_70, hrt_70, hrt_70)
week2a = (hrt_80, hrt_80, hrt_80)
week3a = (hrt_90, hrt_90, hrt_90)
week4a = (hrt_70, hrt_70, hrt_70)
# mesocycle wave
week1b = (hrt_60, hrt_70, hrt_80)
week2b = (hrt_70, hrt_80, hrt_90)
week3b = (hrt_60, hrt_70, hrt_80)
week4b = (hrt_70, hrt_80, hrt_90)

if month == 1:
	print(week1a)
	print(week2a)
	print(week3a)
	print(week4a)
else:
	print(week1b)
	print(week2b)
	print(week3b)
	print(week4b)



