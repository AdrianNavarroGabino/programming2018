// Adrián Navarro Gabino

using System;
using System.IO;

class ExtractTextFromBinary
{
    static void Main()
    {
        Console.Write("Filename: ");
        string name = Console.ReadLine();
        
        FileStream input = new FileStream(name, FileMode.Open);
        StreamWriter output = new StreamWriter(name + ".txt");
        
        for(int i = 0; i < input.Length; i++)
        {
            byte data = (byte) input.ReadByte();
            
            if(data == 10 || data == 13 || (data >= 32 && data <= 127))
                output.Write(Convert.ToChar(data));
        }
        
        output.Close();
        input.Close();
    }
}
