// Adrián Navarro Gabino

using System;
using System.IO;

class BMPData
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
                input.BaseStream.Seek(18, SeekOrigin.Begin);
                int width = input.ReadInt32();
                int height = input.ReadInt32();
                input.ReadInt32();
                // Another option:
                //input.BaseStream.Seek(4, SeekOrigin.Current);
                int compression = input.ReadInt32();
                input.Close();
                
                Console.WriteLine("Width: " + width);
                Console.WriteLine("Height: " + height);
                Console.WriteLine("Compression: " + compression);
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
