// Adrián Navarro Gabino

using System;

public class DoubleFor
{
    public static void Main()
    {
        for(int i = 1, j = 20; i <= 10 && j <= 30; i++, j = j + 2)
            Console.WriteLine("i is {0}, j is {1}", i, j);
    }
}
