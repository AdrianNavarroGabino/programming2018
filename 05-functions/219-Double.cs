// Adrián Navarro Gabino

using System;

public class Double
{
    public static void Duplicate(ref int n)
    {
        n *= 2;
    }
    
    
    public static void Main()
    {
        int number = 3;
        
        Console.WriteLine(number);
        
        Duplicate(ref number);
        
        Console.WriteLine(number);
    }
}
