# Adrián Navarro Gabino

casosPrueba = int(input())

for i in range(casosPrueba):
    patasTotales = 0
    artropodos = [int(x) for x in input().split()]
    for j in range(1,4):
        patasTotales += artropodos[j-1] * (4 + j * 2)
    patasTotales += artropodos[3] * artropodos[4] * 2
    print(patasTotales)
