// Trying to exit two nested loops with "break"
// Adrián Navarro Gabino

using System;

public class NestedLoops
{
    public static void Main()
    {
        int j;
        
        for(int i = 1; i <= 10; i++)
        {
            
            for(j = 20; j <= 30; j = j + 2)
            {
                if(i == 3 && j > 25)
                    break;
                Console.WriteLine("{0} {1}",i,j);
            }
            
            if(i == 3 && j > 25)
                break;
        }
    }
}
