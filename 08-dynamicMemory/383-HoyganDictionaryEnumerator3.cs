// Adrián Navarro Gabino

using System;
using System.Collections.Generic;

public class HoyganDictionary3
{
    public static void Main()
    {
        Dictionary<string,string> myDictionary =
            new Dictionary<string,string>();
        myDictionary.Add("hoygan", "oigan");
        myDictionary.Add("porfabor", "por favor");
        myDictionary.Add("nesecito", "necesito");
        myDictionary.Add("alluda", "ayuda");
        myDictionary.Add("alludar", "ayudar");
        myDictionary.Add("grasias", "gracias");
        myDictionary.Add("ejersisio", "ejercicio");

        foreach (KeyValuePair<string,string> pair in myDictionary)
        {
            Console.WriteLine(pair.Key + " = " + pair.Value);
        }
    }
}
