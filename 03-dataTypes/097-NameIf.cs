// Contact with strings (2) : testing equality
// Adrián Navarro Gabino

using System;

public class NameIf
{
    public static void Main()
    {
        Console.Write("What's your name? ");
        string name = Console.ReadLine();
        
        if(name == "Adrián")
            Console.WriteLine("Hello, " + name);
        else
            Console.WriteLine("I don't know you.");
    }
}
