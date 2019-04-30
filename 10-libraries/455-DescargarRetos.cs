// Adrián Navarro Gabino

using System;
using System.IO;
using System.Net;

class DescargarRetos
{
    static void Descargar(int i)
    {
        WebClient client = new WebClient();
        Stream conexion =
            client.OpenRead(
            "https://www.aceptaelreto.com/problem/statement.php?id=10" + i);
        
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
        for(int i = 0; i <= 10; i++)
        {
            Descargar(i);
        }
    }
}
