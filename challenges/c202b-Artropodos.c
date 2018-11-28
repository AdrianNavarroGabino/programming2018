// Adrián Navarro Gabino

#include <stdio.h>

int main()
{
    int i;
    
    int casosPrueba;
    scanf("%d", &casosPrueba);
    
    int art1, art2, art3, art4, art5;
    
    int patasTotales;
    
    for(i = 0; i < casosPrueba; i++)
    {
        patasTotales = 0;
        
        scanf("%d", &art1);
        scanf("%d", &art2);
        scanf("%d", &art3);
        scanf("%d", &art4);
        scanf("%d", &art5);
        
        patasTotales = art1 * 6 + art2 * 8 + art3 * 10 + art4 * art5* 2;
        
        printf("%d\n", patasTotales);
    }
    
    return 0;
}
