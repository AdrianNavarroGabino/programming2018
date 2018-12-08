// Adrián Navarro Gabino

using System;

public class HexToDec
{
    public static void Main()
    {
        Console.Write("Hex number: ");
        string number = Console.ReadLine();
        
        Console.WriteLine("Decimal: " + Convert.ToByte(number, 16));
    }
}
