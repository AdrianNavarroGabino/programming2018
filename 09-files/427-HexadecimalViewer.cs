// Adrián Navarro Gabino

using System;
using System.IO;

class HexadecimalViewer
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
                byte[] data = new byte[32];
                
                FileStream input = new FileStream(inputName, FileMode.Open);
                
                int alreadyRead = input.Read(data, 0, 32);
                
                if(alreadyRead >= 16)
                {
                    for(int i = 0; i < 16; i++)
                    {
                        Console.Write(Convert.ToString(data[i], 16) + " ");
                    }
                    
                    for(int i = 16; i < alreadyRead; i++)
                    {
                        if(Convert.ToByte(data[i]) < 32)
                        {
                            Console.Write(".");
                        }
                        else
                        {
                            Console.Write(data[i]);
                        }
                    }
                }
                else
                {
                    for(int i = 0; i < alreadyRead; i++)
                    {
                        Console.Write(Convert.ToString(data[i], 16) + " ");
                    }
                }
                Console.WriteLine();
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
