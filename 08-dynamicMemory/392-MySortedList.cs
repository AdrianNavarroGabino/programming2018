// Adrián Navarro Gabino

using System;
using System.Collections.Generic;

class MySortedList
{
    protected List<string> myList;
    protected int count;
    
    public int Count{
        get
        {
            return count;
        }
    }
    
    public MySortedList()
    {
        myList = new List<string>();
        count = 0;
    }
    
    public void Add(string s)
    {
        bool placed = false;
        
        if(count == 0)
        {
            myList.Add(s);
            count++;
        }
        else
        {
            for(int i = 0; i < count; i++)
            {
                if(s.CompareTo(myList[i]) <= 0 && !placed)
                {
                    myList.Insert(i,s);
                    placed = true;
                    count++;
                }
            }
            if(!placed)
            {
                myList.Add(s);
            }
        }
    }
    
    public string Get(int i)
    {
        return myList[i];
    }
    
    public void RemoveAt(int i)
    {
        myList.RemoveAt(i);
    }
}

class MySortedListTest
{
    static void Main()
    {
        MySortedList list = new MySortedList();
        
        list.Add("Hola");
        list.Add("Adiós");
        list.Add("Cómo estás");
        
        Console.WriteLine(list.Get(0));
        Console.WriteLine(list.Get(1));
        Console.WriteLine(list.Get(2));
    }
}
