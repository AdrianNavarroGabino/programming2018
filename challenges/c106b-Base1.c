// Adrián Navarro Gabino

#include <stdio.h>

int main(void)
{
    int n, i;
    
    do
    {
        scanf("%d", &n);
            
        for(i = 0; i < n; i++)
            printf("%d",1);
        printf("\n");
    } while(n != 0);
    
    return 0;
}
