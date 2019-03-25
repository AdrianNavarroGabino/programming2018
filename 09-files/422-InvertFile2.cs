// Adrián Navarro Gabino

using System;
using System.IO;

class InvertFile2
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
                int length = (int)input.Length;
                byte[] data = new byte[length];
                int alreadyRead = input.Read(data, 0, length);
                input.Close();
                
                Array.Reverse(data);
                
                FileStream output = File.Create(outputName);
                output.Write(data, 0, length);
                output.Close();
                
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
