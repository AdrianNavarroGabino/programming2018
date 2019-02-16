// Adrián Navarro Gabino

using System;
using System.Collections;

class QueueIntroduction2
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
            
            while(myQueue.Count > 0)
            {
                Console.WriteLine(myQueue.Dequeue());
            }
        } while(sentence != "exit");
    }
}
