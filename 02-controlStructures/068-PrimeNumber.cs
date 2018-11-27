// Prime number?
// Adrián Navarro Gabino

using System;

public class PrimeNumber
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        if(n == 1)
            Console.WriteLine("The number {0} is NOT prime", n);
        else
        {
            for(int i = 2; i <= n; i++)
            {
                if(i == n)
                {
                    Console.WriteLine("The number {0} is prime", n);
                    break;
                }
                
                if(n % i == 0)
                {
                    Console.WriteLine("The number {0} is NOT prime", n);
                    break;
                }
            }
        }
    }
}
