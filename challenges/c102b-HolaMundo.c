/*
Reto 1.02: Hola mundo (Acepta 116)
Entrada de ejemplo
3
Salida de ejemplo
Hola mundo.
Hola mundo.
Hola mundo.
*/

// Adrián Navarro Gabino

#include <stdio.h>

int main(void)
{
    int n, i;
    scanf("%d", &n);
    
    for(i = 0; i < n; i++)
        printf("Hola mundo.\n");
        
    return 0;
}
