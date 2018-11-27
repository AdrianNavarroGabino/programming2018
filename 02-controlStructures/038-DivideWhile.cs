// Divide two numbers and, if the second one is 0, enter it again.
// Adrián Navarro Gabino

using System;

public class DivideWhile
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter another number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        
        while(num2 == 0)
        {
            Console.WriteLine("The second one cannot be ZERO");
            Console.Write("Enter another number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
        }
            
        Console.WriteLine(num1 / num2);
    }
}
