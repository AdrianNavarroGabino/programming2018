// Adrián Navarro Gabino

using System;

class Vehicle
{
    protected string brand;
    protected string model;
    protected double power;
    
    protected int speed;
    
    public void setBrand(string b) { brand = b; }
    public void setModel(string m) { model = m; }
    public void setPower(double p) { power = p; }
    
    public string getBrand() { return brand; }
    public string getModel() { return model; }
    public double getPower() { return power; }
    
    public Vehicle(string newBrand, string newModel, double newPower)
    {
        brand = newBrand;
        model = newModel;
        power = newPower;
        speed = 0;
    }
    
    public Vehicle()
    {
        brand = "Renault";
        model = "Clio";
        power = 140;
        speed = 0;
    }
    
    public void Start()
    {
        // TO DO
    }
    
    public void Accelerate()
    {
        speed += 5;
    }
    
    public void Brake()
    {
        speed -= 5;
    }
    
    public void ShowStatus()
    {
        Console.WriteLine("Brand: " + brand);
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Power: " + power + "HP");
        Console.WriteLine("Speed: " + speed + "km/h");
    }
}

class Car : Vehicle
{
    private byte doors;
    
    public void setDoors(byte d) { doors = d; }
    public byte setDoors() { return doors; }
    
    public Car(string newBrand, string newModel, double newPower,
        byte newDoors)
    {
        brand = newBrand;
        model = newModel;
        power = newPower;
        doors = newDoors;
        speed = 0;
    }
    
    public Car()
    {
        brand = "Renault";
        model = "Clio";
        power = 140;
        doors = 3;
        speed = 0;
    }
}

class CarTest
{
    static void Main()
    {
        Car myCar = new Car();
        
        myCar.Start();
    }
}
