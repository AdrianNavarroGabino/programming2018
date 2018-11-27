// Ask for 3 letters and display them reversed
// Adrián Navarro Gabino

using System;

public class PlayingWithChar2
{
    public static void Main()
    {
        Console.Write("Letter 1: ");
        char letter1 = Convert.ToChar(Console.ReadLine());
        Console.Write("Letter 2: ");
        char letter2 = Convert.ToChar(Console.ReadLine());
        Console.Write("Letter 3: ");
        char letter3 = Convert.ToChar(Console.ReadLine());
        
        Console.WriteLine("{0}\n\"{1}{2}\"", letter3, letter2, letter1);
    }
}
