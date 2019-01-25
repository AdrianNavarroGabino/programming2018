// Adrián Navarro Gabino

using System;

class PseudoRandom
{
    public static int Get0To999()
    {
        return DateTime.Now.Millisecond;
    }
}

class Test
{
    static void Main()
    {
        Console.WriteLine(PseudoRandom.Get0To999());
    }
}
