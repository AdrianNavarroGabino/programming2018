// Adrián Navarro Gabino

using System;
using System.Collections.Generic;

class StackStr
{
    protected List<string> myList;
    
    public StackStr()
    {
        myList = new List<string>();
    }
    
    public string Peek()
    {
        return myList[0];
    }
    
    public int Count
    {
        get
        {
            return myList.Count;
        }
    }
    
    public void Push(string s)
    {
        myList.Insert(0, s);
    }
    
    public String Pop()
    {
        string aux = myList[0];
        myList.RemoveAt(0);
        return aux;
    }
}

class StackTest
{
    static void Main()
    {
        StackStr myStack = new StackStr();
        
        for(int i = 1; i <= 3; i++)
        {
            myStack.Push("Data " + i);
        }
        
        Console.WriteLine(myStack.Peek());
        
        Console.WriteLine(myStack.Count);
        
        while(myStack.Count > 0)
        {
            Console.WriteLine(myStack.Pop());
        }
    }
}
