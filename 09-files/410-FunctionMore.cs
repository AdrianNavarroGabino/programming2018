// Adrián Navarro Gabino

using System;
using System.IO;

class FunctionMore
{
    static void Main(string[] args)
    {
        string name;
        
        if(args.Length > 0)
            name = args[0];
        else
        {
            Console.Write("Filename: ");
            name = Console.ReadLine();
        }
        
        if(!File.Exists(name))
            Console.WriteLine("File not found");
        else
        {
            try
            {
                StreamReader input = new StreamReader(name);
                
                string line;
                int count = 0;
                
                do
                {
                    line = input.ReadLine();
                    
                    if(line != null)
                    {
                        if(line.Length > 79)
                        {
                            line = line.Substring(0,79);
                        }
                        
                        Console.WriteLine(line);
                        
                        if(count % 24 == 23)
                            Console.ReadLine();
                        
                        count++;
                    }
                } while(line != null);
                
                input.Close();
            }
            catch(PathTooLongException)
            {
                Console.WriteLine("Path too long");
            }
            catch(IOException)
            {
                Console.WriteLine("IO error");
            }
            catch(Exception)
            {
                Console.WriteLine("Exception");
            }
        }
    }
}
