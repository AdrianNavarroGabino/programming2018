// Adrián Navarro Gabino

using System;

public class Maximum
{
    public static int Max(int[] data)
    {
        int max = data[0];
        
        for(int i = 1; i < data.Length; i++)
        {
            if(data[i] > max)
            {
                max = data[i];
            }
        }
        
        return max;
    }
    
    
    public static void Main()
    {
        int[] numbers = {20,30,-5,2};
        
        Console.WriteLine(Max(numbers));
    }
}
