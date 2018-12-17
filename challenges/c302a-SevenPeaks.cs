// Adrián Navarro Gabino

using System;

public class SevenPeaks
{
    public static void Main()
    {
        int numberOfTurningPoints;
        int numberOfPeaks;
        
        do
        {
            numberOfTurningPoints = Convert.ToInt32(Console.ReadLine());
            
            if(numberOfTurningPoints != 0)
            {
                numberOfPeaks = 0;
                
                int[] turningPoints = new int[numberOfTurningPoints + 2];
                
                string[] aux = Console.ReadLine().Split();
                
                for(int i = 0; i < numberOfTurningPoints; i++)
                {
                    turningPoints[i] = Convert.ToInt32(aux[i]);
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
                
                Console.WriteLine(numberOfPeaks);
            }
        } while(numberOfTurningPoints != 0);
    }
}
