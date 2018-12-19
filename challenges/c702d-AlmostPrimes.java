// Adrián Navarro Gabino

import java.util.*;

public class AlmostPrimes
{
    public static boolean isAlmostPrime(int number)
    {
        for(int i = 2; i <= Math.sqrt(number); i++)
            if(number % i == 0 && isPrime(i))
                if(isPrime(number / i))
                    return true;
        
        return false;
    }
    
    public static boolean isPrime(int number)
    {
        for(int i = 2; i <= Math.sqrt(number); i++)
        {
            if(number % i == 0)
                return false;
        }
        
        return true;
    }
    
    
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);
        
        int cases = sc.nextInt();
        
        for(int currentCase = 0; currentCase < cases; currentCase++)
        {
            int lowerLimit = sc.nextInt();
            int upperLimit = sc.nextInt();
            
            int count = 0;
            
            for(int i = lowerLimit; i <= upperLimit; i++)
            {
                if(isAlmostPrime(i))
                    count++;
            }
            
            System.out.println(count);
        }
    }
}
