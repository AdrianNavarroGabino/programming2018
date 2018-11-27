// A program that prints Hello 10 times.
// Adrián Navarro Gabino

using System;

public class Hello10Times
{
    public static void Main()
    {
		int count = 0;
		
        while(count < 10)
        {
            count++;
            Console.Write("Hello ");
        }
        
        Console.WriteLine();
    }
}
