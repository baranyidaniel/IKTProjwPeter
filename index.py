from os import system
system("cls")
import csv
file = open("otos.csv")
csvreader = csv.reader(file)
header = next(csvreader)
print(header)
rows = []
for row in csvreader:
    rows.append(row)
file.close()

#multheti számok

multheti1 = str(rows[0]).split(";")
multheti1 = str(rows[0]).split(";")
print(f"A múlt heti nyerőszámok: {multheti[-5:]}")