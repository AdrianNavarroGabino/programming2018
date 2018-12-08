// Adrián Navarro Gabino

using System;

public class ByteToBin
{
    public static void Main()
    {
        Console.Write("Number? ");
        byte number = Convert.ToByte(Console.ReadLine());
        
        Console.WriteLine("Binary: " + Convert.ToString(number, 2));
    }
}
