// Adrián Navarro Gabino

using System;
using System.IO;

class FilesInTheCurrentDirectory2
{
    static void Main()
    {
        foreach(string name in Directory.GetFiles(".", "*cs"))
            Console.WriteLine(name);
    }
}
