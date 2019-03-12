// Adrián Navarro Gabino

using System;

public class Diagonal
{
    public static void Main()
    {
        int seqLength = Convert.ToInt32(Console.ReadLine());
        
        string steps = Console.ReadLine().ToUpper();
        string finalSteps = "";
        
        for(int i = 0; i < seqLength; i++)
        {
            if(steps[i] == 'R')
            {
                if(i != seqLength - 1 && steps[i + 1] == 'U')
                {
                    finalSteps += "D";
                    i++;
                }
                else
                {
                    finalSteps += "R";
                }
            }
            else
            {
                if(i != seqLength - 1 && steps[i + 1] == 'R')
                {
                    finalSteps += "D";
                    i++;
                }
                else
                {
                    finalSteps += "U";
                }
            }
        }
        
        Console.WriteLine(finalSteps.Length);
    }
}
