// Adrián Navarro Gabino

using System;

public class Factorial
{
    public static long Fact(int i)
    {
        if(i == 0 || i == 1)
            return 1;
        return i * Fact(i - 1);
    }
    
    
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine(Fact(num));
    }
}
