// Adrián Navarro Gabino

using System;
using System.IO;

class ToUpper
{
    static void Main()
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        
        StreamReader file1 = new StreamReader(name);
        StreamWriter file2 = new StreamWriter(name + ".upper.txt");
        
        string line;
        
        do
        {
            line = file1.ReadLine();
            
            if(line != null)
                file2.WriteLine(line.ToUpper());
        } while(line != null);
        
        file2.Close();
        file1.Close();
    }
}
