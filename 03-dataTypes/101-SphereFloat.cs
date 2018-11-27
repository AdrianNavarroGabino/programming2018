// Area and volume of a sphere (float)
// Adrián Navarro Gabino

using System;

public class SphereFloat
{
    public static void Main()
    {
        float pi = 3.1415926535f;
        
        Console.Write("Radius? ");
        float r = Convert.ToSingle(Console.ReadLine());
        
        float s = 4*pi*r*r;
        float v = 4.0f/3.0f*pi*r*r*r;
        
        Console.WriteLine("Area = "+s);
        Console.WriteLine("Volume = "+v);
    }
}
