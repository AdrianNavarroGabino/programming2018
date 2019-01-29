// Adrián Navarro Gabino

using System;

class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public double Power { get; set; }
    public int Speed { get; set; }
    
    public Vehicle(string newBrand, string newModel, double newPower)
    {
        Brand = newBrand;
        Model = newModel;
        Power = newPower;
        Speed = 0;
    }
    
    public void Start()
    {
        Console.WriteLine("The vehicle is ready to go");
    }
    
    public void Accelerate()
    {
        Speed += 5;
    }
    
    public void Brake()
    {
        Speed -= 5;
    }
    
    public override string ToString()
    {
        return "Brand: " + Brand + "\nModel: " + Model + "\nPower: " +
            Power + "HP" + "\nSpeed: " + Speed + "km/h";
    }
}

class Car : Vehicle
{
    public byte Doors { get; set; }
    
    public Car(string newBrand, string newModel, double newPower,
        byte newDoors) : base(newBrand, newModel, newPower)
    {
        Doors = newDoors;
    }
}

class Motorbike : Vehicle
{
    public string TypeOfLicense { get; set; }
    
    public Motorbike(string newBrand, string newModel, double newPower,
        string typeOfLicense) : base(newBrand, newModel, newPower)
    {
        TypeOfLicense = typeOfLicense;
    }
}

class CarTest
{
    static void Main()
    {
        Car myCar = new Car("Brand","Model",1000,4);
        
        myCar.Start();
    }
}
