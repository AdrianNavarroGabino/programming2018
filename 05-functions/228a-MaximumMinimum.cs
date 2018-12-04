// Adrián Navarro Gabino

using System;

public class MaximumMinimum
{
    public static void MaxMin(int[] data, ref int max, ref int min)
    {
        max = data[0];
        min = data[0];
        
        for(int i = 1; i < data.Length; i++)
        {
            if(data[i] > max)
            {
                max = data[i];
            }
            if(data[i] < min)
            {
                min = data[i];
            }
        }
    }
    
    
    public static void Main()
    {
        int[] numbers = {20,30,-5,2};
        
        int max = 0;
        int min = 0;
        
        MaxMin(numbers, ref max, ref min);
        
        Console.WriteLine(max);
        Console.WriteLine(min);
    }
}
