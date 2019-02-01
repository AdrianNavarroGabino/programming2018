// Adrián Navarro Gabino

using System;

abstract class Device
{
    public double ProcessingSpeed { get; set; }
    public double ScreenSize { get; set; }
    
    public Device(double processingSpeed, double screenSize)
    {
        ProcessingSpeed = processingSpeed;
        ScreenSize = screenSize;
    }
    
    public override string ToString()
    {
        return ProcessingSpeed + "MHZ, " + ScreenSize + " inches";
    }
}

abstract class TactileDevice : Device
{
    public TactileDevice(double processingSpeed, double screenSize) :
        base(processingSpeed, screenSize)
    {
    }
}

abstract class DeviceWithKeyboard : Device
{
    public DeviceWithKeyboard(double processingSpeed, double screenSize) :
        base(processingSpeed, screenSize)
    {
    }
}

class Smartphone : TactileDevice
{
    public Smartphone(double processingSpeed, double screenSize) :
        base(processingSpeed, screenSize)
    {
    }
    
    public override string ToString()
    {
        return "Smartphone, " + base.ToString();
    }
}

class Tablet : TactileDevice
{
    public Tablet(double processingSpeed, double screenSize) :
        base(processingSpeed, screenSize)
    {
    }
    
    public override string ToString()
    {
        return "Tablet, " + base.ToString();
    }
}

class Computer : DeviceWithKeyboard
{
    public Computer(double processingSpeed, double screenSize) :
        base(processingSpeed, screenSize)
    {
    }
    
    public override string ToString()
    {
        return "Computer, " + base.ToString();
    }
}

class DeviceTest
{
    static void Main()
    {
        const int SIZE = 3;
        Device[] d = new Device[SIZE];
        d[0] = new Smartphone(1.5, 5.6);
        d[1] = new Tablet(2.3, 8.9);
        d[2] = new Computer(4.4, 45.9);
        
        foreach(Device dev in d)
        {
            Console.WriteLine(dev);
        }
        
    }
}
