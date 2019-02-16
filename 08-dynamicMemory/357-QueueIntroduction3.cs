// Adrián Navarro Gabino

using System;
using System.Collections;

class QueueIntroduction3
{
    static void Main()
    {
        Queue myQueue = new Queue();
        
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
            
            Object[] myArray = myQueue.ToArray();
            for(int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        } while(sentence != "exit");
    }
}
