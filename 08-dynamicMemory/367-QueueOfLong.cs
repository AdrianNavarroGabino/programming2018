// Adrián Navarro Gabino

using System;
using System.Collections.Generic;

class QueueOfLong
{
    static void Main()
    {
        Queue<long> data = new Queue<long>();

        string text;
        do
        {
            text = Console.ReadLine();
            if (text != "")
            {
                data.Enqueue(Convert.ToInt64(text));
            }
        } while (text != "");

        while(data.Count > 0)
        {
            Console.WriteLine(data.Dequeue());
        }
    }
}
