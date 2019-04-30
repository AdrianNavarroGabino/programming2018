// Adrián Navarro Gabino

using System;
using System.IO;

class ImagesToHtml
{
    static void Main()
    {
        DirectoryInfo dir = new DirectoryInfo(".");
        
        FileInfo[] files = dir.GetFiles();
        
        StreamWriter output = new StreamWriter("lista.html");
        
        output.WriteLine("<html>");
        output.WriteLine("<head>");
        output.WriteLine("</head>");
        output.WriteLine("<body>");
        output.WriteLine("<ol>");
        
        foreach(FileInfo file in files)
            if(file.Name.Substring(file.Name.Length - 4) == ".jpg" ||
                    file.Name.Substring(file.Name.Length - 4) == ".png")
                output.WriteLine("<li><a href=\"" + file.Name + "\">" +
                    file.Name + " " +
                    (file.Length / 1024.0).ToString("0.0") + "KB " +
                    file.LastWriteTime.ToString("dd-MM-yyyy") + "</a></li>");
        
        output.WriteLine("</ol>");
        output.WriteLine("</body>");
        output.WriteLine("</html>");
        output.Close();
    }
}
