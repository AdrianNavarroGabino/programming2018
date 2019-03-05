// Adrián Navarro Gabino

using System;
using System.Collections.Generic;

class Ejercicio4
{
    static void Main(string[] args)
    {
        bool balanceada = true;
        Stack<bool> parentesis = new Stack<bool>();

        Console.WriteLine("Introduce una expresión:");
        string frase = Console.ReadLine();

        foreach(char c in frase)
        {
            if (c == ')' && parentesis.Count == 0)
                balanceada = false;
            else if (c == ')')
                parentesis.Pop();
            else if (c == '(')
                parentesis.Push(true);
        }

        if (!balanceada)
            Console.WriteLine("Excepción, expresión no balanceada");
        else if (parentesis.Count != 0)
            Console.WriteLine("Pila con " + parentesis.Count +
                " dato(s), expresión no balanceada");
        else
            Console.WriteLine("Pila vacía, expresión balanceada");
    }
}
