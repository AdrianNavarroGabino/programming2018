// Adrián Navarro Gabino

using System;
using System.IO;

class MP3Reader
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
                FileStream input = new FileStream(inputName, FileMode.Open);
                input.Seek(-128, SeekOrigin.End);
                byte[] data = new byte[128];
                int read = input.Read(data,0, 128);
                input.Close();
                
                if(read == 128 &&
                    data[0] == 'T' && data[1] == 'A' && data[2] == 'G')
                {
                    Console.Write("Title: ");
                    for(int i = 3; i < 33; i++)
                        if(data[i] != 0)
                            Console.Write((char)data[i]);
                    Console.WriteLine();
                    
                    Console.Write("Artist: ");
                    for(int i = 33; i < 63; i++)
                        if(data[i] != 0)
                            Console.Write((char)data[i]);
                    Console.WriteLine();
                    
                    Console.Write("Album: ");
                    for(int i = 63; i < 93; i++)
                        if(data[i] != 0)
                            Console.Write((char)data[i]);
                    Console.WriteLine();
                    
                    Console.Write("Year: ");
                    for(int i = 93; i < 97; i++)
                        if(data[i] != 0)
                            Console.Write((char)data[i]);
                    Console.WriteLine();
                    
                    Console.Write("Comment: ");
                    for(int i = 97; i < 127; i++)
                        if(data[i] != 0)
                            Console.Write((char)data[i]);
                    Console.WriteLine();
                    
                    Console.WriteLine("Genre: " + (char)data[127]);
                }
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
