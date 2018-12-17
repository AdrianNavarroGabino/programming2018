// Adrián Navarro Gabino

import java.util.*;

public class SevenPeaks
{
    public static void main(String[] args)
    {
        int numberOfTurningPoints;
        int numberOfPeaks;
        
        do
        {
            Scanner sc = new Scanner(System.in);
            
            numberOfTurningPoints = sc.nextInt();
            sc.nextLine();
            
            if(numberOfTurningPoints != 0)
            {
                numberOfPeaks = 0;
                
                int[] turningPoints = new int[numberOfTurningPoints + 2];
                
                for(int i = 0; i < numberOfTurningPoints; i++)
                {
                    turningPoints[i] = sc.nextInt();
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
                
                System.out.println(numberOfPeaks);
            }
        } while(numberOfTurningPoints != 0);
    }
}
