// Sqrt + try catch
// Adrián Navarro Gabino

using System;

public class SquareRoot
{
    public static void Main()
    {
        try
        {
            Console.Write("Enter a number: ");
            double num = Convert.ToDouble(Console.ReadLine());
            double root = Math.Sqrt(num);
        
            Console.WriteLine(root);
        }
        catch(FormatException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
