'''
Entrada de ejemplo
3
8
1 4 2 2 3 5 3 4
2
9 9
5
1 2 3 4 5
Salida de ejemplo
4 2
0 0
4 0
'''

# Adrian Navarro Gabino

casosPrueba = int(input())

for i in range(casosPrueba):
    saltoUp = 0
    saltoDown = 0

    tamanyo = int(input())
    muros = [int(x) for x in input().split()]
    
    for j in range(1,tamanyo):
        if muros[j] < muros[j-1]:
            saltoDown += 1
        elif muros[j] > muros[j-1]:
            saltoUp += 1
    
    print(saltoUp,end=" ")
    print(saltoDown)
