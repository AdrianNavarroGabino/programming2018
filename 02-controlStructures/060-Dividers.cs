// Common dividers of two numbers
// Adrián Navarro Gabino

using System;

public class Dividers
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter another number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        
        int count = 0;
        int min = num1;
        if(num2 < min)
            min = num2;
            
        Console.Write("Their common dividers are... ");
        
        for(int i = 2; i <= min; i++)
        {
            if( (num1 % i == 0) && (num2 % i == 0) )
            {
                Console.Write("{0} ", i);
                count++;
            }
        }
        
        if(count == 0)
            Console.WriteLine(" None.");
        else
            Console.WriteLine();
        
    }
}
