// Adrián Navarro Gabino

using System;

public class AbsoluteValue
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        int abs = number >= 0 ? number : -number;
        
        Console.WriteLine("Absolute value: {0}", abs);
    }
}
