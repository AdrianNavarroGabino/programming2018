// Adrián Navarro Gabino

using System;

public class Sum
{
    public static int SumDigits(int number)
    {
        int sum = 0;
        
        while(number != 0)
        {
            sum += number % 10;
            number /= 10;
        }
        
        return sum;
    }
    
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(SumDigits(num));
    }
}
