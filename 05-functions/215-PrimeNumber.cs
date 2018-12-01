// Adrián Navarro Gabino

using System;

public class PrimeNumber
{
    public static bool IsPrime(long number)
    {
        if(number == 1)
            return false;
        
        for(int i = 2; i < number / 2; i++)
        {
            if(number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    
    public static void Main()
    {
        Console.Write("Enter a number: ");
        long n1 = Convert.ToInt64(Console.ReadLine());
        
        Console.WriteLine();
        
        Console.WriteLine("Prime: " + IsPrime(n1));
    }
}
