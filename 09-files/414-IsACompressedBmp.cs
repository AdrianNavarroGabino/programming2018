// Adrián Navarro Gabino

using System;
using System.IO;

class IsACompressedBmp
{
    static void Main()
    {
        Console.Write("Filename: ");
        FileStream file = new FileStream(Console.ReadLine(), FileMode.Open);
        
        byte firstByte = (byte) file.ReadByte();
        byte secondByte = (byte) file.ReadByte();
        
        if(firstByte == 'B' && secondByte == 'M')
        {
            Console.WriteLine("It seems a valid bmp file");
            
            file.Seek(30, SeekOrigin.Begin);
            byte compressed = (byte) file.ReadByte();
            
            if(compressed == 0)
                Console.WriteLine("The bmp isn't compressed");
            else
                Console.WriteLine("The bmp is compressed");
        }
        else
            Console.WriteLine("It's NOT a bmp file");
        
        file.Close();
    }
}
