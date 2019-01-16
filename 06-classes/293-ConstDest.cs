// Adrián Navarro Gabino

using System;

class ConstDest
{
    public ConstDest()
    {
        Console.WriteLine("Este es el constructor 1");
    }
    
    public void Pausar()
    {
        Console.Write("Presiona enter para continuar:");
        Console.ReadLine();
    }
    
    ~ConstDest()
    {
        Console.WriteLine("Este es el destructor 1");
    }
}

class ConstDest2 : ConstDest
{
    public ConstDest2()
    {
        Console.WriteLine("Este es el constructor 2");
    }
    
    ~ConstDest2()
    {
        Console.WriteLine("Este es el destructor 2");
    }
}


class ConstDestTest
{
    static void Main()
    {
        ConstDest cd = new ConstDest();
        
        cd.Pausar();
        
        ConstDest2 cd2 = new ConstDest2();
        
        cd2.Pausar();
    }
}
