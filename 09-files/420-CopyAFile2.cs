// Adrián Navarro Gabino

using System;
using System.IO;

class CopyAFile2
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
                FileStream input = new FileStream(inputName, FileMode.Open);
                FileStream output = File.Create(outputName);
                
                for(int i = 0; i < input.Length; i++)
                    output.WriteByte((byte)input.ReadByte());
                
                output.Close();
                input.Close();
            }
        }
    }
}
