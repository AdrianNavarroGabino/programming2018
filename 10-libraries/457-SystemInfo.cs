// Adrián Navarro Gabino

using System;
using System.IO;

class SystemInfo
{
    static void Main()
    {
        Console.WriteLine("Windows version: " + Environment.OSVersion);
        Console.WriteLine(".Net version: " + Environment.Version);
        Console.WriteLine("User name: " + Environment.UserName);
        Console.WriteLine("Documents folder: " +
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));

        DriveInfo[] allDrives = DriveInfo.GetDrives();

        foreach (DriveInfo d in allDrives)
        {
            if(d.IsReady)
                Console.WriteLine("Drive {0}MB - {1} free of {2}MB",
                    d.Name,
                    ((d.AvailableFreeSpace / 1024) / 1024),
                    ((d.TotalSize / 1024) / 1024));
        }
    }
}

