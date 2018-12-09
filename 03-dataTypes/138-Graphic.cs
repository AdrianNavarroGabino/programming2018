// Adrián Navarro Gabino

using System;

public class Graphic
{
    public static void Main()
    {
        for(int x = 30; x >= -30; x--)
        {
            Console.SetCursorPosition(x + 30, (int)Math.Sqrt(Math.Abs(30) * 10) 
                - (int)Math.Sqrt(Math.Abs(x) * 10));
            Console.WriteLine("*");
        }
        Console.SetCursorPosition(0,(int)Math.Sqrt(Math.Abs(30) * 10) + 1);
        Console.WriteLine();
    }
}
