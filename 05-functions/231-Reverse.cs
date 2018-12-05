// Adrián Navarro Gabino

using System;

public class Invertido
{
    public static void WriteReverse(string entry)
    {
        for(int i = 0; i < entry.Length; i++)
        {
            Console.Write(entry[entry.Length - i - 1]);
        }
        
        Console.WriteLine();
    }
    
    
    public static void Main()
    {
        WriteReverse("Hello");
    }
}
