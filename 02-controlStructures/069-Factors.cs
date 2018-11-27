// Prime factors (break + while)
// Adrián Navarro Gabino

using System;

public class Factors
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("{0} = ", n);
        
        while(n != 1)
        {
            for(int i = 2; i <= n; i++)
            {
                if(n % i == 0)
                {
                    Console.Write("{0} ", i);
                    n = n / i;
                    break;
                }
            }
        }
        
        Console.WriteLine();
    }
}
