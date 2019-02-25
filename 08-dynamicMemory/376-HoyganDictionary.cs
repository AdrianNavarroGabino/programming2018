// Adrián Navarro Gabino

using System;
using System.Collections;

public class HoyganDictionary
{
    public static void Main()
    {
        SortedList myDictionary = new SortedList();
        myDictionary.Add("hoygan", "oigan");
        myDictionary.Add("porfabor", "por favor");
        myDictionary.Add("nesecito", "necesito");
        myDictionary.Add("alluda", "ayuda");
        myDictionary.Add("alludar", "ayudar");
        myDictionary.Add("grasias", "gracias");
        myDictionary.Add("ejersisio", "ejercicio");

        Console.Write("Enter a sentence: ");
        string text = Console.ReadLine();

        string[] parts = text.ToLower().Split();

        foreach (string part in parts)
        {
            if (myDictionary.ContainsKey(part))
                Console.Write(myDictionary[part] + " ");
            else
                Console.Write(part + " ");
        }
    }
}
