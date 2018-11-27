// Area of a circle (float data type)
// Adrián Navarro Gabino

using System;

public class CircleArea2
{
    public static void Main()
    {
        Console.Write("Radius? ");
        float r = Convert.ToSingle(Console.ReadLine());
        float pi = 3.1415926535f;
        
        Console.WriteLine("Area: {0}", pi*r*r);
    }
}
