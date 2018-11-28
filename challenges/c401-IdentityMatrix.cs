// Adrián Navarro Gabino

using System;

public class IdentityMatrix
{
    public static void Main()
    {
        int tamanyo;
        
        do
        {
            tamanyo = Convert.ToInt32(Console.ReadLine());
            int[,] matriz = new int[tamanyo,tamanyo];
            
            bool iden = true;
            
            string[] matrizAux;
            
            for(int fila = 0; fila < tamanyo; fila++)
            {
                matrizAux = Console.ReadLine().Split();
                for(int col = 0; col < tamanyo; col++)
                {
                    matriz[fila,col] = Convert.ToInt32(matrizAux[col]);
                    if((fila == col && matriz[fila,col] != 1) ||
                            (fila != col && matriz[fila,col] != 0))
                    {
                        iden = false;
                    }
                }
            }
            
            if(tamanyo != 0 && iden)
                Console.WriteLine("SI");
            else if(tamanyo != 0 && !iden)
                Console.WriteLine("NO");
        } while(tamanyo != 0);
    }
}
