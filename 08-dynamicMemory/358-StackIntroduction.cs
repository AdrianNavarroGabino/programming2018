// Adrián Navarro Gabino

using System;
using System.Collections;

class StackIntroduction
{
    static void Main()
    {
        Stack myStack = new Stack();
        
        string sentence;
        
        do
        {
            Console.Write("Enter a sentence: ");
            sentence = Console.ReadLine();
            
            if(sentence != "")
            {
                myStack.Push(sentence);
            }
        } while(sentence != "");
        
        while(myStack.Count > 0)
        {
            Console.WriteLine(myStack.Pop());
        }
    }
}
