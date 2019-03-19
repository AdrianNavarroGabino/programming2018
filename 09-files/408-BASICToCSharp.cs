// Adrián Navarro Gabino

using System;
using System.IO;

class BASICToCSharp
{
    static void Main(string[] args)
    {
        try
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
        
            if(File.Exists(name))
            {
                input = new StreamReader(name);
                StreamWriter output = new StreamWriter(
                    name.Substring(0,name.Length - 4) + ".cs");
                
                output.WriteLine("using System;");
                output.WriteLine();
                output.WriteLine("class Program");
                output.WriteLine("{");
                output.WriteLine("    static void Main()");
                output.WriteLine("    {");
                
                string line;
                
                do
                {
                    line = input.ReadLine();
                    
                    if(line != null)
                    {
                        line = line.Substring(line.IndexOf(" ") + 1);
                        
                        if(line.Substring(0,5).ToUpper() == "INPUT")
                        {
                            output.Write("        int ");
                            string variable = line.Substring(line.IndexOf(" ") +
                                1);
                            output.WriteLine(variable +
                                " = Convert.ToInt32(Console.ReadLine());");
                        }
                        else if(line.Substring(0,5).ToUpper() == "PRINT")
                        {
                            output.WriteLine("        Console.WriteLine(" +
                                line.Substring(line.IndexOf(" ") + 1) + ");");
                        }
                    }
                } while(line != null);
                
                output.WriteLine("    }");
                output.WriteLine("}");
                
                output.Close();
                input.Close();
            }
            else
                Console.WriteLine("File not found");
        }
        catch(Exception)
        {
            Console.WriteLine("Error");
        }
    }
}
