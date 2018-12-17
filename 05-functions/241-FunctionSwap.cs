// Adrián Navarro Gabino

using System;

public class FunctionSwap
{
    public static void Swap(ref int num1, ref int num2)
    {
        int aux = num1;
        num1 = num2;
        num2 = aux;
    }
    
    public static void Main()
    {
        int a = 5;
        int b = 10;
        
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        
        Console.WriteLine();
        
        Swap(ref a, ref b);
        
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
    }
}
