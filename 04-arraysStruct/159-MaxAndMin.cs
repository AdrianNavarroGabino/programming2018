// Max and min of an array
// Adrián Navarro Gabino

using System;

public class MaximumAndMinimum
{
    public static void Main()
    {
        const int SIZE = 10;
        ulong[] numbers = new ulong[SIZE];
        
        for(int i = 0; i < SIZE; i++)
        {
            Console.Write("Enter the number {i}: ", (i+1));
            numbers[i] = Convert.ToUInt64(Console.ReadLine());
        }
        
        ulong maxNumber = numbers[0];
        ulong minNumber = numbers[0];
        
        for(int i = 1; i < SIZE; i++)
        {
            if(numbers[i] > maxNumber)
                maxNumber = numbers[i];
            if(numbers[i] < minNumber)
                minNumber = numbers[i];
        }
        
        Console.WriteLine("Max number: " + maxNumber);
        Console.WriteLine("Min number: " + minNumber);
    }
}
