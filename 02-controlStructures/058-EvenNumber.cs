// Is a number even?
// Adrián Navarro Gabino

using System;

public class EvenNumber
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        int even = 1;
        
        if(n % 2 == 1)
            even = 0;
        
        Console.WriteLine("even = {0}", even);
    }
}
