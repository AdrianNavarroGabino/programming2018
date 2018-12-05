// Adrián Navarro Gabino

using System;

public class FunctionReverseRecursive
{
    public static string Reverse(string entry)
    {
        if(entry.Length <= 1)
        {
            return entry;
        }
        else
        {
            return entry[entry.Length - 1] +
                Reverse(entry.Substring(0, entry.Length -1));
        }
    }
    
    
    public static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();
        
        Console.WriteLine(Reverse(sentence));
    }
}
