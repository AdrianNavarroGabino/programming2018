// Adrián Navarro Gabino

#include <stdio.h>

int main(void)
{
    int cases, urinals, numberOfMen, i;
    
    scanf("%d", &cases);
        
    for(i = 0; i < cases; i++)
    {
        scanf("%d", &urinals);
        numberOfMen = urinals % 2 == 0 ? urinals / 2 : (urinals + 1) / 2;
        printf("%d\n", numberOfMen);
    }
    
    return 0;
}
