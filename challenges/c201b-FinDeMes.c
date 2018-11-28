/*
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
*/

// Adrián Navarro Gabino

#include <stdio.h>

int main()
{
    // En C no hacen falta arrays para leer en una línea
    
    int i;
    
    int casosPrueba;
    scanf("%d", &casosPrueba);
    
    int dineroActual;
    int gastosPrevistos;
    
    for(i = 0; i < casosPrueba; i++)
    {
        scanf("%d", &dineroActual);
        scanf("%d", &gastosPrevistos);
        
        printf((dineroActual + gastosPrevistos >= 0) ? "SI\n":"NO\n");
    }
    
    return 0;
}
