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

import java.util.*;

public class EncadenandoPalabras
{
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);
        
        String[] cadena = sc.nextLine().split(" ");
        boolean estanEncadenadas = true;
        
        for(int palabra = 0; palabra < cadena.length - 1; palabra++)
        {
            if( cadena[palabra].charAt(cadena[palabra].length() - 1) !=
                cadena[palabra + 1].charAt(1) ||
                cadena[palabra].charAt(cadena[palabra].length() - 2) !=
                cadena[palabra + 1].charAt(0))
            {
                estanEncadenadas = false;
            }
        }
        
        if(estanEncadenadas)
            System.out.println("SI");
        else
            System.out.println("NO");
    }
}
