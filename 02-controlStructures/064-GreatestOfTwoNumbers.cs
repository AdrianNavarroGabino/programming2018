// Greatest of two (ternary)
// Adrián Navarro Gabino

using System;

public class GreatestOfTwoNumbers
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter another number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        
        int greatest = num1 > num2 ? num1 : num2;
        
        Console.WriteLine("The greatest number is {0}", greatest);
    }
}
