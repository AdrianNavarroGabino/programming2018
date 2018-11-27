// Contact with exceptions
// Adrián Navarro Gabino

using System;

public class TryCatch
{
    public static void Main()
    {
        Console.WriteLine("Numer 1? ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Number 2? ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        try
        {
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1/num2);
        }
        catch(DivideByZeroException)
        {
            Console.WriteLine("You tried to divide by ZERO");
        }
        
        Console.WriteLine("{0} x {1} = {2}", num1, num2, num1*num2);
    }
}
