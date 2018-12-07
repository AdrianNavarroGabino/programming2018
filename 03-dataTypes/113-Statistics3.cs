// Statistics3: Sum, average, max, min (a: while)
// Adrián Navarro Gabino

using System;

public class Statistics
{
    public static void Main()
    {
        double sum = 0;
        double num;
        double average = 0;
        double minimum, maximum;
        int count = 0;
        
        Console.Write("Number: ");
        num = Convert.ToDouble(Console.ReadLine());
        minimum = num;
        maximum = num;
        
        while(num != 0)
        {
        
            if(num != 0)
            {
                count++;
                sum += num;
                average = sum / count;
                Console.WriteLine("Max = {0}", maximum);
                Console.WriteLine("Min= {0}", minimum);
                Console.WriteLine("Average = {0}", average);
            }
            
            Console.Write("Number: ");
            num = Convert.ToDouble(Console.ReadLine());
            
            if(num < minimum)
                minimum = num;
            if(num > maximum)
                maximum = num;
        }
        
        Console.WriteLine("See you!");
        
    }
    
}
