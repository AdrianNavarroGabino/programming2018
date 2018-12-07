// Statistics1: Sum
// Adrián Navarro Gabino

using System;

public class Statistics
{
    public static void Main()
    {
        double sum = 0;
        double num;
        
        do
        {
        Console.Write("Number: ");
        num = Convert.ToInt32(Console.ReadLine());
        
        if(num != 0)
        {
            sum += num;
            Console.WriteLine("Sum = {0}", sum);
        }
        else
            Console.WriteLine("See you!");
        } while(num != 0);
        
    }
    
}
