// Adrián Navarro Gabino

using System;

public class Primes
{
    public static bool IsPrime(int number)
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
        int cases = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 0; i < cases; i++)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int primes = 0;
            
            for(int j = 11; j <= number; j++)
            {
                if(IsPrime(j) && Convert.ToString(j)[0] == '1')
                    primes++;
            }
            
            Console.WriteLine(primes);
        }
    }
}
