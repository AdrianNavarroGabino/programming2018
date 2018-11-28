/*
Entrada de ejemplo
gugutata
mata tapa papa pato
seto taco coma matute
sien encima mapa patuco comida
cata tasama malote tejaba batama
kiosko comida
Salida de ejemplo
SI
SI
NO
SI
SI
NO
*/

// Adrián Navarro Gabino

using System;

public class EncadenandoPalabras
{
    public static void Main()
    {
        string[] cadena = Console.ReadLine().Split();
        bool estanEncadenadas = true;
        
        for(int palabra = 0; palabra < cadena.Length - 1; palabra++)
        {
            if( cadena[palabra][cadena[palabra].Length - 1] !=
                cadena[palabra + 1][1] ||
                cadena[palabra][cadena[palabra].Length - 2] !=
                cadena[palabra + 1][0])
            {
                estanEncadenadas = false;
            }
        }
        
        if(estanEncadenadas)
            Console.WriteLine("SI");
        else
            Console.WriteLine("NO");
    }
}
