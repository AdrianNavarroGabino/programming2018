// Adrián Navarro Gabino

using System;
using System.IO;
using System.Collections.Generic;

class ReverseLines
{
    static void Main(string[] args)
    {
        StreamReader input;
        string name;
        
        if(args.Length > 0)
        {
            name = args[0];
        }
        else
        {
            Console.Write("Name of the file: ");
            name = Console.ReadLine();
        }
        try
        {
            if(File.Exists(name))
            {
                input = new StreamReader(name);
                StreamWriter output = new StreamWriter(
                    name + ".reverse.txt");
                
                List<string> lines = new List<string>();
                
                string line;
                
                do
                {
                    line = input.ReadLine();
                    
                    if(line != null)
                    {
                        lines.Add(line);
                    }
                } while(line != null);
                
                for(int i = lines.Count - 1; i >= 0; i--)
                {
                    output.WriteLine(lines[i]);
                }
                
                output.Close();
                input.Close();
            }
            else
                Console.WriteLine("File not found");
        }
        catch(IOException)
        {
            Console.WriteLine("IO Exception");
        }
        catch(Exception)
        {
            Console.WriteLine("Exception");
        }
    }
}
