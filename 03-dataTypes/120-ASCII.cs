// Adrián Navarro Gabino

using System;

public class ASCII
{
    public static void Main()
    {
        Console.Write("Enter a number (0 to 9): ");
        char number = Convert.ToChar(Console.ReadLine());
        
        Console.WriteLine(Convert.ToInt32(number));
        
        Console.WriteLine(Convert.ToInt32(number) - 48);
        
        for(int i = 32; i <= 127; i++)
            Console.WriteLine(Convert.ToChar(i));
    }
}
