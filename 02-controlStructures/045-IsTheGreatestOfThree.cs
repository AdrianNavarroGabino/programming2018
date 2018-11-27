// Greatest of three numbers
// Adrian Navarro

using System;

public class IsTheGreatestOfThree
{
    public static void Main()
    {
        Console.Write("Enter number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number: ");
        int num3 = Convert.ToInt32(Console.ReadLine());
        
        int greatest = num1;
      
        if (num2 > greatest)
            greatest = num2;
            
        if (num3 > greatest)
                greatest = num3;
                
        Console.WriteLine("The greatest number is {0}", greatest);
    }
}
