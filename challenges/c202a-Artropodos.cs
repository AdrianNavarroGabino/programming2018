// Adrián Navarro Gabino

using System;

public class Artropodos
{
    public static void Main()
    {
        int casosPrueba = Convert.ToInt32(Console.ReadLine());
        
        string[] datos;
        int[] artropodos = new int[5];
        
        int patasTotales;
        
        for(int i = 0; i < casosPrueba; i++)
        {
            patasTotales = 0;
            
            datos = Console.ReadLine().Split();
            
            for(int j = 0; j < 5; j++)
            {
                artropodos[j] = Convert.ToInt32(datos[j]);
            }
            
            for(int j = 1; j <= 3; j++)
            {
                patasTotales += artropodos[j-1] * (4 + 2 * j);
            }
            
            patasTotales += artropodos[3] * artropodos[4] * 2;
            
            Console.WriteLine(patasTotales);
        }
    }
}
