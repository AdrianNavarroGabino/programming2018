// Adrián Navarro Gabino

using System;
using System.Collections.Generic;

class StackOfDoublesGenerics
{
    static void Main()
    {
        const int SIZE = 10;
        Stack<double> myStack = new Stack<double>();
        
        for(int i = 0; i < SIZE; i++)
        {
            Console.Write("Enter a double number: ");
            myStack.Push(Convert.ToDouble(Console.ReadLine()));
        }
        
        double current = myStack.Pop();
        Console.Write(current + " ");
        
        double greatest = current;
        
        for(int i = 1; i < SIZE; i++)
        {
            current = myStack.Pop();
            
            greatest = current > greatest ? current : greatest;
            
            Console.Write(current + " ");
        }
        
        Console.WriteLine();
        
        Console.WriteLine("The greatest number is " + greatest);
    }
}
