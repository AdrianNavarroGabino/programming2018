// Adrián Navarro Gabino

#include <stdio.h>

int main()
{
    int players;
    int chosenPlayer;
    int i;
    
    scanf("%d", &players);
    scanf("%d", &chosenPlayer);
    
    int score[players];
    
    for(i = 0; i < players; i++)
    {
        scanf("%d", &score[i]);
    }
    
    int count = 0;
        
    for(int i = 0; i < players; i++)
    {
        if(score[i] >= score[chosenPlayer - 1] && score[i] > 0)
            count++;
    }
    
    printf("%d\n", count);

    return 0;
}
