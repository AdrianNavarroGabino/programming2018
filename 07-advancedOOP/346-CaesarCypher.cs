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

class CaesarCypher : Encrypter
{
    public new static string Encrypt(string sentence)
    {
        string encrypted = "";
        foreach(char c in sentence)
        {
            if(c == ' ')
                encrypted += ' ';
            else if(c == 'X')
                encrypted += 'A';
            else if(c == 'Y')
                encrypted += 'B';
            else if(c == 'Z')
                encrypted += 'C';
            else if(c == 'x')
                encrypted += 'a';
            else if(c == 'y')
                encrypted += 'b';
            else if(c == 'z')
                encrypted += 'c';
            else
                encrypted += Convert.ToChar(c + 3);
        }
        return encrypted;
    }
    
    public new static string Decrypt(string sentence)
    {
        string decrypted = "";
        foreach(char c in sentence)
        {
            if(c == ' ')
                decrypted += ' ';
            else if(c == 'A')
                decrypted += 'X';
            else if(c == 'B')
                decrypted += 'Y';
            else if(c == 'C')
                decrypted += 'Z';
            else if(c == 'a')
                decrypted += 'x';
            else if(c == 'b')
                decrypted += 'y';
            else if(c == 'c')
                decrypted += 'z';
            else
                decrypted += Convert.ToChar(c - 3);
        }
        return decrypted;
    }
}

class EncrypterTest
{
    static void Main()
    {
        string sentence = "Hello, XYZxyz";
        string sentenceEncrypted = CaesarCypher.Encrypt(sentence);
        
        Console.WriteLine(sentenceEncrypted);
        
        Console.WriteLine(CaesarCypher.Decrypt(sentenceEncrypted));
    }
}
