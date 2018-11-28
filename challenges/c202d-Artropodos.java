// Adrián Navarro Gabino

import java.util.*;

public class Artropodos
{
    public static void main(String[] args)
    {
        Scanner entrada = new Scanner(System.in);
        Scanner entrada2 = new Scanner(System.in);
        
        int casosPrueba = entrada.nextInt();
        
        String[] datos;
        int[] artropodos = new int[5];
        
        int patasTotales;
        
        for(int i = 0; i < casosPrueba; i++)
        {
            patasTotales = 0;
            
            datos = entrada2.nextLine().split(" ");
            
            for(int j = 0; j < 5; j++)
            {
                artropodos[j] = Integer.parseInt(datos[j]);
            }
            
            for(int j = 1; j <= 3; j++)
            {
                patasTotales += artropodos[j-1] * (4 + 2 * j);
            }
            
            patasTotales += artropodos[3] * artropodos[4] * 2;
            
            System.out.println(patasTotales);
        }
    }
}
