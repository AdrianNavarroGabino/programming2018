// A program that prints the numbers from 1 to 10 with a while loop.
// Adrián Navarro Gabino

using System;

public class CountFrom1To10
{
    public static void Main()
    {
        int count = 0;
        
        while(count < 10)
        {
            count++;
            Console.WriteLine("{0} ", count);
        }
    }
}
