// Finding a word in a sentence
// Adrián Navarro Gabino

using System;

public class WordInText
{
    public static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string[] sentence = Console.ReadLine().Split();
        
        bool repeated = false;
        string repeatedWord = "";
        
        for(int i = 0; i < sentence.Length; i++)
        {
            for(int j = i + 1; j < sentence.Length; j++)
            {
                if(sentence[i] == sentence[j])
                {
                    repeated = true;
                    repeatedWord = sentence[i];
                }
            }
        }
        
        if(repeated)
            Console.WriteLine("The repeated word is " + repeatedWord);
        else
            Console.WriteLine("There's NOT repeated words");
    }
}
