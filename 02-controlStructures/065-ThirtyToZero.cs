// Countdown from 30 to 0, step 3
// Adrián Navarro Gabino

using System;

public class ThirtyToZero
{
    public static void Main()
    {
        for(int i = 30; i >= 0; i = i - 3)
            Console.Write("{0} ", i);
        Console.WriteLine();
    }
}
