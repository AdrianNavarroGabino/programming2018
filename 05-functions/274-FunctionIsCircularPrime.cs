// Adrián Navarro Gabino

using System;

public class FunctionIsCircularPrime
{
    public static bool IsPrime(long x)
    {
        for(long i = 2; i < x / 2; i++)
        {
            if(x % i == 0)
                return false;
        }
        
        return true;
    }
    
    public static bool IsCircularPrime(long x)
    {
        string aux = x.ToString();
        long y;
        int size = aux.Length;
        
        for(int i = 0; i < size; i++)
        {
            aux = aux.Substring(1, size - 1) + aux[0];
            y = Convert.ToInt64(aux);
            
            if(!IsPrime(y))
                return false;
        }
        
        return true;
    }
    
    
    public static void Main()
    {
        long x = 1234567890123;
        if(IsCircularPrime(x))
            Console.WriteLine(x + " is a circular prime");
            
        x = 113;
        if(IsCircularPrime(x))
            Console.WriteLine(x + " is a circular prime");
    }
}
