// Adrián Navarro Gabino

using System;

class Dog
{
    public virtual void Bark()
    {
        Console.Write("Woof");
    }
}

class Dalmatian : Dog
{
    public override void Bark()
    {
        Console.Write("Aww");
    }
}

class DogTest
{
    static void Main()
    {
        const int SIZE = 3;
        
        Dog[] d = new Dog[SIZE];
        
        for(int i = 0; i < SIZE - 1; i++)
        {
            d[i] = new Dog();
        }
        
        d[2] = new Dalmatian();
        
        for(int i = 0; i < SIZE - 1; i++)
        {
            d[i].Bark();
            Console.WriteLine();
        }
        
        d[2].Bark();
    }
}
