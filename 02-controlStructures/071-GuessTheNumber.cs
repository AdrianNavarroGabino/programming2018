// Guess the hidden number
// Adrián Navarro Gabino

using System;

public class GuessTheNumber
{
    public static void Main()
    {
        int hidden = 70;
        int n;
        
        do
        {
            Console.Write("Guess the number: ");
            n = Convert.ToInt32(Console.ReadLine());
            
            if(n > hidden)
                Console.WriteLine("{0} is greater than the hidden number.", n);
            else if(n < hidden)
                Console.WriteLine("{0} is lower than the hidden number.", n);
        } while(n != hidden);
        
        Console.WriteLine("Congratulations! The hidden number is {0}", hidden);
    }
}
