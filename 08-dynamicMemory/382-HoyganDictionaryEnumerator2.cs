// Adrián Navarro Gabino

using System;
using System.Collections;

public class HoyganDictionary2
{
    public static void Main()
    {
        Hashtable myDictionary = new Hashtable();
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
