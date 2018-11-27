// Contact with strings
// Adrián Navarro Gabino

using System;

public class Name
{
    public static void Main()
    {
        Console.Write("What's your name? ");
        string name = Console.ReadLine();
        
        Console.WriteLine("Hello, {0}.", name);
    }
}
