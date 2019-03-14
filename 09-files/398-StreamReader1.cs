// Adrián Navarro Gabino

using System;
using System.IO;

public class StreamReader1
{
    public static void Main()
    {
        Console.Write("Enter the program name: ");
        string name = Console.ReadLine();
        
        StreamReader file = File.OpenText(name);
        
        string line;
        
        do
        {
            line = file.ReadLine();
            
            if(line != null)
            {
                line = line.Trim();
            
                if(line != "")
                    Console.WriteLine(line);
            }
        } while(line != null);
        
        file.Close();
    }
}
