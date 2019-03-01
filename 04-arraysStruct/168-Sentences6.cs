// Adrián Navarro Gabino

using System;

public class Sentences6
{
    public static void Main()
    {
        Console.Write("Enter your name: ");
        string sentence = Console.ReadLine();
        
        string upperSentence = sentence.ToUpper();
        Console.WriteLine(upperSentence);
        
        string lowerSentence = sentence.ToLower();
        Console.WriteLine(lowerSentence);
        
        string deletedSentence = sentence.Remove(1,2);
        Console.WriteLine(deletedSentence);
        
        string appendSentence = sentence.Insert(2,"yo");
        Console.WriteLine(appendSentence);
            
        string replacedSentence = sentence.Replace(' ', '_');
        Console.WriteLine(replacedSentence);
        
        string startSpacesSentence = sentence.TrimStart();
        Console.WriteLine(startSpacesSentence);
        
        string endSpacesSentence = sentence.TrimEnd();
        Console.WriteLine(endSpacesSentence);
        
        string aASentence = sentence.Replace('a', 'A');
        Console.WriteLine(aASentence);
        
        string[] splitSentence = sentence.Split();
        foreach(string s in splitSentence)
            Console.WriteLine(s);
    }
}
