// Adrián Navarro Gabino

using System;

public class FunctionMostrarRecuadroRedondeado
{
    public static void MostrarRecuadroRedondeado(int w, int h)
    {
        Console.WriteLine("/" + new string('-', w - 2) + "\\");
        
        for(int i = 0; i < h - 2; i++)
            Console.WriteLine("|" + new string(' ', w - 2) + "|");
        
        Console.WriteLine("\\" + new string('-', w - 2) + "/");
    }
    
    public static void Main()
    {
        MostrarRecuadroRedondeado(10, 3);
    }
}
