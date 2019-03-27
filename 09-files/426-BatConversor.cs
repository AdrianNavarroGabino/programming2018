// Adrián Navarro Gabino

using System;
using System.IO;

class BatConversor
{
    static void Main(string[] args)
    {
        string inputName;
        
        if(args.Length > 0)
        {
            inputName = args[0];
        }
        else
        {
            Console.Write("Input: ");
            inputName = Console.ReadLine();
        }
        
        if(!File.Exists(inputName))
            Console.WriteLine("File not found");
        else
        {
            try
            {
                StreamReader input = new StreamReader(inputName);
                StreamWriter output = new StreamWriter(
                    inputName.Substring(0, inputName.Length - 4) + ".cs");
                    
                output.WriteLine("using System;");
                output.WriteLine("using System.IO;");
                output.WriteLine("using System.Diagnostics;");
                output.WriteLine("");
                output.WriteLine("class BatConversor");
                output.WriteLine("{");
                output.WriteLine("    static void Main()");
                output.WriteLine("    {");
                
                string[] lineAux;
                string line;
                
                do
                {
                    line = input.ReadLine();
                    
                    
                    if(line != null)
                    {
                        lineAux = line.Split();
                        output.Write("        ");
                        
                        string aux = "";
                        
                        for(int i = 1; i < lineAux.Length - 1; i++)
                        {
                            aux += lineAux[i] + " ";
                        }
                        aux += lineAux[lineAux.Length - 1];
                        
                        switch(lineAux[0].ToLower())
                        {    
                            case "cls":
                                lineAux[0] = lineAux[0].ToLower().
                                    Replace("cls", "Console.Clear()");
                                output.WriteLine(lineAux[0]);
                                break;
                            case "echo":
                                lineAux[0] = lineAux[0].ToLower().
                                    Replace("echo", "Console.WriteLine(" +
                                    aux + ");");
                                output.WriteLine(lineAux[0]);
                                break;
                            case "cd":
                                lineAux[0] = lineAux[0].ToLower().
                                    Replace("cd",
                                    "Directory.SetCurrentDirectory('" +
                                    aux + "')");
                                output.WriteLine(lineAux[0]);
                                break;
                            default:
                                output.WriteLine("proc = Process.Start(\"" +
                                    line + "\"); proc.WaitForExit();");
                                break;
                        }
                    }
                        
                } while( line != null );
                
                output.WriteLine("    }");
                output.WriteLine("}");
                
                output.Close();
                input.Close();
            }
            catch(PathTooLongException)
            {
                Console.WriteLine("Path too long");
            }
            catch(IOException)
            {
                Console.WriteLine("IO Exception");
            }
            catch(Exception)
            {
                Console.WriteLine("Error");
            }
        }
    }
}
