// Adrián Navarro Gabino

#include <stdio.h>

int main(void)
{
    int streetNumber;
    
    do
    {
        scanf("%d", &streetNumber);
            
        if( (streetNumber != 0) && (streetNumber % 2 == 0) )
            printf("DERECHA\n");
        else if (streetNumber % 2 == 1)
            printf("IZQUIERDA\n");
    } while(streetNumber != 0);
    
    return 0;
}
