// Adrián Navarro Gabino

using System;
using System.Diagnostics;

class LaunchProcess2
{
    static void Main()
    {
        Process proc = Process.Start("7za.exe", "a -p1234 fuentes *.cs");
        proc.WaitForExit();
        
        if(proc.ExitCode == 0)
            Console.WriteLine("All right");
    }
}
