/*
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
*/

// Adrián Navarro Gabino

#include <stdio.h>
#include <stdlib.h>

int main()
{
    int cases, i;
    scanf("%d", &cases);
    
    for(i = 0; i < cases; i++)
    {
        char* name;
        char* relationship;
        
        name = (char*) malloc(101);
        scanf("%s", name);
        relationship = (char*) malloc(101);
        scanf("%s", relationship);
        
        if((name[0] != 'L' && name[1] != 'u' && name[2] != 'k' && name[3] != 'e')
            || (relationship[0] != 'p' && relationship[1] != 'a' &&
                relationship[2] != 'd' && relationship[3] != 'r' &&
                relationship[4] != 'e'))
        {
            printf("%s, yo soy tu %s\n", name, relationship);
        }
        else
        {
            printf("TOP SECRET\n");
        }
    }
}
