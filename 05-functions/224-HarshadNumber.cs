// Adrián Navarro Gabino

using System;

public class HarshadNumber
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
    
    public static bool IsHarshadNumber(int number)
    {
        return number % SumDigits(number) == 0;
    }
    
    
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        
        if(IsHarshadNumber(num))
            Console.WriteLine(num + " is a Harshad number");
        else
            Console.WriteLine(num + " is not a Harshad number");
    }
}
