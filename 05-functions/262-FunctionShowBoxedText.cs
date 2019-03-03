// Adrián Navarro Gabino

using System;

public class FunctionShowBoxedText
{
    public static void MostrarTextoRecuadrado(string sentence)
    {
        int size = sentence.Length + 4;
        string line = new string('-', size);
        line = "+" + line + "+";
        
        string text = "|  " + sentence + "  |";
        
        Console.WriteLine(line);
        Console.WriteLine(text);
        Console.WriteLine(line);
    }
    
    
    public static void Main(string[] args)
    {
        string sentence = "Hello";
        
        MostrarTextoRecuadrado(sentence);
    }
}
