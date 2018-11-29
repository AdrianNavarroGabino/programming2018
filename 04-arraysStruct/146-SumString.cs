// Sum numbers from a spaces-delimited string
// Adrián Navarro Gabino

using System;

public class SumString
{
    public static void Main()
    {
        int amount = 0;
        
        Console.WriteLine("Enter data separated by spaces:");
        string[] data = Console.ReadLine().Split();
        
        int[] numbers = new int[data.Length];
        
        for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToInt32(data[i]);
            amount += numbers[i];
        }
        
        Console.WriteLine(amount);
    }
}
