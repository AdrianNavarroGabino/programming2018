// Find the hidden number (6 attempts + Random.Next)
// Adrián Navarro Gabino

using System;

public class GuessTheNumberTries
{
    public static void Main()
    {
        Random number = new Random();
        int hidden = number.Next(1,101);
        int n;
        int count = 1;
        
        do
        {
            Console.Write("Guess the number: ");
            n = Convert.ToInt32(Console.ReadLine());
            count++;
            
            if(n > hidden)
                Console.WriteLine("{0} is greater than the hidden number.", n);
            else if(n < hidden)
                Console.WriteLine("{0} is lower than the hidden number.", n);
        } while(count <= 6 && n != hidden);
        
        if(n == hidden)
            Console.WriteLine(
                "Congratulations! The hidden number is {0}", hidden);
        else
            Console.WriteLine("You have failed. Hidden number is {0}", hidden);
    }
}
