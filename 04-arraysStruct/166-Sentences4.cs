// Adrián Navarro Gabino

using System;

public class Sentences4
{
    public static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        
        for(int i = 1; i <= name.Length; i++)
        {
            Console.WriteLine(name.Substring(0,i));
        }
    }
}
