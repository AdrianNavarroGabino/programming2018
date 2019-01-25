// Adrián Navarro Gabino

using System;

class Dog
{
    public void Bark()
    {
        Console.Write("Woof");
    }
}

class DogTest
{
    static void Main()
    {
        const int SIZE = 3;
        
        Dog[] d = new Dog[SIZE];
        
        for(int i = 0; i < SIZE; i++)
        {
            d[i] = new Dog();
        }
        
        for(int i = 0; i < SIZE; i++)
        {
            d[i].Bark();
            Console.WriteLine();
        }
    }
}
