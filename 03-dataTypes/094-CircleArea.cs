// Area of a circle (double data type)
// Adrián Navarro Gabino

using System;

public class CircleArea
{
    public static void Main()
    {
        Console.Write("Radius? ");
        double r = Convert.ToDouble(Console.ReadLine());
        double pi = 3.1415926535;
        
        Console.WriteLine("Area: {0}", pi*r*r);
    }
}
