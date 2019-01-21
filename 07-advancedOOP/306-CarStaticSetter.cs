// Adrián Navarro Gabino

using System;

class Car
{
    protected static int wheels = 4;
    
    public int GetWheels() { return wheels; }
    public void SetWheels(int newWheels) { wheels = newWheels; }
}

class CarTest
{
    static void Main()
    {
        Car c1 = new Car();
        Car c2 = new Car();
        
        Console.WriteLine(c1.GetWheels());
        Console.WriteLine(c2.GetWheels());
        
        c1.SetWheels(5);
        
        Console.WriteLine(c1.GetWheels());
        Console.WriteLine(c2.GetWheels());
    }
}
