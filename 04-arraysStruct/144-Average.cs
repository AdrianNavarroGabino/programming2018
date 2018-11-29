// Average of an array
// Adrián Navarro Gabino

using System;

public class Average
{
    public static void Main()
    {
        double[] numbers = new double[6];
        double amount = 0;
        
        for(int i = 0; i < 6; i++)
        {
            Console.Write("Enter a number: ");
            numbers[i] = Convert.ToDouble(Console.ReadLine());
            amount += numbers[i];
        }
        
        double average /= 6;
        
        Console.WriteLine("Average = " + amount);  
    }
}
