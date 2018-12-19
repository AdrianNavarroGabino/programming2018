// Adrián Navarro Gabino

using System;

public class AlmostPrimes
{
    public static bool IsAlmostPrime(int number)
    {
        for(int i = 2; i <= Math.Sqrt(number); i++)
            if(number % i == 0 && IsPrime(i))
                if(IsPrime(number / i))
                    return true;
        
        return false;
    }
    
    public static bool IsPrime(int number)
    {
        for(int i = 2; i <= Math.Sqrt(number); i++)
        {
            if(number % i == 0)
                return false;
        }
        
        return true;
    }
    
    
    public static void Main()
    {
        int cases = Convert.ToInt32(Console.ReadLine());
        
        for(int currentCase = 0; currentCase < cases; currentCase++)
        {
            string[] aux = Console.ReadLine().Split();
            
            int lowerLimit = Convert.ToInt32(aux[0]);
            int upperLimit = Convert.ToInt32(aux[1]);
            
            int count = 0;
            
            for(int i = lowerLimit; i <= upperLimit; i++)
            {
                if(IsAlmostPrime(i))
                    count++;
            }
            
            Console.WriteLine(count);
        }
    }
}
