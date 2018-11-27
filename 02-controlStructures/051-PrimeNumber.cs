// Is a number prime?
// Adrián Navarro Gabino

using System;

public class PrimeNumber
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int limit = n / 2;
        
        int dividers = 0;
        
        for(int i = 2; i <= limit; i++)
        {
            if(n % i == 0)
                dividers++;
        }
        
        if(dividers == 0)
            Console.WriteLine("{0} is prime", n);
        else
            Console.WriteLine("{0} is NOT prime", n);
    }
}
