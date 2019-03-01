// Adrián Navarro Gabino

using System;
using System.Text;

public class VariableSentence
{
    public static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        StringBuilder sentence = new StringBuilder(Console.ReadLine());
        
        for(int i = 0; i < sentence.Length; i++)
        {
            if(sentence[i] == ' ')
            {
                sentence[i] = '_';
            }
        }
        
        Console.WriteLine(sentence);
    }
}
