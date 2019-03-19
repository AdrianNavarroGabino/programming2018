// Adrián Navarro Gabino

using System;
using System.IO;

class NoSpaces
{
    static void Main(string[] args)
    {
        if(args.Length > 0)
        {
            StreamReader input = new StreamReader(args[0]);
            StreamWriter output = new StreamWriter(args[0] + ".nospc.txt");
            
            string line;
            
            do
            {
                line = input.ReadLine();
                
                if(line != null)
                {
                    line = line.Trim();
                    while(line.Contains("  "))
                        line = line.Replace("  ", " ");
                    output.WriteLine(line);
                }
            } while(line != null);
            
            output.Close();
            input.Close();
        }
        else
        {
            Console.WriteLine("Error, not enough params.");
        }
    }
}
