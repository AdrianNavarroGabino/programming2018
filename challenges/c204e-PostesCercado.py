'''
Calculate the minimum number of posts needed to fence an area by
knowing how much it measures and how often a post needs to be placed.

Example of input
10 10 10
6 6 10
10 15 10
0 0 0
Example of output
4
4
6
'''

# Adrián Navarro Gabino

datos = [int(x) for x in input().split()]

while datos[0] != 0 or datos[1] != 0 or datos[2] != 0:
    postes = (datos[0] // datos[2]) * 2;
    postes += 0 if (datos[0] % datos[2] == 0) else 2;
    postes += (datos[1] // datos[2]) * 2;
    postes += 0 if (datos[1] % datos[2] == 0) else 2;
    
    print(postes)
    
    datos = [int(x) for x in input().split()]
