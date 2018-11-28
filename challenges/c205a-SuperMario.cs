/*
Entrada de ejemplo
3
8
1 4 2 2 3 5 3 4
2
9 9
5
1 2 3 4 5
Salida de ejemplo
4 2
0 0
4 0
*/

// Adrian Navarro Gabino

using System;

public class SuperMario
{
    public static void Main()
    {
        byte casosPrueba = Convert.ToByte(Console.ReadLine());
        
        int tamanyo;
        string[] datos;
        
        
        int saltoUp, saltoDown;
        
        for(int i = 0; i < casosPrueba; i++)
        {
            saltoUp = 0;
            saltoDown = 0;
            
            tamanyo = Convert.ToInt32(Console.ReadLine());
            datos = Console.ReadLine().Split();
            int[] muros = new int[tamanyo];
            
            for(int j = 0; j < tamanyo; j++)
                muros[j] = Convert.ToInt32(datos[j]);
            
            for(int j = 1; j < tamanyo; j++)
            {
                if(muros[j] < muros[j-1])
                    saltoDown++;
                else if(muros[j] > muros[j-1])
                    saltoUp++;
            }
            
            Console.WriteLine("{0} {1}", saltoUp, saltoDown);
        }
    }
}
