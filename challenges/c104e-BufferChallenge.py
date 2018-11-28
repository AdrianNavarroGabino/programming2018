cases = int(input())

for i in range(cases):
    urinals = int(input())
    numberOfMen = urinals // 2 if urinals % 2 == 0 else (urinals + 1) // 2
    print(numberOfMen)
