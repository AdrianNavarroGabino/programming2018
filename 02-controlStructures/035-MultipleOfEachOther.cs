// Multiple of each other?
// Adrián Navarro Gabino

using System;

public class MultipleOfEachOther
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter another number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        
        if ( a % b == 0) 
            Console.WriteLine("{0} is a multiple of {1}", a, b);
        else
            Console.WriteLine("{0} is NOT a multiple of {1}", a, b);
            
        if ( b % a == 0) 
            Console.WriteLine("{0} is a multiple of {1}", b, a);
        else
            Console.WriteLine("{0} is NOT a multiple of {1}", b, a);
    }
}
