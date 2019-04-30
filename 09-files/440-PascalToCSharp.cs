// Adrián Navarro Gabino

using System;
using System.IO;

class PascalToCSharp
{
    public static void Main(string[] args)
    {
        string name;
        if (args.Length == 1)
        {
            name = args[0];
        }
        else
        {
            Console.Write("Enter the Pascal file name: ");
            name = Console.ReadLine();
        }

        if (!File.Exists(name))
        {
            Console.WriteLine("File not found");
            return;
        }

        if (!name.EndsWith(".pas"))
        {
            Console.WriteLine("Source must be a Pascal file");
            return;
        }

        StreamReader source;
        StreamWriter destination;
        try
        {
            source = new StreamReader(name);
            destination = new StreamWriter(name.Substring(0,
                name.Length - 3) + "cs");

            bool beginOpen = false;
            bool varOpen = false;

            string line = source.ReadLine();
            while (line != null)
            {
                ProcessAndDump(line, destination, ref beginOpen, ref varOpen);
                line = source.ReadLine();
            }

            destination.WriteLine("    }");
            destination.WriteLine("}");
            destination.Close();
            source.Close();
            Console.WriteLine("Conversion finished");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Path too long");
        }
        catch (IOException e)
        {
            Console.WriteLine("I/O error: " + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error:" + e.Message);
        }
    }

    static void ProcessAndDump(string line, StreamWriter file, ref bool beginOpen, ref bool varOpen)
    {
        if (line.Trim().StartsWith("(*"))
            line = line.Replace("(*", "/*");
        if (line.Length > 3 && line.Substring(line.Length - 3) == "*)")
            line = line.Substring(0, line.Length - 2) + "*/";
        if (line.Trim().Length >= 7 && line.Trim().Substring(0,7).ToLower() == "program")
        {
            file.WriteLine("using System;");
            file.WriteLine();

            line = "class " + line.Substring(
                line.IndexOf("program") +"program ".Length);
            line = line.Substring(0, line.Length - 1);
            file.WriteLine(line);

            file.WriteLine("{");
            file.WriteLine("    static void Main()");
            file.WriteLine("    {");
            return;
        }

        if (line.Trim().Length >= 3 && line.Trim().Substring(0, 3).ToLower() == "var")
        {
            varOpen = true;
            return;
        }

        if (line.Trim().Length >= 5 && line.Trim().Substring(0,5).ToLower() == "begin")
        {
            beginOpen = true;
            varOpen = false;
            return;
        }

        if (line.Contains(":") && varOpen)
        {
            string[] aux = line.Trim().Split(':');
            line = "        " +
                line.Substring(0, line.IndexOf(":") - aux[0].Length) + "int " +
                aux[0] + ";";
        }
        
        if(beginOpen)
        {
            line = "        " + line;
            
            if(line.Contains("writeLn"))
            {
                line = line.Substring(0, line.IndexOf("writeLn")) +
                    "Console.WriteLine" + line.Substring(
                        line.IndexOf("writeLn") + "WriteLine".Length - 2);
                line = line.Replace("'", "\"");
            }
            else if (line.Contains("write"))
            {
                line = line.Substring(0, line.IndexOf("write")) +
                    "Console.Write" + line.Substring(
                        line.IndexOf("write") + "Write".Length);
                line = line.Replace("'", "\"");
            }
            if (line.Contains("readLn"))
            {
                string variable = line.Substring(
                    line.IndexOf("(") + 1,
                    line.LastIndexOf(")") - line.IndexOf("(") - 1);

                line = line.Substring(0, line.IndexOf("readLn")) + variable +
                    " = Convert.ToInt32(Console.ReadLine());";
            }
            if(line.Trim().StartsWith("for"))
            {
                string index = line.Substring(line.IndexOf("for") + 4,
                    line.IndexOf(":=") - line.IndexOf("for") - 5);
                string limit = line.Substring(line.IndexOf("to") + 3,
                    line.IndexOf(" do") - line.IndexOf("to") - 3);

                line = line.Substring(0, line.IndexOf("for")) + "for(int " +
                     index + "; " + index + " <= " + limit + "; " +
                     index + "++)";
            }
            if(line.Trim().StartsWith("if"))
            {
                line = line.Replace("=", "==");
                line = line.Substring(0, line.IndexOf("if")) + "if(" +
                    line.Substring(line.IndexOf("if") + 3, line.IndexOf(" then") - line.IndexOf("if") - 3) +
                    ")";
            }

            if (line.Trim().Length >= 3 && line.Trim().Substring(0, 3).ToLower() == "end")
            {
                return;
            }
        }
        
        file.WriteLine(line);

    }
}
