// Adrián Navarro Gabino

using System;
using System.IO;

class LogDateTime
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string line = Console.ReadLine();
        DateTime date = DateTime.Now;
        
        StreamWriter file = File.AppendText("log.txt");
        file.WriteLine(date + " " + line);
        file.Close();
    }
}
