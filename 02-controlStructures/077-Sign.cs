// Adrián Navarro Gabino

using System;

public class Sign
{
    public static void Main()
    {
        int sgn;
        
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        sgn = number > 0 ? 1 : (number < 0 ? -1 : 0);

        
        Console.WriteLine("Sign of {0}: {1}", number, sgn);
    }
}
