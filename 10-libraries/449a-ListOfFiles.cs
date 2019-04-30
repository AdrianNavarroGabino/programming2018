// Adrián Navarro Gabino

using System;
using System.IO;

class FilesInTheCurrentDirectory
{
    static void Main()
    {
        string dir = ".";
        
        string[] files = Directory.GetFiles(dir);
        
        foreach(string name in files)
            if(name.Substring(name.Length - 3) == ".cs" ||
                    name.Substring(name.Length - 4) == ".exe")
                Console.WriteLine(name);
    }
}
