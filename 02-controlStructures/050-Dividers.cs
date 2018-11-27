// Dividers of a number
// Adrián Navarro Gabino

using System;

public class Dividers
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Its dividers are ");
        for(int i = 1; i <= n; i++)
        {
            if(n % i == 0)
                Console.Write("{0} ", i);
        }
        Console.WriteLine();
    }
}
