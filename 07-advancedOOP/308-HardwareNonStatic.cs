// Adrián Navarro Gabino

using System;

public class Hardware2
{
    public void ClearScreen()
    {
        for(int i = 0; i < 25; i++)
            Console.WriteLine();
    }
}

class HardwareTest
{
    static void Main()
    {
        Hardware2 h = new Hardware2();
        
        Console.WriteLine("Hello!");
        Console.WriteLine("Press any key to clear the screen:");
        Console.ReadLine();
        h.ClearScreen();
    }
}
