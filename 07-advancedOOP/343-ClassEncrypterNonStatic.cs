// Adrián Navarro Gabino

using System;

class Encrypter
{
    public string Encrypt(string sentence)
    {
        string encrypted = "";
        foreach(char c in sentence)
        {
            encrypted += Convert.ToChar(c + 1);
        }
        return encrypted;
    }
    
    public string Decrypt(string sentence)
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
        Encrypter e = new Encrypter();
        string sentence = "Hello";
        string sentenceEncrypted = e.Encrypt(sentence);
        
        Console.WriteLine(sentenceEncrypted);
        
        Console.WriteLine(e.Decrypt(sentenceEncrypted));
    }
}
