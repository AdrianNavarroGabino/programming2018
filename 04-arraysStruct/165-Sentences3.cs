// Adrián Navarro Gabino

using System;

public class Sentences3
{
    public static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();
        
        string reverseSentence = "";
        
        for(int i = sentence.Length - 1; i >= 0; i--)
            reverseSentence += sentence[i];
        Console.WriteLine(reverseSentence);
        
        reverseSentence = "";
        
        foreach(char c in sentence)
            reverseSentence = c + reverseSentence;
        Console.WriteLine(reverseSentence);
    }
}
