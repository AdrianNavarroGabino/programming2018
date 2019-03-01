// Adrián Navarro Gabino

using System;

public class Sentences2
{
    public static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();
        
        for(int i = 0; i < sentence.Length - 1; i++)
            Console.Write(sentence[i] + " ");
        Console.WriteLine(sentence[sentence.Length - 1]);
    }
}
