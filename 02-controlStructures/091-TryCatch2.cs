// Adrián Navarro Gabino

using System;

public class TryCatch2
{
    public static void Main()
    {
        try
        {
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
                
            Console.WriteLine("Division: {0}", num1/num2);
            Console.WriteLine("Product: {0}", num1*num2);
        }
        catch(DivideByZeroException)
        {
            Console.WriteLine("Error, can't divide by 0");
        }
        catch(FormatException)
        {
            Console.WriteLine("Are you kidding me?");
        }
    }
}
