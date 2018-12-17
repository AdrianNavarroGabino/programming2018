// Adrián Navarro Gabino

using System;

public class FunctionPowerRecursive
{
    public static long Power(int b, int exp)
    {
        if(exp == 0)
        {
            return 1;
        }
        
        return b * Power(b, exp - 1);
    }
    
    public static void Main()
    {
        Console.WriteLine(Power(5,3));
    }
}
