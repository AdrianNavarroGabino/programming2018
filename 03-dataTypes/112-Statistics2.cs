// Statistics2: Sum, average
// Adrián Navarro Gabino

using System;

public class Statistics
{
    public static void Main()
    {
        double sum = 0;
        double num;
        double average = 0;
        int count = 0;
        
        do
        {
        Console.Write("Number: ");
        num = Convert.ToDouble(Console.ReadLine());
        
        if(num != 0)
        {
            count++;
            average = (sum + num) / count;
            sum += num;
            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("Average = {0}", average);
        }
        } while(num != 0);
        
        Console.WriteLine("See you!");
        
    }
    
}
