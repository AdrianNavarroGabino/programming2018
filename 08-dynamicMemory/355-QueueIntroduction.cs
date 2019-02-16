// Adrián Navarro Gabino

using System;
using System.Collections;

class QueueIntroduction
{
    static void Main()
    {
        Queue myQueue = new Queue();
        
        string sentence;
        
        do
        {
            Console.Write("Enter a sentence: ");
            sentence = Console.ReadLine();
            
            if(sentence != "")
            {
                myQueue.Enqueue(sentence);
            }
        } while(sentence != "");
        
        while(myQueue.Count > 0)
        {
            Console.WriteLine(myQueue.Dequeue());
        }
    }
}
