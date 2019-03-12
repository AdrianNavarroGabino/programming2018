// Adrián Navarro Gabino

using System;
using System.IO;

public class Files2
{
    public static void Main()
    {
        StreamWriter file = new StreamWriter("test.txt");
        
        for(int i = 1; i <= 100; i++)
            file.WriteLine("Line " + i);
        
        file.Close();
    }
}
