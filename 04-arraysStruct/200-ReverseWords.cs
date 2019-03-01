// Adrián Navarro Gabino

using System;

public class ReverseWords
{
    public static void Main()
    {
        Console.WriteLine("Enter a sentence to reverse:");
        string[] sentence = Console.ReadLine().Split();
        
        for(int j = sentence.Length - 1; j > 0; j--)
        {
            Console.Write(sentence[j] + " ");
        }
        Console.WriteLine(sentence[0]);
    }
}
