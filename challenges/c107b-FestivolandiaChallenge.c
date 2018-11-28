// Adrián Navarro Gabino

#include <stdio.h>

int main(void)
{
    int cases, day, month, i;
    
    scanf("%d", &cases);
    
    for(i = 0; i < cases; i++)
    {
        scanf("%d", &day);
        scanf("%d", &month);
        
        if( (day % 2 == month % 2) || (day == 25 && month == 12) )
            printf("FESTIVO\n");
        else
            printf("LABORABLE\n");
    }
    
    return 0;
}
