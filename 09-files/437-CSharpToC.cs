using System;
using System.IO;

class CSharpToC
{
    static void Main()
    {
        StreamReader inFile;
        StreamWriter outFile;
        string line;

        Console.Write("Enter file name: ");
        string fileName = Console.ReadLine();

        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found!");
            return;
        }

        try
        {
            inFile = File.OpenText(fileName);
            outFile = File.CreateText(fileName + ".c");
			
            do
            {
                line = inFile.ReadLine();
                if (line != null)
                    ExtractAndDump(line, outFile);
            } while (line != null);
            inFile.Close();
            outFile.Close();
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Entered path was too long");
            return;
        }
        catch (IOException exp)
        {
            Console.WriteLine("Input/output error: "+ exp.Message);
            return;
        }
        catch (Exception exp)
        {
            Console.WriteLine("Unexpected error: "+ exp.Message);
            return;
        }
        Console.WriteLine("Extraction finished");
    }

    private static void ExtractAndDump(string line, StreamWriter file)
    {
        if(line.TrimStart().StartsWith("using"))
			return;
            
        // Leading spaces
        if (line.StartsWith("        "))
            line = line.Substring(4);
            
        if (line.Contains("public class"))
            line = "#include <stdio.h>";
            
        if (line.TrimStart().StartsWith("//"))
		{
			line = line.Replace("//"," /*");
			line = line + "*/";
		}
            
        // Variable declarations
        if (line.TrimStart().StartsWith("int "))
        {
            // Removing "int" if there is user input
            if (line.Contains("ReadLine"))
            {
				string variable = line.Substring(line.IndexOf("int ") + 4,
					line.IndexOf("=") - line.IndexOf("int ") - 4);
				line = line.Replace("=",";");
                line = line.Replace("Convert.ToInt32(Console.ReadLine())",
					"scanf(\"&d\"," + variable + ")");
            }
            else
                return;
        }
        
        if (line.Contains("for(") || line.Contains("for ("))
        {
			string index = line.Substring(line.IndexOf(";") + 1, 2);
			
			line = line.Substring(0, line.IndexOf("int ")) +
				"int " + index + "; for( " +
				line.Substring(line.IndexOf("int ") + 4);
		}
		
        if(line.Contains("Console.Write"))
        {
			if(line.Contains("Console.WriteLine"))
			{
				line = line.Replace("Console.WriteLine", "printf");
				line = line.Substring(0, line.LastIndexOf("\"")) + "\\n" +
					line.Substring(line.LastIndexOf("\""));
			}
			else
			{
				line = line.Replace("Console.Write", "printf");
			}
			
			for(int i = 0; i < 10; i++)
			{
				if(line.Contains("{" + i + "}"))
				{
					line = line.Replace("{" + i + "}", "%d");
				}
			}
		}
		
		if (line.Contains("public static"))
            line = "int main()";
        
        
        file.WriteLine(line);
    }
}
