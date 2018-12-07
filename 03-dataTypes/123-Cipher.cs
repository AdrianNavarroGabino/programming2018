// Adrián Navarro Gabino

using System;

public class Cipher
{
    public static void Main()
    {
        Console.Write("Enter a text: ");
        string message = Console.ReadLine();
        string cipher = "";
        string decoded = "";
        
        foreach(char c in message)
            cipher += (char) (c ^ 1);
        
        Console.WriteLine("Cipher message: " + cipher);
        
        foreach(char c in cipher)
            decoded += Convert.ToChar(c ^ 1);
            
        Console.WriteLine("Decoded message: " + decoded);
    }
}
