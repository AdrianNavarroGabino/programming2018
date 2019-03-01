// Adrián Navarro Gabino

using System;

class QueueStr
{
    protected string[] myArray;
    protected int count;
    
    public QueueStr()
    {
        myArray = new string[1000];
        count = 0;
    }
    
    public string Peek()
    {
        return myArray[0];
    }
    
    public int Count
    {
        get
        {
            return count;
        }
    }
    
    public void Enqueue(string s)
    {
        myArray[count] = s;
        count++;
    }
    
    public String Dequeue()
    {
        string aux = myArray[0];
        for(int i = 0; i < myArray.Length - 1; i++)
        {
            myArray[i] = myArray[i + 1];
        }
        count--;
        return aux;
    }
}

class QueueTest
{
    static void Main()
    {
        QueueStr myQueue = new QueueStr();
        
        for(int i = 1; i <= 3; i++)
        {
            myQueue.Enqueue("Dato " + i);
        }
        
        Console.WriteLine(myQueue.Peek());
        
        Console.WriteLine(myQueue.Count);
        
        while(myQueue.Count > 0)
        {
            Console.WriteLine(myQueue.Dequeue());
        }
    }
}
