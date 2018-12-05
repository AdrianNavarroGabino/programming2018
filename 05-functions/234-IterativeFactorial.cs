// Adrián Navarro Gabino

using System;

public class IterativeFactorial
{
    public static long Fact(int num)
    {
        long factorial = 1;
        
        for(int i = 1; i <= num; i++)
        {
            factorial *= i;
        }
        
        return factorial;
    }
    
    
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine(Fact(num));
    }
}
