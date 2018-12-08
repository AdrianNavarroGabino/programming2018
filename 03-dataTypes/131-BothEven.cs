// Bool + ternary
// Adrián Navarro Gabino

using System;

public class BothEven
{
    public static void Main()
    {
        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        
        bool boothEven;
        
        if( (num1 % 2 == 0) && (num2 % 2 == 0) )
            boothEven = true;
        else
            boothEven = false;
            
        Console.WriteLine(boothEven);
        
        boothEven = (num1 % 2 == 0) && (num2 % 2 == 0);
        
        Console.WriteLine(boothEven);
    }
}
