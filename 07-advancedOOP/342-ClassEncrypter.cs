// Adrián Navarro Gabino

using System;

class Encrypter
{
    public static string Encrypt(string sentence)
    {
        string encrypted = "";
        foreach(char c in sentence)
        {
            encrypted += Convert.ToChar(c + 1);
        }
        return encrypted;
    }
    
    public static string Decrypt(string sentence)
    {
        string decrypted = "";
        foreach(char c in sentence)
        {
            decrypted += Convert.ToChar(c - 1);
        }
        return decrypted;
    }
}

class EncrypterTest
{
    static void Main()
    {
        string sentence = "Hello";
        string sentenceEncrypted = Encrypter.Encrypt(sentence);
        
        Console.WriteLine(sentenceEncrypted);
        
        Console.WriteLine(Encrypter.Decrypt(sentenceEncrypted));
    }
}
