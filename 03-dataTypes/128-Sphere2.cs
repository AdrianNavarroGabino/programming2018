// Area and volume of a sphere (var)
// Adrián Navarro Gabino

using System;

class Sphere2
{
    static void Main()
    {
        const double PI = 3.1415926535;

        Console.Write("Enter radius: ");
        var radius = Convert.ToSingle(Console.ReadLine());

        var area = 4 * PI * radius * radius;
        Console.WriteLine("Area = " + area);

        var volume = 4.0f / 3.0f * PI * radius * radius * radius;
        Console.WriteLine("Volume = " + volume);
    }
}
