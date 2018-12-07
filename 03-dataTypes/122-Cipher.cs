// Adrián Navarro Gabino

using System;

public class Cipher
{
    public static void Main()
    {
        Console.Write("Enter a text: ");
        string message = Console.ReadLine();
        string cipher = "";
        string descipher = "";
        
        foreach(char i in message)
            cipher += Convert.ToChar(i + 1);
        
        Console.WriteLine("Cipher message: " + cipher);
        
        foreach(char j in cipher)
            descipher += Convert.ToChar(j - 1);
            
        Console.WriteLine("Decoded message: " + descipher);
    }
}
