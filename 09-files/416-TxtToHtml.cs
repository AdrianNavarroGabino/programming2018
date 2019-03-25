// Adrián Navarro Gabino

using System;
using System.IO;

class TxtToHtml
{
    public static void Main(string[] args)
    {
        Console.WriteLine("File name? ");
        string name = Console.ReadLine();

        StreamReader txtFile = new StreamReader(name);
        StreamWriter htmlFile = new StreamWriter(name + ".html");

        htmlFile.WriteLine("<html>");
        htmlFile.WriteLine("<body>");

        string lastLine = "";
        string line = txtFile.ReadLine();
        bool inParagraph = false;
        while (line != null)
        {
            if (line == "")
                htmlFile.WriteLine("</p>");
            else
            {
                if (lastLine == "")
                    htmlFile.WriteLine("<p>" + line);
                else
                    htmlFile.WriteLine("<br />" + line);
            }

            lastLine = line;
            line = txtFile.ReadLine();
        }
        
        if ( inParagraph )
        {
            htmlFile.WriteLine("</p>");
        }    

        htmlFile.WriteLine("</body>");
        htmlFile.WriteLine("</html>");

        htmlFile.Close();
        txtFile.Close();
    }
}
