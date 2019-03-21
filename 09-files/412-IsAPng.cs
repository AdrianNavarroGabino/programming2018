// Adrián Navarro Gabino

using System;
using System.IO;

class IsAPng
{
    static void Main()
    {
        Console.Write("Filename: ");
        FileStream file = new FileStream(Console.ReadLine(), FileMode.Open);
        
        file.ReadByte();
        byte firstByte = (byte) file.ReadByte();
        byte secondByte = (byte) file.ReadByte();
        byte thirdByte = (byte) file.ReadByte();
        
        file.Close();
        
        if(firstByte == 'P' && secondByte == 'N' && thirdByte == 'G')
            Console.WriteLine("It seems a valid png file");
        else
            Console.WriteLine("It's NOT png file");
    }
}
