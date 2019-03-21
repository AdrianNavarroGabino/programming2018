// Adrián Navarro Gabino

using System;
using System.IO;

class NumberOfSpaces
{
    static void Main()
    {
        Console.Write("Filename: ");
        FileStream file = new FileStream(Console.ReadLine(), FileMode.Open);
        
        int count = 0;
        
        for(int i = 0; i < file.Length; i++)
        {
            byte data = (byte) file.ReadByte();
            
            if(data == ' ')
                count++;
        }
        
        file.Close();
        
        Console.WriteLine(count + " spaces");
    }
}
