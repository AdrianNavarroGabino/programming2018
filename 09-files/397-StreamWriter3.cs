// Adrián Navarro Gabino

using System;
using System.IO;

public class Files3
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
        using(StreamWriter file = new StreamWriter("primes.txt"))
        {
            int amount = 0;
            int n = 2;
            
            while(amount < 50)
            {
                if(IsPrime(n))
                {
                    file.Write(n + " ");
                    amount++;
                }
                n++;
            }
            file.WriteLine();
        }
    }
}
