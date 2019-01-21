// Adrián Navarro Gabino

using System;

public class Hardware
{
    public static void ClearScreen()
    {
        for(int i = 0; i < 25; i++)
            Console.WriteLine();
    }
}

class HardwareTest
{
    static void Main()
    {
        Console.WriteLine("Hello!");
        Console.WriteLine("Press any key to clear the screen:");
        Console.ReadLine();
        Hardware.ClearScreen();
    }
}
