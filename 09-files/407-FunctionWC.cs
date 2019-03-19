// Adrián Navarro Gabino

using System;
using System.IO;

class FunctionWC
{
    static void Main(string[] args)
    {
        if(args.Length > 0)
        {
            StreamReader input = new StreamReader(args[0]);
            
            string line;
            
            int lines = 0;
            int words = 0;
            int characters = 0;
            
            do
            {
                line = input.ReadLine();
                
                if(line != null)
                {
                    lines++;
                    characters += line.Length;
                    
                    line = line.Trim();
                    while(line.Contains("  "))
                        line = line.Replace("  ", " ");
                    
                    for(int i = 0; i < line.Length; i++)
                    {
                        if(line[i] == ' ')
                        {
                            words++;
                        }
                    }
                    
                    if(line.Length != 0)
                        words++;
                }
            } while(line != null);
            
            input.Close();
            
            Console.WriteLine("Lines: " + lines);
            Console.WriteLine("Words: " + words);
            Console.WriteLine("Characters: " + characters);
        }
        else
        {
            Console.WriteLine("Error, not enough params.");
        }
    }
}
