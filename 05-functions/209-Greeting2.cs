// Adrián Navarro Gabino

using System;

public class Greeting2
{
    public static void SayHello(string name)
    {
        Console.WriteLine("Hi, " + name);
    }
    
    public static void Main()
    {
        SayHello("Jorge");
        SayHello("Iván");
    }
}
