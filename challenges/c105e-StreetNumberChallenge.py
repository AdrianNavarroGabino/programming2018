streetNumber = 1

while streetNumber != 0:
    streetNumber = int(input())
    if streetNumber != 0 and streetNumber % 2 == 0:
        print("DERECHA")
    elif streetNumber % 2 == 1:
        print("IZQUIERDA")
