/*
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
*/

// Adrian Navaro Gabino

#include <stdio.h>

int main()
{
    int i, j;
    
    int casosPrueba;
    scanf("%d", &casosPrueba);
    
    int tamanyo;
    
    int saltoUp, saltoDown;
    
    for(i = 0; i < casosPrueba; i++)
    {
        saltoUp = 0;
        saltoDown = 0;
        
        scanf("%d", &tamanyo);
        
        int muros[tamanyo];
        
        for(j = 0; j < tamanyo; j++)
        {
            scanf("%d", &muros[j]);
        }
        
        for(j = 1; j < tamanyo; j++)
        {
            if(muros[j] < muros[j-1])
            {
                saltoDown++;
            }
            else if(muros[j] > muros[j-1])
            {
                saltoUp++;
            }
        }
        
        printf("%d %d\n", saltoUp, saltoDown);
    }
}
