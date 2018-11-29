// Adrián Navarro Gabino

using System;

public class Greeting3
{
    public static void SayHelloManyTimes(string name, int times)
    {
        for(int i = 0; i < times; i++)
        {
            Console.WriteLine("Hi, " + name);
        }
    }
    
    public static void Main()
    {
        SayHelloManyTimes("Jorge", 4);
    }
}
