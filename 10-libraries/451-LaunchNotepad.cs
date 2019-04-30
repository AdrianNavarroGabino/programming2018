// Adrián Navarro Gabino

using System;
using System.Diagnostics;

class LaunchProcess
{
    static void Main()
    {
        Process proc = Process.Start("notepad.exe");
        proc.WaitForExit();
    }
}
