// Adrián Navarro Gabino

using System;
using System.IO;

class BMPOnConsole
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
                BinaryReader input = new BinaryReader(
                    File.Open(inputName, FileMode.Open));
                input.BaseStream.Seek(10, SeekOrigin.Begin);
                int position = input.ReadInt32();
                input.BaseStream.Seek(18, SeekOrigin.Begin);
                int width = input.ReadInt32();
                input.BaseStream.Seek(22, SeekOrigin.Begin);
                int height = input.ReadInt32();
                
                input.BaseStream.Seek(position, SeekOrigin.Begin);
                
                byte pixel;
                char[,] image = new char[height,width];
                
                for(int i = 0; i < height; i++)
                {
                    for(int j = 0; j < width; j++)
                    {
                        pixel = input.ReadByte();
                        
                        if(pixel < 127)
                        {
                            image[height - 1 - i, j] = '.';
                        }
                        else
                        {
                            image[height - 1 - i, j] = '*';
                        }
                    }
                }
                input.Close();
                
                for(int i = 0; i < height; i++)
                {
                    for(int j = 0; j < width; j++)
                    {
                        Console.Write(image[i, j]);
                    }
                    Console.WriteLine();
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
