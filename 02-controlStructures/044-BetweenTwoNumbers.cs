// Numbers between a lower and upper limits
// Adrián Navarro Gabino

using System;

public class BetweenTwoNumbers
{
    public static void Main()
    {
        Console.Write("Enter the lower limit: ");
        int lowerLimit = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the upper limit: ");
        int upperLimit = Convert.ToInt32(Console.ReadLine());
        
        int count = lowerLimit;
        
        while (count <= upperLimit)
        {
            Console.WriteLine(count);
            count = count + 1;
        }
    }
}
