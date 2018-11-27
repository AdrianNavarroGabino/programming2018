// How many numbers are positive?
// Adrián Navarro Gabino

using System;

public class AmountOfPositives
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter another number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        
        if(num1 > 0 || num2 > 0)
        {
            if(num1 > 0 && num2 > 0)
                Console.WriteLine("The two of them are positive.");
            else
                Console.WriteLine("One of them is positive");
        }
        else
            Console.WriteLine("None of them are positive");
    }
}
