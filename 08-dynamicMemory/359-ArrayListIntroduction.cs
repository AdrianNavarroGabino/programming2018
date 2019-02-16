// Adrián Navarro Gabino

using System;
using System.Collections;

class ArrayListIntroduction
{
    static void Main()
    {
        ArrayList myList = new ArrayList();
        
        string sentence;
        
        do
        {
            Console.Write("Enter a sentence: ");
            sentence = Console.ReadLine();
            
            if(sentence != "")
                myList.Add(sentence);
        } while(sentence != "");
        
        for(int i = myList.Count - 1; i >= 0; i--)
        {
            Console.WriteLine(myList[i]);
        }
    }
}
