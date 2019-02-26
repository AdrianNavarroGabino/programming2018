using System;
using System.Collections.Generic;

public class DifferentWords
{
    public static void Main()
    {
        Console.Write("Enter a sentence: ");
        string[] sentence = Console.ReadLine().ToLower().Split();
        List<string> list = new List<string>();

        foreach (string word in sentence)
        {
            if (! list.Contains(word))
                list.Add(word);
        }
        Console.WriteLine(list.Count + " different words");
    }
}
