// Quitting two nested loops with "goto"
// Adrián Navarro Gabino

using System;

public class NestedLoopsGoTo
{
    public static void Main()
    {        
        for(int i = 1; i <= 10; i++)
        {
            for(int j = 20; j <= 30; j = j + 2)
            {
                if(i == 3 && j > 25)
                    goto programContinues;
                Console.WriteLine("{0} {1}",i,j);
            }
        }
        programContinues:;
    }
}
