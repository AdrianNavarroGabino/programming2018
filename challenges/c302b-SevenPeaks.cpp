// Adrián Navarro Gabino

#include <iostream>

using namespace std;

int main()
{
    int numberOfTurningPoints;
    int numberOfPeaks;
    do
    {
        
        cin >> numberOfTurningPoints;
        
        if(numberOfTurningPoints != 0)
        {
            numberOfPeaks = 0;
            
            int turningPoints[numberOfTurningPoints + 2];
            
            for(int i = 0; i < numberOfTurningPoints; i++)
            {
                cin >> turningPoints[i];
            }
            
            turningPoints[numberOfTurningPoints] = turningPoints[0];
            turningPoints[numberOfTurningPoints + 1] = turningPoints[1];
            
            for(int i = 1; i < numberOfTurningPoints + 1; i++)
            {
                if(     turningPoints[i] > turningPoints[i - 1] &&
                        turningPoints[i + 1] < turningPoints[i])
                {
                    numberOfPeaks++;
                }
            }
            
            cout << numberOfPeaks << endl;
        }
    } while(numberOfTurningPoints != 0);
    
    return 0;
}
