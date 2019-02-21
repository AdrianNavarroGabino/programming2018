// Adrián Navarro Gabino

using System;
using System.Collections;

class DictionarySpanishEnglish
{
    static void Main()
    {
        SortedList myDictionary = new SortedList();
        
        myDictionary.Add("hola", "hello");
        myDictionary.Add("adiós", "good bye");
        myDictionary.Add("rojo", "red");
        myDictionary.Add("azul", "blue");
        myDictionary.Add("perro", "dog");
        myDictionary.Add("gato", "cat");
        myDictionary.Add("casa", "house");
        myDictionary.Add("cocina", "kitchen");
        myDictionary.Add("amarillo", "yellow");
        myDictionary.Add("mascota", "pet");
        
        Console.Write("Enter the word in spanish to translate: ");
        string word = Console.ReadLine().ToLower();
        
        if(myDictionary.ContainsKey(word))
            Console.WriteLine(myDictionary[word]);
        else
            Console.WriteLine("Not found");
    }
}
