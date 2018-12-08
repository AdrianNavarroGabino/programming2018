// Area and volume of a sphere (float + const)
// Adrián Navarro Gabino

using System;

class Sphere
{
    static void Main()
    {
        const float PI = 3.1415926535f;

        Console.Write("Enter radius: ");
        float radius = Convert.ToSingle(Console.ReadLine());

        float area = 4 * PI * radius * radius;
        Console.WriteLine("Area = " + area);
        
        float volume = 4.0f / 3.0f * PI * radius * radius * radius;
        Console.WriteLine("Volume = " + volume);
    }
}
