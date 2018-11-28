'''
Entrada de ejemplo
8
100 -10
-10 -100
-10 100
100 -1000
2500 -2490
9500 -9500
-100 99
50 -50
Salida de ejemplo
SI
NO
SI
NO
SI
SI
NO
SI
'''

# Adrián Navarro Gabino

casosPrueba = int(input())

for i in range(casosPrueba):
    dinero = [int(x) for x in input().split()]
    print("SI" if (dinero[0] + dinero[1] >= 0) else "NO")
