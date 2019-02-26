// Adrián Navarro Gabino

using System;
using System.Collections;

public class HoyganDictionaryEnumerator
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
        
        IDictionaryEnumerator myEnum = myDictionary.GetEnumerator();

        while (myEnum.MoveNext())
        {
            Console.WriteLine(myEnum.Key + " = " + myEnum.Value);
        }
    }
}
