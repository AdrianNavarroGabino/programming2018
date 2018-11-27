// Multiple of 2 and 3? (if)
// Adrián Navarro Gabino

using System;

public class MultiplesOf2Or3If
{
    public static void Main()
    {
        Console.Write("Enter a number (1 to 10): ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        if(n == 1 || n == 5 || n == 7)
            Console.WriteLine("NOT a multiple of 2 nor 3");
        else if(n == 2 || n == 4 || n == 8 || n == 10)
            Console.WriteLine("Multiple of 2");
        else if(n == 3 || n == 9)
            Console.WriteLine("Multiple of 3");
        else if(n == 6)
            Console.WriteLine("Multiple of 2 and 3");
        else
            Console.WriteLine("Incorrect number");
    }
}
