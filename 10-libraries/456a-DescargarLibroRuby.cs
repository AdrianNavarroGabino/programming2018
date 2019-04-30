// Adrián Navarro Gabino

using System;
using System.IO;
using System.Net;

class DescargarLibroRuby
{
    static void Descargar(string i)
    {
        WebClient client = new WebClient();
        Stream conexion =
            client.OpenRead(
            "https://learnrubythehardway.org/book/" + i + ".html");
        
        StreamWriter output = new StreamWriter(i + ".html");
        
        StreamReader lector = new StreamReader(conexion);
        string linea;
        while((linea = lector.ReadLine()) != null)
            output.WriteLine(linea);
        conexion.Close();
        output.Close();
            
    }
    
    static void Main()
    {
        Descargar("preface");
        Descargar("intro");
        
        for(int i = 0; i <= 52; i++)
        {
            Descargar("ex" + i);
            Console.WriteLine("Chapter " + i + " downloaded");
        }
    }
}
