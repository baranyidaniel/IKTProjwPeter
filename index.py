from os import system
system("cls")
import csv

#beolvas

file = open("otos.csv")
csvreader = csv.reader(file)
header = next(csvreader)
print(header)
rows = []
for row in csvreader:
    rows.append(row)
file.close()

nyeroszamok = []
for i in range(len)

#multheti számok

multheti1 = str(rows[0]).split(";")
multheti2 = str(rows[1]).split(";")
print(f"A múlt heti nyerőszámok: {multheti1[-5:]}")
print(f"Azelőtti heti nyerőszámok: {multheti2[-5:]}")

#leggyakoribb számok



#legkisebb