// Adrián Navarro Gabino

using System;
using System.IO;

class InvertFile
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
            outputName = inputName + ".inv";
            
            try
            {
                FileStream input = new FileStream(inputName, FileMode.Open);
                FileStream output = File.Create(outputName);
                
                for(int i = 0; i < input.Length; i++)
                {
                    input.Seek(input.Length - 1 - i, SeekOrigin.Begin);
                    output.WriteByte((byte)input.ReadByte());
                }
                
                output.Close();
                input.Close();
            }
            catch(PathTooLongException)
            {
                Console.WriteLine("Path too long");
            }
            catch (IOException)
            {
                Console.WriteLine("IO error");
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
            }
        }
    }
}
