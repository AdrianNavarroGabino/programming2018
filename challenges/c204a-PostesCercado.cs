/*
Calculate the minimum number of posts needed to fence an area by
knowing how much it measures and how often a post needs to be placed.
*/

/*
Example of input
10 10 10
6 6 10
10 15 10
0 0 0
Example of output
4
4
6
*/

// Adrián Navarro Gabino

using System;

public class PostesCercado
{
    public static void Main()
    {
        string[] datos = Console.ReadLine().Split();
        int[] medidas = new int[3];
        
        int postes = 0;
        
        while(datos[0] != "0" || datos[1] != "0" || datos[2] != "0")
        {
            for(int i = 0; i < 3; i++)
                medidas[i] = Convert.ToInt32(datos[i]);
            
            postes += (medidas[0] / medidas[2]) * 2;
            postes += medidas[0] % medidas[2] == 0 ? 0 : 2;
            postes += (medidas[1] / medidas[2]) * 2;
            postes += medidas[1] % medidas[2] == 0 ? 0 : 2;
            
            Console.WriteLine(postes);
            
            datos = Console.ReadLine().Split();
            postes = 0;
        }
    }
}
