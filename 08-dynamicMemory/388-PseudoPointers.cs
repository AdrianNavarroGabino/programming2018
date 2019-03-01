// Adrián Navarro Gabino

using System;

class PseudoPointers
{
    class Node
    {
        public string Data { get; set;  }
        public Node Next { get; set;  }
    }

    static Node first;

    static void Add(string text)
    {
        Node newNode = new Node();
        newNode.Data = text;
        newNode.Next = null;

        if (first == null)
            first = newNode;
        else
        {
            Node current = first;
            while (current != null)
            {
                if (current.Next == null)
                {
                    current.Next = newNode;
                    return;
                }
                else
                    current = current.Next;
            }
        }
    }

    static void DisplayList()
    {
        Node current;

        current = first;
        while (current != null)
        {
            Console.WriteLine(current.Data);
            current = current.Next;
        }
    }

    static void Main()
    {
        first = null;
        Add("Hello");
        Add("Bye");
        Add("See you");
        DisplayList();
    }
}
