// Adrián Navarro Gabino

using System;
 
public class Node
{
    private int data;
    private Node leftSon;
    private Node rightSon;

    public Node(int data)
    {
        this.data = data;
    }

    public int GetData()
    {
        return data;
    }

    public void Insert(int data)
    {
        if (data == this.data)
            return;
              
        if (data > this.data)
        {
            if (rightSon == null)
                rightSon = new Node(data);
            else
                rightSon.Insert(data);
        }

        else
        {
            if (leftSon == null)
                leftSon = new Node(data);
            else
                leftSon.Insert(data);
        }
    }

    public void WriteSorted()
    {
        if (leftSon != null)
            leftSon.WriteSorted();

        Console.Write("{0} ", data);

        if (rightSon != null)
            rightSon.WriteSorted();
    }
}

public class Tree
{
    Node root;

    public void Write()
    {
        if (root != null)
            root.WriteSorted();
    }
     
    public void Insert(int data)
    {
        if (root == null)
            root = new Node(data);
        else
            root.Insert(data);
    }
    
    
    public static void Main()
    {
        Tree a = new Tree();
        a.Insert(5);
        a.Insert(3);
        a.Insert(7);
        a.Insert(2);
        a.Insert(4);
        a.Insert(8);
        a.Insert(9);
        a.Write();
    }
}
