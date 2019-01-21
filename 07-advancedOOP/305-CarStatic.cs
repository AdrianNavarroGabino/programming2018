// Adrián Navarro Gabino

using System;

class Car
{
    protected static int wheels = 4;
    
    public int GetWheels() { return wheels; }
}

class CarTest
{
    static void Main()
    {
        Car c1 = new Car();
        Car c2 = new Car();
        
        Console.WriteLine(c1.GetWheels());
        Console.WriteLine(c2.GetWheels());
    }
}
