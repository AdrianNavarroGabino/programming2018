/*
https://www.aceptaelreto.com/problem/statement.php?id=433
Racimos de uvas
Entrada de ejemplo
10
40
400
4000
40000
400000
0
Salida de ejemplo
4
9
28
89
283
894
*/


// Adrián Navarro Gabino

#include <stdio.h>
#include <math.h>

int main()
{
    int grapes;
    
    do
    {
        scanf("%d", &grapes);
        
        if(grapes != 0)
        {
            double level = (-1 + sqrt(1 + 8 * grapes)) / 2;
            
            printf("%d\n", (int)ceil(level));
        }
    } while(grapes != 0);
    
    return 0;
}
