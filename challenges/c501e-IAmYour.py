'''
Entrada de ejemplo
4
C-3PO
creador
Luke
padre
Princesa
Principe
Luke
Padre
Salida de ejemplo
C-3PO, yo soy tu creador
TOP SECRET
Princesa, yo soy tu Principe
Luke, yo soy tu Padre
'''

# Adrián Navarro Gabino

cases = int(input())

for i in range(cases):
    name = input()
    relationship = input()
    
    if name != "Luke" or relationship != "padre":
        print(name + ", yo soy tu " + relationship)
    else:
        print("TOP SECRET")
