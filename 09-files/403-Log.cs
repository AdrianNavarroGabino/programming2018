// Adrián Navarro Gabino

using System;
using System.IO;

class Log
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string line = Console.ReadLine();
        
        StreamWriter file = File.AppendText("log.txt");
        file.WriteLine(line);
        file.Close();
    }
}
