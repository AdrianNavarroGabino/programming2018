// Adrián Navarro Gabino

using System;
using System.Collections.Generic;

class EliminateDuplicatedRows
{
    static void Main()
    {
        List<string> myList = new List<string>();
        
        string text;
        
        do
        {
            Console.Write("Enter a text: ");
            text = Console.ReadLine();
            
            if(text != "")
                if(myList.Count == 0 ||
                        myList[myList.Count - 1] != text)
                    myList.Add(text);
        } while(text != "");
        
        for(int i = 0; i < myList.Count; i++)
            Console.WriteLine(myList[i]);
    }
}
