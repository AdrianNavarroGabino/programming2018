// Adrián Navarro Gabino

using System;

public class FunctionPowerIterative
{
    public static long Power(int b, int exp)
    {
        long power = b;
        
        for(int i = 1; i < exp; i++)
        {
            power *= b;
        }
        
        return power;
    }
    
    public static void Main()
    {
        Console.WriteLine(Power(2,10));
    }
}
