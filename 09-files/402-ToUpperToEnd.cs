// Adrián Navarro Gabino

using System;
using System.IO;

class ToUpperToEnd
{
    static void Main()
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        
        string aux = File.ReadAllText(name).ToUpper();
        
        StreamWriter file = new StreamWriter(name + ".upper.txt");
        
        file.Write(aux);
        
        file.Close();
    }
}
