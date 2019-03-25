// Adrián Navarro Gabino

using System;
using System.IO;

class CopyAFile
{
    static void Main(string[] args)
    {
        string inputName, outputName;
        
        if(args.Length > 0)
            inputName = args[0];
        else
        {
            Console.Write("Input: ");
            inputName = Console.ReadLine();
        }
        
        if(!File.Exists(inputName))
            Console.WriteLine("File not found");
        else
        {
            FileStream input = new FileStream(inputName, FileMode.Open);
            int length = (int)input.Length;
            byte[] data = new byte[length];
            int alreadyRead = input.Read(data, 0, length);
            input.Close();
            
            if(args.Length > 1)
                outputName = args[1];
            else
            {
                Console.Write("Output: ");
                outputName = Console.ReadLine();
            }
            
            if(File.Exists(outputName))
                Console.WriteLine("The file already exists");
            else
            {
                FileStream output = File.Create(outputName);
                output.Write(data, 0, length);
                output.Close();
            }
        }
    }
}
