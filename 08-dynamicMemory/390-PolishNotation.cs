// Adrián Navarro Gabino

using System;
using System.Collections;

class PolishNotation
{
    static void Main()
    {
        Stack myStack = new Stack();
        
        Console.WriteLine("Enter a row of numbers and operations:");
        String[] operations = Console.ReadLine().Split();
        int i = 0;
        int number;
        
        do
        {
            try
            {
                number = Convert.ToInt32(operations[i]);
                myStack.Push(number);
            }
            catch(Exception)
            {
                switch(operations[i])
                {
                    case "+":
                        myStack.Push((int)myStack.Pop() + (int)myStack.Pop());
                        break;
                    case "-":
                        myStack.Push((int)myStack.Pop() - (int)myStack.Pop());
                        break;
                    case "*":
                        myStack.Push((int)myStack.Pop() * (int)myStack.Pop());
                        break;
                    case "/":
                        myStack.Push((int)myStack.Pop() / (int)myStack.Pop());
                        break;
                    default: break;
                }
            }
            
            i++;
        } while(operations[i] != ".");
        
        Console.WriteLine(myStack.Pop());
    }
}
