// Adrián Navarro Gabino

using System;
using System.IO;

class IsAnExe
{
    static void Main()
    {
        Console.Write("Filename: ");
        FileStream file = File.OpenRead(Console.ReadLine());
        
        byte firstByte = (byte) file.ReadByte();
        byte secondByte = (byte) file.ReadByte();
        
        file.Close();
        
        if(firstByte == 'M' && secondByte == 'Z')
            Console.WriteLine("It seems a valid exe");
        else
            Console.WriteLine("It's NOT an exe");
    }
}
