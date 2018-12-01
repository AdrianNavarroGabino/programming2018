// Function to return the sum of the elements in an array of integers
// Adrián Navarro Gabino

using System;

public class SumArray
{
    public static int SumOfArray(int[] numbers)
    {
        int total = 0;
        for(int i = 0; i < numbers.Length; i++)
        {
            total += numbers[i];
        }
        return total;
    }
    
    public static void Main()
    {
        int[] example = {20, 10, 5, 2};
        Console.WriteLine("The sum of the array is {0}",
            SumOfArray(example));
    }
}
