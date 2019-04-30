// Adrián Navarro Gabino

using System;

class Date3
{
    static void Main()
    {
        DateTime birth = new DateTime(1994,5,9);
        
        TimeSpan dif = DateTime.Now.Subtract(birth);
        
        Console.WriteLine("I have lived " + dif.Days + " days");
    }
}
