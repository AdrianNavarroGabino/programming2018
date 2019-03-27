// Adrián Navarro Gabino

using System;
using System.IO;

class CopyAFileBlocks
{
    static void Main(string[] args)
    {
        string inputName, outputName;
        int blockSize;
        
        if(args.Length > 2)
        {
            inputName = args[0];
            blockSize = Convert.ToInt32(args[2]);
        }
        else
        {
            Console.Write("Input: ");
            inputName = Console.ReadLine();
            Console.Write("Block size: ");
            blockSize = Convert.ToInt32(Console.ReadLine());
        }
        
        if(!File.Exists(inputName))
            Console.WriteLine("File not found");
        else
        {
            if(args.Length > 2)
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
                int length = (int)input.Length;
                
                int alreadyRead = 0;
                for(int i = 0; i < length; i += blockSize)
                {
                    byte[] data = new byte[blockSize];
                    alreadyRead += input.Read(data, 0, blockSize);
                    if(alreadyRead % blockSize == 0)
                        output.Write(data, 0, blockSize);
                    else
                        output.Write(data, 0, alreadyRead % blockSize);
                }
                
                output.Close();
                input.Close();
            }
        }
    }
}
