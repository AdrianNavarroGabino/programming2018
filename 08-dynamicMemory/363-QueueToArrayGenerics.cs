// Adrián Navarro Gabino

using System;
using System.Collections.Generic;

class QueueToArrayGenerics
{
    static void Main()
    {
        Queue<string> myQueue = new Queue<string>();
        
        string sentence;
        
        do
        {
            do
            {
                Console.Write("Enter a sentence: ");
                sentence = Console.ReadLine();
                
                if(sentence != "" && sentence != "exit")
                {
                    myQueue.Enqueue(sentence);
                }
            } while(sentence != "" && sentence != "exit");
            
            string[] myArray = myQueue.ToArray();
            for(int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        } while(sentence != "exit");
    }
}
