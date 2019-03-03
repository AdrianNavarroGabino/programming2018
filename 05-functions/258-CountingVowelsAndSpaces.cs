// Adrián Navarro Gabino

using System;

public class CountingVowelsAndSpaces
{
    public static void ContarVE(string sentence, ref int vowels, ref int spaces)
    {
        sentence = sentence.ToLower();
        
        for(int i = 0; i < sentence.Length; i++)
        {
            switch(sentence[i])
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u': vowels++; break;
                case ' ': spaces++; break;
            }
        }
    }
    public static void Main()
    {
        int vowels = 0;
        int spaces = 0;
        
        string sentence = "Esta es una frase";
        
        ContarVE(sentence, ref vowels, ref spaces);
        
        Console.WriteLine("Vowels: " + vowels);
        Console.WriteLine("Spaces: " + spaces);
    }
}
