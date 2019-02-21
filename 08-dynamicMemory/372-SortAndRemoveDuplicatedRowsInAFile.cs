// Adrián Navarro Gabino

using System;
using System.IO;
using System.Collections.Generic;

class SortAndRemoveDuplicatedRowsInAFile
{
    static void Main()
    {
        List<string> myList = new List<string>();
        
        string[] aux = File.ReadAllLines("hello.txt");
        Array.Sort(aux);
        
        for(int i = 0; i < aux.Length; i++)
            if(myList.Count == 0 ||
                    myList[myList.Count - 1] != aux[i])
                myList.Add(aux[i]);
        
        File.WriteAllLines("bye.txt", myList.ToArray());
    }
}
