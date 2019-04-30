// Adrián Navarro Gabino

using System;
using System.IO;
using System.Net;

class DescargarLibroRuby2
{
    static void Descargar(int i)
    {
        WebClient client = new WebClient();
        client.DownloadFile(
            "https://learnrubythehardway.org/book/ex" + i + ".html",
            "ruby" + i.ToString("00") + ".html");
            
    }
    
    static void Main()
    {
        for(int i = 0; i <= 52; i++)
        {
            Descargar(i);
            Console.WriteLine("Chapter " + i + " downloaded");
        }
    }
}
