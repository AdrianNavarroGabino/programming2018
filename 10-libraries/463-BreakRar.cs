// Adrián Navarro Gabino

using System;
using System.Diagnostics;
using System.IO;

class BreakRar
{
    static void Main()
    {
        string[] dictionary = File.ReadAllLines("words.txt");
        
        Process proc;
        
        for(int i = 0; i < dictionary.Length; i++)
        {
            if(dictionary[i].Length <= 5)
            {
                Console.WriteLine(dictionary[i]);
                proc = Process.Start("rar.exe", "x -p" + dictionary[i] +
                    " -y cb.rar");
                proc.WaitForExit();
                
                if(proc.ExitCode == 0)
                {
                    Console.WriteLine("Found: " + dictionary[i]);
                    break;
                }
            }
            
        }
    }
}
