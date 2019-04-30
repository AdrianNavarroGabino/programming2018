// Adrián Navarro Gabino

using System;
using System.Diagnostics;

class LaunchProcess3
{
    static void Main()
    {
        int pass = -1;
        
        Process proc;
        
        do
        {
            pass++;
            
            proc = Process.Start("7za.exe", "x -p" + pass.ToString("0000") +
                " -y c.7z");
            proc.WaitForExit();
            
            if(proc.ExitCode == 0)
                Console.WriteLine("All right");
            
        } while(proc.ExitCode != 0);
        
        Console.WriteLine(pass.ToString("0000"));
    }
}
