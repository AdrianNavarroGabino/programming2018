// Is a number even? (ternary)
// Adrián Navarro Gabino

using System;

public class EvenNumber2
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        int even = n % 2 == 0 ? 1 : 0;
        
        Console.WriteLine("even is {0}", even);
    }
}
