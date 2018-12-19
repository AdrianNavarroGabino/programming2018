// Adrián Navarro Gabino

#include <iostream>

using namespace std;

int main()
{
    int players;
    int chosenPlayer;
    
    cin >> players >> chosenPlayer;
    
    int score[players];
    
    for(int i = 0; i < players; i++)
    {
        cin >> score[i];
    }
    
    int count = 0;
        
    for(int i = 0; i < players; i++)
    {
        if(score[i] >= score[chosenPlayer - 1] && score[i] > 0)
            count++;
    }
    
    cout << count << endl;

    return 0;
}
