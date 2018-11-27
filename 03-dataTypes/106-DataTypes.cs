// Adrián Navarro Gabino

using System;

public class DataTypes
{
    public static void Main()
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        
        Console.Write("Age: ");
        byte age = Convert.ToByte(Console.ReadLine());
        
        Console.Write("Birth year: ");
        ushort birthYear = Convert.ToUInt16(Console.ReadLine());
        
        Console.Write("Population of your country: ");
        ulong population = Convert.ToUInt64(Console.ReadLine());
        
    }
}
