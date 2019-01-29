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
    public override string ToString()
    {
        return base.ToString() + "\nDoors: " + Doors;
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
    
    public override string ToString()
    {
        return base.ToString() + "\nType of license: " + TypeOfLicense;
    }
}

class CarTest
{
    static void Main()
    {
        const int SIZE = 1000;
        Vehicle[] v = new Vehicle[SIZE];
        int count = 0;
        
        int option1 = 0;
        int option2 = 0;
        
        do
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Enter a vehicle");
            Console.WriteLine("2. Search a vehicle");
            Console.WriteLine("3. Show all");
            Console.WriteLine("4. Quit");
            option1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            if(option1 == 1 || option1 == 2)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Car");
                Console.WriteLine("2. Motorbike");
                option2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
            
            if(option1 == 1)
            {
                Console.Write("Enter the brand: ");
                string brand = Console.ReadLine();
                Console.Write("Enter the model: ");
                string model = Console.ReadLine();
                Console.Write("Enter the power: ");
                double power = Convert.ToDouble(Console.ReadLine());
                if(option2 == 1)
                {
                    Console.Write("Enter the number of doors: ");
                    byte doors = Convert.ToByte(Console.ReadLine());
                    v[count] = new Car(brand, model, power, doors);
                }
                else if(option2 == 2)
                {
                    Console.Write("Enter the type of license: ");
                    string license = Console.ReadLine();
                    v[count] = new Motorbike(
                        brand, model, power, license);
                }
                
                count++;
            }
            
            else if(option1 == 2)
            {
                Console.Write("Enter the vehicle to search: ");
                string search = Console.ReadLine();
                
                bool found = false;
                
                for(int i = 0; i < count; i++)
                {
                    if(v[i].ToString().Contains(search))
                    {
                        Console.WriteLine(v[i]);
                        found = true;
                    }
                }
                
                if(!found)
                {
                    Console.WriteLine("This vehicle is not in the " +
                        "database");
                }
            }
            
            else if(option1 == 3)
            {
                for(int i = 0; i < count; i++)
                {
                    Console.WriteLine(v[i]);
                    Console.WriteLine();
                }
            }
            
            else
            {
                Console.WriteLine("Bye!");
            }
        } while(option1 == 1 || option1 == 2 || option1 == 3);
    }
}
