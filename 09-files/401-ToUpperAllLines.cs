// Adrián Navarro Gabino

using System;
using System.IO;

class ToUpperAllLines
{
    static void Main()
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        
        string[] aux = File.ReadAllLines(name);
        
        for(int i = 0; i < aux.Length; i++)
        {
            aux[i] = aux[i].ToUpper();
        }
        
        File.WriteAllLines(name + ".upper.txt", aux);
    }
}
