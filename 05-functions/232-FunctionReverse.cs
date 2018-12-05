// Adrián Navarro Gabino

using System;

public class FunctionReverse
{
    public static string Reverse(string entry)
    {
        string newChain = "";
        
        for(int i = 0; i < entry.Length; i++)
        {
            newChain += entry[entry.Length - i - 1];
        }
        
        return newChain;
    }
    
    
    public static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();
        
        Console.WriteLine(Reverse(sentence));
    }
}
