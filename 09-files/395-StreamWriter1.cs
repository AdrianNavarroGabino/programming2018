// Adrián Navarro Gabino

using System;
using System.IO;

public class Files
{
    public static void Main()
    {
        StreamWriter file = File.CreateText("test.txt");
        file.WriteLine("Hello");
        file.WriteLine("Bye");
        file.Close();
    }
}
