using System.Security.Cryptography;
using System.Text;
using System;

public class Ejercicio
{
    public static void Main()
    {
        int x = 0;
        string hash;
        
        do
        {
            MD5 md5Hash = MD5.Create();
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(x.ToString()));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            hash = sBuilder.ToString();
            
            x++;
        } while(hash != "099ebea48ea9666a7da2177267983138");
        
        Console.WriteLine(x-1);
        
    }
}
