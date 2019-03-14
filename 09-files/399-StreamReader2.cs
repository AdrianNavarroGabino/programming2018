// Adrián Navarro Gabino

using System;
using System.IO;

public class StreamReader2
{
    public static void Main()
    {
        Console.Write("Enter the program name: ");
        string name = Console.ReadLine();
        
        StreamReader file = new StreamReader(name);
        
        string line;
        
        do
        {
            line = file.ReadLine();
            
            if(line != null)
            {
                line = line.Replace("Console.WriteLine", "printf");
                
                Console.WriteLine(line);
            }
        } while(line != null);
        
        file.Close();
    }
}
