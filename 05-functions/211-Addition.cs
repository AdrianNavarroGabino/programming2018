// Adrián Navarro Gabino

using System;

public class AdditionFunction
{
    public static int Addition(int num1, int num2)
    {
        return num1 + num2;
    }
    
    public static void Main()
    {
        int total1 = Addition(4,6);
        int total2 = Addition(-6,89);
        
        Console.WriteLine(total1);
        Console.WriteLine(total2);
    }
}
