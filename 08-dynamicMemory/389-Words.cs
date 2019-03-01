// Adrián Navarro Gabino

using System;
using System.IO;
using System.Collections.Generic;

class Words
{
    static void Main()
    {
        List<string> myList = new List<string>();
        
        string[] aux = File.ReadAllLines("words.txt");
        string[] aux2 = File.ReadAllLines("words2.txt");
        
        Dictionary<string,bool> words = new Dictionary<string,bool>();
        Dictionary<string,bool> words2 = new Dictionary<string,bool>();
        
        foreach(string s in aux)
            if(!words.ContainsKey(s))
                words.Add(s, true);
        foreach(string s in aux2)
            if(!words2.ContainsKey(s))
                words2.Add(s, true);
        
        DateTime start = DateTime.Now;
        foreach(string w in aux)
        {
            if(words2.ContainsKey(w))
                words.Remove(w);
        }
        
        Console.WriteLine(words.Count);
        Console.WriteLine(DateTime.Now - start);
    }
}
