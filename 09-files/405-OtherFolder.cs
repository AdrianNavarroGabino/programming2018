using System;
using System.IO;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader csproj = new StreamReader("..\\..\\Program.csproj");
            StreamReader sln = new StreamReader(@"..\..\..\Program.sln");

            string line;

            Console.WriteLine("Program.csproj");
            Console.WriteLine();

            do
            {
                line = csproj.ReadLine();

                if (line != null)
                    Console.WriteLine(line);
            } while (line != null);

            Console.WriteLine();
            Console.WriteLine("Program.sln");
            Console.WriteLine();

            do
            {
                line = sln.ReadLine();

                if (line != null)
                    Console.WriteLine(line);
            } while (line != null);
        }
    }
}
