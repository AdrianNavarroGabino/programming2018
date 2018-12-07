// Adrián Navarro Gabino

using System;

public class Rectangle
{
    public static void Main()
    {
        Console.Write("Height: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Width: ");
        double b = Convert.ToDouble(Console.ReadLine());
        
        double s = a * b;
        double p = 2 * a + 2 * b;
        double d = Math.Sqrt(a * a + b * b);
        
        Console.WriteLine("Area: {0}", s);
        Console.WriteLine("Perimeter: {0}", p);
        Console.WriteLine("Diagonal: {0}", d);
    }
}
