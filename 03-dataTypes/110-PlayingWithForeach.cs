// Adrián Navarro Gabino

using System;

public class PlayingWithForeach
{
    public static void Main()
    {
        Console.WriteLine("Introduce una frase:");
        string frase = Console.ReadLine();
        
        for(int a = 0; a < frase.Length; a++)
            Console.Write("{0} ", frase[a]);
        
        Console.WriteLine();
        
        foreach(char a in frase)
            Console.Write(a + " ");
        
        Console.WriteLine();
    }
    
}
