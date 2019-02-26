// Adrián Navarro Gabino

using System;
using System.Collections.Generic;

class Enumerators
{
    static void Main()
    {
        Stack<int> myStack = new Stack<int>();
        
        string data;
        
        do
        {
            Console.Write("Enter a number: ");
            data = Console.ReadLine();
            
            if(data != "")
            {
                try
                {
                    myStack.Push(Convert.ToInt32(data));
                }
                catch(Exception)
                {
                }
            }
        } while(data != "");
        Console.WriteLine();
        
        IEnumerator<int> myEnumerator = myStack.GetEnumerator();
        
        bool found = false;
        
        while(myEnumerator.MoveNext())
        {
            int number = myEnumerator.Current;
            
            if(number == 5)
                found = true;
            
            Console.Write(number + " ");
        }
        Console.WriteLine();
        
        if(found)
            Console.WriteLine("5 was in the stack");
        else
            Console.WriteLine("5 was NOT in the stack");
    }
}
