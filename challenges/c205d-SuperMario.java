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

import java.util.*;

public class SuperMario
{
    public static void main(String[] args)
    {
        Scanner entrada = new Scanner(System.in);
        Scanner entrada2 = new Scanner(System.in);
        Scanner entrada3 = new Scanner(System.in);
        
        byte casosPrueba = entrada.nextByte();
        
        int tamanyo;
        String[] datos;
        
        
        int saltoUp, saltoDown;
        
        for(int i = 0; i < casosPrueba; i++)
        {
            saltoUp = 0;
            saltoDown = 0;
            
            tamanyo = entrada2.nextInt();
            datos = entrada3.nextLine().split(" ");
            int[] muros = new int[tamanyo];
            
            for(int j = 0; j < tamanyo; j++)
                muros[j] = Integer.parseInt(datos[j]);
            
            for(int j = 1; j < tamanyo; j++)
            {
                if(muros[j] < muros[j-1])
                    saltoDown++;
                else if(muros[j] > muros[j-1])
                    saltoUp++;
            }
            
            System.out.println(saltoUp + " " + saltoDown);
        }
    }
}
