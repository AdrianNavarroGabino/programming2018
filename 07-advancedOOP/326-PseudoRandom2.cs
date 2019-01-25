// Adrián Navarro Gabino

using System;

class PseudoRandom
{
    public int Get0To999()
    {
        return DateTime.Now.Millisecond;
    }
}

class Test
{
    static void Main()
    {
        PseudoRandom rn = new PseudoRandom();
        
        Console.WriteLine(rn.Get0To999());
    }
}
