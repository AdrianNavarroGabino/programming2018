// Power
// Adrián Navarro Gabino

using System;

public class Power
{
    public static void Main()
    {
        int power = 1;
        
        Console.Write("Base? ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Exp? ");
        int exp = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 1; i <= exp; i++)
            power = power * b;
        
        Console.WriteLine("Power: {0}", power);
    }
}
