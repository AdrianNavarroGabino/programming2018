// Show the values which are over the average
// Adrián Navarro Gabino

using System;

public class OverAverage
{
    public static void Main()
    {
        float[] numbers = new float[10];
        for(int i = 0; i < 10; i++)
        {
            Console.Write("Enter a number: ");
            numbers[i] = Convert.ToSingle(Console.ReadLine());
        }
        float average = 0f;
        for(int i = 0; i < 10; i++)
            average += numbers[i];
        average /= 10;
        for(int i = 0; i < 10; i++)
            if(numbers[i] > average)
                Console.Write("{0} ", numbers[i]);
        Console.WriteLine();
    }
}
