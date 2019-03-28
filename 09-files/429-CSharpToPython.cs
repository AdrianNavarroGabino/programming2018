// Adrián Navarro Gabino

using System;
using System.IO;
using System.Collections.Generic;

class CSharpToPython
{
    public static void Main(string[] args)
    {
        string inputName;
        
        if(args.Length > 0)
        {
            inputName = args[0];
        }
        else
        {
            Console.Write("Input: ");
            inputName = Console.ReadLine();
        }

        StreamReader CSharpFile = new StreamReader(inputName);

        List<string> lines = new List<string>();
        string lineAux;
        
        do
        {
            lineAux = CSharpFile.ReadLine();
            
            if(lineAux != null)
            {
                lines.Add(lineAux);
            }
        } while(lineAux != null);
        CSharpFile.Close();
        
        StreamWriter PythonFile = new StreamWriter(inputName + ".py");
        
        for(int i = 0; i < lines.Count; i++)
        {
            lines[i] = lines[i].Replace("Console.WriteLine", "print");
            
            if(lines[i][lines[i].Length - 1] == ';')
                lines[i] = lines[i].Substring(0,lines[i].Length - 2);
                
            if(lines[i].Substring(0,3) == "int")
            {
                lines[i] = lines[i].Split()[1] + " = int(input())";
            }
        }
        
        PythonFile.Close();
        
    }
}
