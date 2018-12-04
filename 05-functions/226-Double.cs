// Function Double (no ref parameters)
// Adrián Navarro Gabino

using System;

public class Double
{
    public static int Duplicate(int n)
    {
        return n * 2;
    }
    
    
    public static void Main()
    {
        int number = 3;
        
        Console.WriteLine(number);
        
        number = Duplicate(number);
        
        Console.WriteLine(number);
    }
}
