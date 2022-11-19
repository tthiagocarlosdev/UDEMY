print("TESTE")
import random

workout = ["For time", "21-15-9", "EMOM", "AMRAP"]

ginastic = ["air squat", "pull up", "push up", "rope climb", "muscle up", "handstand", "sit up", "jumps", "lunge"]
metabolic = ["run", "bike", "row", "double under", "swim"]
weightlifting = ["deadlift", "clean", "snatch", "clean and jerk", "wall ball", "swing"]


a = random.choice(workout)
b = random.choice(ginastic)
c = random.choice(metabolic)
d = random.choice(weightlifting)

if a == "For time":
	print(a)
	print(b+" - "+c+" - "+d)
if a == "21-15-9":
	print(a)
	print(b+" - "+c+" - "+d)
if a == "EMOM":
	print(a)
	print(b+" - "+c)
if a == "AMRAP":
	print(a)
	print(b+" - "+c+" - "+d)


