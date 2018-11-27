// Amount of digits in a positive integer number
// Adrián Navarro Gabino

using System;

public class Digits
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        int digits = 1;
        
        while(n / 10 != 0)
        {
            digits++;
            n = n / 10;
        }
        
        Console.WriteLine("{0} digits", digits);
    }
}
