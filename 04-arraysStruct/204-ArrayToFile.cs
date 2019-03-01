// Adrián Navarro Gabino

using System;
using System.IO;

public class ArrayToFile
{
    public static void Main()
    {
        Console.Write("Enter the filename: ");
        string filename = Console.ReadLine();
        
        if (File.Exists(filename))

            Console.WriteLine("Encontrado");

        else

            Console.WriteLine("No encontrado");
            
        string[] contenido = File.ReadAllLines(filename);
        
        string aux;
        
        for(int i = 0; i < contenido.Length - 1; i++)
        {
            for(int j = i + 1; j < contenido.Length; j++)
            {
                if(contenido[i].CompareTo(contenido[j]) > 0)
                {
                    aux = contenido[i];
                    contenido[i] = contenido[j];
                    contenido[j] = aux;
                }
            }
        }

            

        // Vamos a volcar datos a un fichero

        

        File.WriteAllLines("ordenado.txt", contenido);

        

        
    }
}
