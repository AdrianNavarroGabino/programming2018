// Adrián Navarro Gabino

using System;

class Mediana
{
    static void Main()
    {
        int casos;
        
        do
        {
            casos = Convert.ToInt32(Console.ReadLine());
            
            if(casos != 0)
            {
                string[] numerosAux = Console.ReadLine().Split();
                int[] numeros = new int[casos];
                
                for(int i = 0; i < casos; i++)
                {
                    numeros[i] = Convert.ToInt32(numerosAux[i]);
                }
                
                for(int i = 0; i < casos - 1; i++)
                {
                    for(int j = i + 1; j < casos; j++)
                    {
                        if(numeros[i] > numeros[j])
                        {
                            int aux = numeros[i];
                            numeros[i] = numeros[j];
                            numeros[j] = aux;
                        }
                    }
                }
                
                if(casos % 2 == 1)
                {
                    Console.WriteLine(numeros[casos / 2] * 2);
                }
                else
                {
                    Console.WriteLine(numeros[casos / 2 - 1] +
                        numeros[casos / 2]);
                }
            }
            
        }while(casos != 0);
        
        
    }
}
