// Finding a word in a sentence
// Adrián Navarro Gabino

using System;

public class WordInText
{
    public static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string[] sentence = Console.ReadLine().Split();
        Console.WriteLine("Enter a word:");
        string word = Console.ReadLine();
        
        bool found = false;
        
        foreach(string p in sentence)
            if(word == p)
                found = true;
        
        if(found)
            Console.WriteLine(word + " is in the text");
        else
            Console.WriteLine(word + " is NOT in the text");
    }
}
