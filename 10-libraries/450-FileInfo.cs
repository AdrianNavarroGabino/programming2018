// Adrián Navarro Gabino

using System;
using System.IO;

class FilesInTheCurrentDirectory3
{
    static void Main()
    {
        DirectoryInfo dir = new DirectoryInfo(".");
        
        FileInfo[] files = dir.GetFiles();
        
        foreach(FileInfo file in files)
            if(file.Name.Substring(file.Name.Length - 3) == ".cs" ||
                    file.Name.Substring(file.Name.Length - 4) == ".exe")
                Console.WriteLine(file.Name + " - " +
                    (file.Length / 1024.0).ToString("0.00") + "KB");
    }
}
