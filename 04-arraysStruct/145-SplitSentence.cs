// Split a sentence
// Adrián Navarro Gabino

using System;

public class SplitSentence
{
    public static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string frase = Console.ReadLine();
         
        string[] palabras = frase.Split();
        
        Console.WriteLine("Split sentence:");
        
        foreach(string palabra in palabras)
            Console.Write(palabra + "\n");
    }
}
